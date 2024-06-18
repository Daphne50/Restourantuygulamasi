
namespace Restaurant
{
    partial class frmmasadetay
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
            this.lblmasano = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.combourun = new System.Windows.Forms.ComboBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.lblurun = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbltoplamtutar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmasano
            // 
            this.lblmasano.AutoSize = true;
            this.lblmasano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmasano.Location = new System.Drawing.Point(7, 24);
            this.lblmasano.Name = "lblmasano";
            this.lblmasano.Size = new System.Drawing.Size(98, 25);
            this.lblmasano.TabIndex = 0;
            this.lblmasano.Text = "Masa No";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(381, 469);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 209;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyatı";
            this.columnHeader2.Width = 149;
            // 
            // combourun
            // 
            this.combourun.FormattingEnabled = true;
            this.combourun.Location = new System.Drawing.Point(12, 76);
            this.combourun.Name = "combourun";
            this.combourun.Size = new System.Drawing.Size(134, 24);
            this.combourun.TabIndex = 2;
            this.combourun.SelectedIndexChanged += new System.EventHandler(this.combourun_SelectedIndexChanged);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(152, 76);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lblurun
            // 
            this.lblurun.AutoSize = true;
            this.lblurun.Location = new System.Drawing.Point(12, 49);
            this.lblurun.Name = "lblurun";
            this.lblurun.Size = new System.Drawing.Size(39, 17);
            this.lblurun.TabIndex = 4;
            this.lblurun.Text = "Ürün";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbltoplamtutar);
            this.groupBox1.Location = new System.Drawing.Point(244, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Tutar";
            // 
            // Lbltoplamtutar
            // 
            this.Lbltoplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbltoplamtutar.Location = new System.Drawing.Point(6, 18);
            this.Lbltoplamtutar.Name = "Lbltoplamtutar";
            this.Lbltoplamtutar.Size = new System.Drawing.Size(137, 91);
            this.Lbltoplamtutar.TabIndex = 6;
            this.Lbltoplamtutar.Text = "0₺";
            this.Lbltoplamtutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbltoplamtutar.Click += new System.EventHandler(this.Lbltoplamtutar_Click);
            // 
            // frmmasadetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblurun);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.combourun);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblmasano);
            this.Name = "frmmasadetay";
            this.Text = "frmmasadetay";
            this.Load += new System.EventHandler(this.frmmasadetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmasano;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox combourun;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label lblurun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbltoplamtutar;
    }
}