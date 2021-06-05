using MaDesktopManager.Enums;
using MaDesktopManager.Models;
using MaDesktopManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaDesktopManager
{
    public partial class MainForm : Form
    {
        RdpServices _rdpServices;
        private List<RdpClientModel> _servers;

        RdpClientModel selectedRdp;
        FileServices _fileServices;
        public FileServices fileServices
        {
            get
            {
                if (_fileServices == null)
                {
                    _fileServices = new FileServices();
                }

                return _fileServices;
            }
        }
        public List<RdpClientModel> servers
        {
            get
            {
                if (_servers == null)
                {
                    _servers = fileServices.getServers();
                }

                return _servers;
            }
        }
        RdpServices rdpServices
        {
            get
            {
                if (_rdpServices == null)
                {
                    _rdpServices = new RdpServices();
                }
                return _rdpServices;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fileServices.getServers();
            setListView();
        }


        private void connectRdp()
        {
            var IpAdress = "172.16.34.245";
            var userName = "Administrator";
            var PasswordSet = "Arge24server";
        }



        private void setListView()
        {
            server_listView.Items.Clear();

            server_listView.View = View.Details;
            server_listView.SmallImageList = ımageList1;
            foreach (var item in servers)
            {
                var row = new ListViewItem(item.ServerName);
                row.ImageKey = ımageList1.Images.Keys[0];
                row.SubItems.Add(item.ServerIpAddress);
                row.SubItems.Add(item.ServerUserName);

                server_listView.Items.Add(row);
            }
        }

        private void server_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                var server = servers[clickedItem.Index];
                rdpServices.ConnectRdpServer(server);
            }

        }

        private void addServer_Click(object sender, EventArgs e)
        {

            addServerEvent();
        }

       private void addServerEvent()
        {
            AddUpdateForm addUpdateForm = new AddUpdateForm(new Models.RdpClientModel(), (int)ServerSaveTypeEnum.Add);
            addUpdateForm.ShowDialog();
            int id = 1;
            if (servers.Count() > 0)
            {
                id = servers.Last().id;
                id++;

            }
            var model = addUpdateForm.model;
            if(model.ServerIpAddress !=null)
            {
                model.id = id;
                _servers.Add(model);

                LoadData();
            }
  
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void update_context_menu_Click(object sender, EventArgs e)
        {
            AddUpdateForm addUpdateForm = new AddUpdateForm(selectedRdp,(int)ServerSaveTypeEnum.Update);
            addUpdateForm.ShowDialog();

            _servers.Where(s => s.id == selectedRdp.id).First().ServerIpAddress = addUpdateForm.model.ServerIpAddress;
            _servers.Where(s => s.id == selectedRdp.id).First().ServerName = addUpdateForm.model.ServerName;
            _servers.Where(s => s.id == selectedRdp.id).First().ServerUserName = addUpdateForm.model.ServerUserName;
            _servers.Where(s => s.id == selectedRdp.id).First().Password = addUpdateForm.model.Password;

            LoadData();



        }

        private void server_listView_MouseDown(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                var server = servers[clickedItem.Index];
                selectedRdp = server;
            }
        }

        private void delte_context_menu_Click(object sender, EventArgs e)
        {
            _servers = servers.Where(s => s.id != selectedRdp.id).ToList();
            LoadData();
        }

        private void LoadData()
        {
            setListView();
            fileServices.setSetting(_servers);

        }

        private void addServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addServerEvent();

        }

        private void abloutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
