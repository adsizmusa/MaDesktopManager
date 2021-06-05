
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
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.addServer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.server_listView = new System.Windows.Forms.ListView();
            this.server_name_cl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delte_context_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.update_context_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.context_menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addServer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(778, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote Desktop Manager";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "rdp.jpg");
            this.ımageList1.Images.SetKeyName(1, "Remote_Desktop.png");
            this.ımageList1.Images.SetKeyName(2, "export_icon.png");
            this.ımageList1.Images.SetKeyName(3, "import.png");
            // 
            // addServer
            // 
            this.addServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addServer.ImageKey = "rdp.jpg";
            this.addServer.ImageList = this.ımageList1;
            this.addServer.Location = new System.Drawing.Point(4, 25);
            this.addServer.Margin = new System.Windows.Forms.Padding(2);
            this.addServer.Name = "addServer";
            this.addServer.Size = new System.Drawing.Size(152, 54);
            this.addServer.TabIndex = 0;
            this.addServer.Text = "Add Server";
            this.addServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addServer.UseVisualStyleBackColor = true;
            this.addServer.Click += new System.EventHandler(this.addServer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.server_listView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(781, 528);
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
            this.server_listView.Location = new System.Drawing.Point(2, 21);
            this.server_listView.Margin = new System.Windows.Forms.Padding(2);
            this.server_listView.Name = "server_listView";
            this.server_listView.Size = new System.Drawing.Size(777, 505);
            this.server_listView.TabIndex = 0;
            this.server_listView.UseCompatibleStateImageBehavior = false;
            this.server_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.server_listView_MouseDoubleClick);
            this.server_listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.server_listView_MouseDown);
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
            // columnHeader2
            // 
            this.columnHeader2.Text = "User Name";
            this.columnHeader2.Width = 150;
            // 
            // context_menu
            // 
            this.context_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delte_context_menu,
            this.update_context_menu});
            this.context_menu.Name = "context_menu";
            this.context_menu.Size = new System.Drawing.Size(181, 70);
            // 
            // delte_context_menu
            // 
            this.delte_context_menu.Name = "delte_context_menu";
            this.delte_context_menu.Size = new System.Drawing.Size(180, 22);
            this.delte_context_menu.Text = "Delete";
            this.delte_context_menu.Click += new System.EventHandler(this.delte_context_menu_Click);
            // 
            // update_context_menu
            // 
            this.update_context_menu.Name = "update_context_menu";
            this.update_context_menu.Size = new System.Drawing.Size(180, 22);
            this.update_context_menu.Text = "Update";
            this.update_context_menu.Click += new System.EventHandler(this.update_context_menu_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 664);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Created by Musa Adsız";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::MaDesktopManager.Properties.Resources.export_icon;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = global::MaDesktopManager.Properties.Resources.import;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "&İmport";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 679);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MA Desktop Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.context_menu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView server_listView;
        private System.Windows.Forms.ColumnHeader server_name_cl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip context_menu;
        private System.Windows.Forms.ToolStripMenuItem delte_context_menu;
        private System.Windows.Forms.ToolStripMenuItem update_context_menu;
        private System.Windows.Forms.Button addServer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}