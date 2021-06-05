
namespace MaDesktopManager
{
    partial class AddUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_server_ip_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_add_server = new System.Windows.Forms.Button();
            this.tb_user_name = new System.Windows.Forms.TextBox();
            this.tb_server_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(596, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Server";
            // 
            // tb_server_ip_address
            // 
            this.tb_server_ip_address.BackColor = System.Drawing.SystemColors.Info;
            this.tb_server_ip_address.Location = new System.Drawing.Point(106, 50);
            this.tb_server_ip_address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_server_ip_address.Name = "tb_server_ip_address";
            this.tb_server_ip_address.Size = new System.Drawing.Size(299, 20);
            this.tb_server_ip_address.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Server IP Address";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Info;
            this.tb_password.Location = new System.Drawing.Point(284, 76);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(122, 20);
            this.tb_password.TabIndex = 5;
            // 
            // btn_add_server
            // 
            this.btn_add_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_server.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add_server.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_server.ImageIndex = 0;
            this.btn_add_server.ImageList = this.ımageList1;
            this.btn_add_server.Location = new System.Drawing.Point(409, 25);
            this.btn_add_server.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_server.Name = "btn_add_server";
            this.btn_add_server.Size = new System.Drawing.Size(155, 68);
            this.btn_add_server.TabIndex = 0;
            this.btn_add_server.Text = "Add Server";
            this.btn_add_server.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_server.UseVisualStyleBackColor = true;
            this.btn_add_server.Click += new System.EventHandler(this.btn_add_server_Click);
            // 
            // tb_user_name
            // 
            this.tb_user_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_user_name.Location = new System.Drawing.Point(106, 76);
            this.tb_user_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(116, 20);
            this.tb_user_name.TabIndex = 4;
            // 
            // tb_server_name
            // 
            this.tb_server_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_server_name.Location = new System.Drawing.Point(106, 25);
            this.tb_server_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_server_name.Name = "tb_server_name";
            this.tb_server_name.Size = new System.Drawing.Size(299, 20);
            this.tb_server_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Remote_Desktop.png");
            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 170);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Server";
            this.Load += new System.EventHandler(this.AddUpdateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_server_ip_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_add_server;
        private System.Windows.Forms.TextBox tb_user_name;
        private System.Windows.Forms.TextBox tb_server_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}