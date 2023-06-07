namespace GoruntuSifreleme
{
    partial class Form1
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
            this.pct_orijinalGoruntu = new System.Windows.Forms.PictureBox();
            this.btn_sifrele = new System.Windows.Forms.Button();
            this.btn_desifrele = new System.Windows.Forms.Button();
            this.pct_sonucGoruntu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_orijinalGoruntu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_sonucGoruntu)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_orijinalGoruntu
            // 
            this.pct_orijinalGoruntu.BackColor = System.Drawing.Color.White;
            this.pct_orijinalGoruntu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pct_orijinalGoruntu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_orijinalGoruntu.Location = new System.Drawing.Point(13, 13);
            this.pct_orijinalGoruntu.Name = "pct_orijinalGoruntu";
            this.pct_orijinalGoruntu.Size = new System.Drawing.Size(350, 350);
            this.pct_orijinalGoruntu.TabIndex = 0;
            this.pct_orijinalGoruntu.TabStop = false;
            this.pct_orijinalGoruntu.Click += new System.EventHandler(this.pct_orijinalGoruntu_Click);
            // 
            // btn_sifrele
            // 
            this.btn_sifrele.Location = new System.Drawing.Point(396, 106);
            this.btn_sifrele.Name = "btn_sifrele";
            this.btn_sifrele.Size = new System.Drawing.Size(75, 23);
            this.btn_sifrele.TabIndex = 1;
            this.btn_sifrele.Text = "Şifrele";
            this.btn_sifrele.UseVisualStyleBackColor = true;
            this.btn_sifrele.Click += new System.EventHandler(this.btn_sifrele_Click);
            // 
            // btn_desifrele
            // 
            this.btn_desifrele.Location = new System.Drawing.Point(396, 180);
            this.btn_desifrele.Name = "btn_desifrele";
            this.btn_desifrele.Size = new System.Drawing.Size(75, 23);
            this.btn_desifrele.TabIndex = 2;
            this.btn_desifrele.Text = "Deşifrele";
            this.btn_desifrele.UseVisualStyleBackColor = true;
            this.btn_desifrele.Click += new System.EventHandler(this.btn_desifrele_Click);
            // 
            // pct_sonucGoruntu
            // 
            this.pct_sonucGoruntu.BackColor = System.Drawing.Color.White;
            this.pct_sonucGoruntu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pct_sonucGoruntu.Location = new System.Drawing.Point(506, 13);
            this.pct_sonucGoruntu.Name = "pct_sonucGoruntu";
            this.pct_sonucGoruntu.Size = new System.Drawing.Size(350, 350);
            this.pct_sonucGoruntu.TabIndex = 3;
            this.pct_sonucGoruntu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 472);
            this.Controls.Add(this.pct_sonucGoruntu);
            this.Controls.Add(this.btn_desifrele);
            this.Controls.Add(this.btn_sifrele);
            this.Controls.Add(this.pct_orijinalGoruntu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct_orijinalGoruntu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_sonucGoruntu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_orijinalGoruntu;
        private System.Windows.Forms.Button btn_sifrele;
        private System.Windows.Forms.Button btn_desifrele;
        private System.Windows.Forms.PictureBox pct_sonucGoruntu;
    }
}

