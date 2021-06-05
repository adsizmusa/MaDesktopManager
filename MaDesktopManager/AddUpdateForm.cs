using MaDesktopManager.Enums;
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
    public partial class AddUpdateForm : Form
    {
        string title;
        public RdpClientModel model;
        public AddUpdateForm(RdpClientModel _model, int _serverAddType)
        {
            InitializeComponent();

            model = _model;
            tb_server_name.Text = model.ServerName;
            tb_server_ip_address.Text = model.ServerIpAddress;
            tb_password.Text = model.Password;
            tb_user_name.Text = model.ServerUserName;
            if(_serverAddType == (int)ServerSaveTypeEnum.Update)
            {
                Text = "Udpate Server Information";
                title = "Update";
                btn_add_server.Text = title;
                groupBox1.Text = title +" Server";
            }

        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_server_Click(object sender, EventArgs e)
        {
            model = new Models.RdpClientModel
            {
                ServerName = tb_server_name.Text.Trim(),
                ServerIpAddress = tb_server_ip_address.Text.Trim(),
                Password = tb_password.Text.Trim(),
                ServerUserName = tb_user_name.Text.Trim()
            };

            Hide();
        }
    }
}
