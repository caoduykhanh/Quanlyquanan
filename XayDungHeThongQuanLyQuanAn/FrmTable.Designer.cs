namespace XayDungHeThongQuanLyQuanAn
{
    partial class FrmTable
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
            this.gv_Table = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Tenban = new System.Windows.Forms.TextBox();
            this.txt_Songuoi = new System.Windows.Forms.TextBox();
            this.txt_Makv = new System.Windows.Forms.TextBox();
            this.txt_Trangthai = new System.Windows.Forms.TextBox();
            this.txt_Maban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_TrangThai = new System.Windows.Forms.Label();
            this.btn_Themban = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Table)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_Table
            // 
            this.gv_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Table.Location = new System.Drawing.Point(84, 67);
            this.gv_Table.Name = "gv_Table";
            this.gv_Table.Size = new System.Drawing.Size(626, 150);
            this.gv_Table.TabIndex = 0;
            this.gv_Table.Click += new System.EventHandler(this.gv_Table_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(84, 25);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(340, 20);
            this.txt_Search.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(472, 21);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Tenban
            // 
            this.txt_Tenban.Location = new System.Drawing.Point(84, 303);
            this.txt_Tenban.Name = "txt_Tenban";
            this.txt_Tenban.Size = new System.Drawing.Size(340, 20);
            this.txt_Tenban.TabIndex = 3;
            // 
            // txt_Songuoi
            // 
            this.txt_Songuoi.Location = new System.Drawing.Point(84, 345);
            this.txt_Songuoi.Name = "txt_Songuoi";
            this.txt_Songuoi.Size = new System.Drawing.Size(340, 20);
            this.txt_Songuoi.TabIndex = 4;
            // 
            // txt_Makv
            // 
            this.txt_Makv.Location = new System.Drawing.Point(84, 383);
            this.txt_Makv.Name = "txt_Makv";
            this.txt_Makv.Size = new System.Drawing.Size(340, 20);
            this.txt_Makv.TabIndex = 5;
            // 
            // txt_Trangthai
            // 
            this.txt_Trangthai.Location = new System.Drawing.Point(84, 418);
            this.txt_Trangthai.Name = "txt_Trangthai";
            this.txt_Trangthai.Size = new System.Drawing.Size(340, 20);
            this.txt_Trangthai.TabIndex = 6;
            // 
            // txt_Maban
            // 
            this.txt_Maban.Location = new System.Drawing.Point(84, 255);
            this.txt_Maban.Name = "txt_Maban";
            this.txt_Maban.Size = new System.Drawing.Size(340, 20);
            this.txt_Maban.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MaBan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TenBan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SoNguoi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "MaKV";
            // 
            // lb_TrangThai
            // 
            this.lb_TrangThai.AutoSize = true;
            this.lb_TrangThai.Location = new System.Drawing.Point(12, 421);
            this.lb_TrangThai.Name = "lb_TrangThai";
            this.lb_TrangThai.Size = new System.Drawing.Size(56, 13);
            this.lb_TrangThai.TabIndex = 12;
            this.lb_TrangThai.Text = "TrangThai";
            // 
            // btn_Themban
            // 
            this.btn_Themban.Location = new System.Drawing.Point(504, 258);
            this.btn_Themban.Name = "btn_Themban";
            this.btn_Themban.Size = new System.Drawing.Size(75, 23);
            this.btn_Themban.TabIndex = 13;
            this.btn_Themban.Text = "THÊM BÀN";
            this.btn_Themban.UseVisualStyleBackColor = true;
            this.btn_Themban.Click += new System.EventHandler(this.btn_Themban_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(605, 258);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "XÓA BÀN";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1082, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Themban);
            this.Controls.Add(this.lb_TrangThai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Maban);
            this.Controls.Add(this.txt_Trangthai);
            this.Controls.Add(this.txt_Makv);
            this.Controls.Add(this.txt_Songuoi);
            this.Controls.Add(this.txt_Tenban);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.gv_Table);
            this.Name = "FrmTable";
            this.Text = "FrmTable";
            this.Load += new System.EventHandler(this.FrmTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Table)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Table;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Tenban;
        private System.Windows.Forms.TextBox txt_Songuoi;
        private System.Windows.Forms.TextBox txt_Makv;
        private System.Windows.Forms.TextBox txt_Trangthai;
        private System.Windows.Forms.TextBox txt_Maban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_TrangThai;
        private System.Windows.Forms.Button btn_Themban;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}