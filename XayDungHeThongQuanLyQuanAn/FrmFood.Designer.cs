namespace XayDungHeThongQuanLyQuanAn
{
    partial class FrmFood
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
            this.lst_categories = new System.Windows.Forms.ListBox();
            this.lv_food = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_categories
            // 
            this.lst_categories.FormattingEnabled = true;
            this.lst_categories.ItemHeight = 16;
            this.lst_categories.Location = new System.Drawing.Point(13, 107);
            this.lst_categories.Margin = new System.Windows.Forms.Padding(4);
            this.lst_categories.Name = "lst_categories";
            this.lst_categories.Size = new System.Drawing.Size(271, 308);
            this.lst_categories.TabIndex = 12;
            this.lst_categories.SelectedIndexChanged += new System.EventHandler(this.lst_categories_SelectedIndexChanged);
            // 
            // lv_food
            // 
            this.lv_food.HideSelection = false;
            this.lv_food.Location = new System.Drawing.Point(464, 107);
            this.lv_food.Margin = new System.Windows.Forms.Padding(4);
            this.lv_food.Name = "lv_food";
            this.lv_food.Size = new System.Drawing.Size(541, 301);
            this.lv_food.TabIndex = 13;
            this.lv_food.UseCompatibleStateImageBehavior = false;
            this.lv_food.View = System.Windows.Forms.View.Details;
            this.lv_food.SelectedIndexChanged += new System.EventHandler(this.lv_food_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XayDungHeThongQuanLyQuanAn.Properties.Resources.diet__1_;
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Turquoise;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(420, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 46);
            this.label7.TabIndex = 32;
            this.label7.Text = "Food";
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lv_food);
            this.Controls.Add(this.lst_categories);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFood";
            this.Text = "FrmFood";
            this.Load += new System.EventHandler(this.FrmFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_categories;
        private System.Windows.Forms.ListView lv_food;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}