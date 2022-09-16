namespace XayDungHeThongQuanLyQuanAn
{
    partial class FrmBan
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
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.flp_Ban = new System.Windows.Forms.FlowLayoutPanel();
            this.lv_Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.cb_Food = new System.Windows.Forms.ComboBox();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Turquoise;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(356, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 37);
            this.label7.TabIndex = 40;
            this.label7.Text = "Bàn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Image = global::XayDungHeThongQuanLyQuanAn.Properties.Resources.chair1;
            this.pictureBox1.Location = new System.Drawing.Point(267, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox5.Location = new System.Drawing.Point(-4, -18);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1024, 638);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // flp_Ban
            // 
            this.flp_Ban.Location = new System.Drawing.Point(12, 112);
            this.flp_Ban.Name = "flp_Ban";
            this.flp_Ban.Size = new System.Drawing.Size(317, 401);
            this.flp_Ban.TabIndex = 42;
            // 
            // lv_Bill
            // 
            this.lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Bill.GridLines = true;
            this.lv_Bill.HideSelection = false;
            this.lv_Bill.Location = new System.Drawing.Point(413, 145);
            this.lv_Bill.Name = "lv_Bill";
            this.lv_Bill.Size = new System.Drawing.Size(484, 365);
            this.lv_Bill.TabIndex = 43;
            this.lv_Bill.UseCompatibleStateImageBehavior = false;
            this.lv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng Tiền";
            this.columnHeader4.Width = 162;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.ForeColor = System.Drawing.Color.Crimson;
            this.txt_TongTien.Location = new System.Drawing.Point(687, 516);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(135, 22);
            this.txt_TongTien.TabIndex = 44;
            this.txt_TongTien.Text = "0";
            this.txt_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(30, 70);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(120, 36);
            this.btn_Edit.TabIndex = 45;
            this.btn_Edit.Text = "EDIT TABLE";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(456, 79);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(215, 21);
            this.cb_Category.TabIndex = 46;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // cb_Food
            // 
            this.cb_Food.FormattingEnabled = true;
            this.cb_Food.Location = new System.Drawing.Point(456, 118);
            this.cb_Food.Name = "cb_Food";
            this.cb_Food.Size = new System.Drawing.Size(215, 21);
            this.cb_Food.TabIndex = 47;
            this.cb_Food.SelectedIndexChanged += new System.EventHandler(this.cb_Food_SelectedIndexChanged);
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(687, 92);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFood.TabIndex = 48;
            this.btn_AddFood.Text = "Thêm Món";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(777, 95);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(57, 20);
            this.nmFoodCount.TabIndex = 49;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 562);
            this.Controls.Add(this.nmFoodCount);
            this.Controls.Add(this.btn_AddFood);
            this.Controls.Add(this.cb_Food);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.lv_Bill);
            this.Controls.Add(this.flp_Ban);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBan";
            this.Text = "FrmBan";
            this.Load += new System.EventHandler(this.FrmBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flp_Ban;
        private System.Windows.Forms.ListView lv_Bill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.ComboBox cb_Food;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
    }
}