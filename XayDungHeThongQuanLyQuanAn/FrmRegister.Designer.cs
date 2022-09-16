namespace XayDungHeThongQuanLyQuanAn
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_Id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ChucVu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Manv = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // txt_Id
            // 
            this.txt_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Id.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Id.HintText = "";
            this.txt_Id.isPassword = false;
            this.txt_Id.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_Id.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Id.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_Id.LineThickness = 3;
            this.txt_Id.Location = new System.Drawing.Point(536, 101);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(208, 30);
            this.txt_Id.TabIndex = 14;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Password
            // 
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Password.HintText = "";
            this.txt_Password.isPassword = false;
            this.txt_Password.LineFocusedColor = System.Drawing.Color.Violet;
            this.txt_Password.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txt_Password.LineMouseHoverColor = System.Drawing.Color.Violet;
            this.txt_Password.LineThickness = 3;
            this.txt_Password.Location = new System.Drawing.Point(536, 193);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(208, 30);
            this.txt_Password.TabIndex = 15;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChucVu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ChucVu.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ChucVu.HintText = "";
            this.txt_ChucVu.isPassword = false;
            this.txt_ChucVu.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_ChucVu.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txt_ChucVu.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_ChucVu.LineThickness = 3;
            this.txt_ChucVu.Location = new System.Drawing.Point(536, 243);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(208, 30);
            this.txt_ChucVu.TabIndex = 16;
            this.txt_ChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Username
            // 
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Username.HintText = "";
            this.txt_Username.isPassword = false;
            this.txt_Username.LineFocusedColor = System.Drawing.Color.LightCoral;
            this.txt_Username.LineIdleColor = System.Drawing.Color.Silver;
            this.txt_Username.LineMouseHoverColor = System.Drawing.Color.LightCoral;
            this.txt_Username.LineThickness = 3;
            this.txt_Username.Location = new System.Drawing.Point(536, 147);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(208, 30);
            this.txt_Username.TabIndex = 17;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Username.OnValueChanged += new System.EventHandler(this.txt_Username_OnValueChanged);
            // 
            // txt_Manv
            // 
            this.txt_Manv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Manv.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Manv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Manv.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Manv.HintText = "";
            this.txt_Manv.isPassword = false;
            this.txt_Manv.LineFocusedColor = System.Drawing.Color.SpringGreen;
            this.txt_Manv.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txt_Manv.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.txt_Manv.LineThickness = 3;
            this.txt_Manv.Location = new System.Drawing.Point(536, 296);
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.Size = new System.Drawing.Size(208, 30);
            this.txt_Manv.TabIndex = 18;
            this.txt_Manv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(169, 15);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(530, 62);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Đăng ký thành viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XayDungHeThongQuanLyQuanAn.Properties.Resources.register;
            this.pictureBox1.Location = new System.Drawing.Point(34, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 288);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.ActiveBorderThickness = 1;
            this.btn_back.ActiveCornerRadius = 20;
            this.btn_back.ActiveFillColor = System.Drawing.Color.Red;
            this.btn_back.ActiveForecolor = System.Drawing.Color.White;
            this.btn_back.ActiveLineColor = System.Drawing.Color.Red;
            this.btn_back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.ButtonText = "Quay lại";
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_back.IdleBorderThickness = 1;
            this.btn_back.IdleCornerRadius = 20;
            this.btn_back.IdleFillColor = System.Drawing.Color.White;
            this.btn_back.IdleForecolor = System.Drawing.Color.Red;
            this.btn_back.IdleLineColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(445, 360);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(136, 48);
            this.btn_back.TabIndex = 23;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.ActiveBorderThickness = 1;
            this.btn_Register.ActiveCornerRadius = 20;
            this.btn_Register.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Register.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Register.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_Register.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Register.BackgroundImage")));
            this.btn_Register.ButtonText = "Đăng Ký";
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Register.IdleBorderThickness = 1;
            this.btn_Register.IdleCornerRadius = 20;
            this.btn_Register.IdleFillColor = System.Drawing.Color.White;
            this.btn_Register.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btn_Register.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_Register.Location = new System.Drawing.Point(608, 360);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(136, 48);
            this.btn_Register.TabIndex = 22;
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click_1);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_Manv);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_ChucVu);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ChucVu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Manv;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Register;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}