using MaDesktopManager.Models;
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

        public List<RdpClientModel> servers
        {
            get
            {
                if (_servers == null)
                {
                    _servers = _rdpServices.GetServer();
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

        }


        private void connectRdp()
        {
            var IpAdress = "172.16.34.245";
            var userName = "Administrator";
            var PasswordSet = "Arge24server";
        }

        private void btn_add_server_Click(object sender, EventArgs e)
        {
            var model = new Models.RdpClientModel
            {
                ServerName = tb_server_name.Text.Trim(),
                ServerIpAddress = tb_server_ip_address.Text.Trim(),
                Password = tb_password.Text.Trim(),
                ServerUserName = tb_user_name.Text.Trim()

            };

            rdpServices.AddServer(model);

            _servers = rdpServices.GetServer();
            setListView();

        }

        private void setListView()
        {
            server_listView.Items.Clear();

            server_listView.View = View.Details;
            foreach (var item in servers)
            {
                var row = new ListViewItem(item.ServerName);
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
    }
}
