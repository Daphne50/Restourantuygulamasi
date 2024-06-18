
namespace Restaurant
{
    partial class FrmÜrünler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.numericfiyat = new System.Windows.Forms.NumericUpDown();
            this.lssturunler = new System.Windows.Forms.ListView();
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericfiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(28, 46);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(100, 22);
            this.txtadi.TabIndex = 2;
            // 
            // numericfiyat
            // 
            this.numericfiyat.Location = new System.Drawing.Point(138, 46);
            this.numericfiyat.Name = "numericfiyat";
            this.numericfiyat.Size = new System.Drawing.Size(120, 22);
            this.numericfiyat.TabIndex = 3;
            // 
            // lssturunler
            // 
            this.lssturunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.Fiyat});
            this.lssturunler.FullRowSelect = true;
            this.lssturunler.GridLines = true;
            this.lssturunler.HideSelection = false;
            this.lssturunler.Location = new System.Drawing.Point(28, 74);
            this.lssturunler.Name = "lssturunler";
            this.lssturunler.Size = new System.Drawing.Size(311, 364);
            this.lssturunler.TabIndex = 4;
            this.lssturunler.UseCompatibleStateImageBehavior = false;
            this.lssturunler.View = System.Windows.Forms.View.Details;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.Width = 108;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.Width = 49;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(264, 45);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // FrmÜrünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 593);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.lssturunler);
            this.Controls.Add(this.numericfiyat);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmÜrünler";
            this.Text = "FrmÜrünler";
            this.Load += new System.EventHandler(this.FrmÜrünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericfiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.NumericUpDown numericfiyat;
        private System.Windows.Forms.ListView lssturunler;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.Button BtnEkle;
    }
}