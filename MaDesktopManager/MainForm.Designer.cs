
namespace MaDesktopManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_server_ip_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_user_name = new System.Windows.Forms.TextBox();
            this.tb_server_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.server_listView = new System.Windows.Forms.ListView();
            this.server_name_cl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_add_server = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delte_context_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.update_context_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.context_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_server_ip_address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.btn_add_server);
            this.groupBox1.Controls.Add(this.tb_user_name);
            this.groupBox1.Controls.Add(this.tb_server_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Server";
            // 
            // tb_server_ip_address
            // 
            this.tb_server_ip_address.BackColor = System.Drawing.SystemColors.Info;
            this.tb_server_ip_address.Location = new System.Drawing.Point(142, 62);
            this.tb_server_ip_address.Name = "tb_server_ip_address";
            this.tb_server_ip_address.Size = new System.Drawing.Size(397, 22);
            this.tb_server_ip_address.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Server IP Address";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Info;
            this.tb_password.Location = new System.Drawing.Point(378, 93);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(161, 22);
            this.tb_password.TabIndex = 5;
            // 
            // tb_user_name
            // 
            this.tb_user_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_user_name.Location = new System.Drawing.Point(142, 93);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(153, 22);
            this.tb_user_name.TabIndex = 4;
            // 
            // tb_server_name
            // 
            this.tb_server_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_server_name.Location = new System.Drawing.Point(142, 31);
            this.tb_server_name.Name = "tb_server_name";
            this.tb_server_name.Size = new System.Drawing.Size(397, 22);
            this.tb_server_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.server_listView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 453);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servers";
            // 
            // server_listView
            // 
            this.server_listView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.server_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.server_name_cl,
            this.columnHeader1,
            this.columnHeader2});
            this.server_listView.ContextMenuStrip = this.context_menu;
            this.server_listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.server_listView.GridLines = true;
            this.server_listView.HideSelection = false;
            this.server_listView.Location = new System.Drawing.Point(3, 26);
            this.server_listView.Name = "server_listView";
            this.server_listView.Size = new System.Drawing.Size(703, 424);
            this.server_listView.TabIndex = 0;
            this.server_listView.UseCompatibleStateImageBehavior = false;
            this.server_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.server_listView_MouseDoubleClick);
            // 
            // server_name_cl
            // 
            this.server_name_cl.Tag = "Server Name";
            this.server_name_cl.Text = "Server Name";
            this.server_name_cl.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ip Address";
            this.columnHeader1.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Created by Musa Adsız";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User Name";
            this.columnHeader2.Width = 150;
            // 
            // btn_add_server
            // 
            this.btn_add_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_server.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add_server.Location = new System.Drawing.Point(545, 31);
            this.btn_add_server.Name = "btn_add_server";
            this.btn_add_server.Size = new System.Drawing.Size(139, 84);
            this.btn_add_server.TabIndex = 0;
            this.btn_add_server.Text = "Add Server";
            this.btn_add_server.UseVisualStyleBackColor = true;
            this.btn_add_server.Click += new System.EventHandler(this.btn_add_server_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Remote_Desktop.png");
            this.ımageList1.Images.SetKeyName(1, "rdp.jpg");
            // 
            // context_menu
            // 
            this.context_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delte_context_menu,
            this.update_context_menu});
            this.context_menu.Name = "context_menu";
            this.context_menu.Size = new System.Drawing.Size(128, 52);
            // 
            // delte_context_menu
            // 
            this.delte_context_menu.Name = "delte_context_menu";
            this.delte_context_menu.Size = new System.Drawing.Size(210, 24);
            this.delte_context_menu.Text = "Delete";
            // 
            // update_context_menu
            // 
            this.update_context_menu.Name = "update_context_menu";
            this.update_context_menu.Size = new System.Drawing.Size(210, 24);
            this.update_context_menu.Text = "Update";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 636);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MA Desktop Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.context_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_server;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user_name;
        private System.Windows.Forms.TextBox tb_server_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_server_ip_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView server_listView;
        private System.Windows.Forms.ColumnHeader server_name_cl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip context_menu;
        private System.Windows.Forms.ToolStripMenuItem delte_context_menu;
        private System.Windows.Forms.ToolStripMenuItem update_context_menu;
    }
}