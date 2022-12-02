namespace RestoranProje2.frm
{
    partial class frmGarson
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
            this.dgUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUrunler
            // 
            this.dgUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunler.Location = new System.Drawing.Point(65, 58);
            this.dgUrunler.Name = "dgUrunler";
            this.dgUrunler.RowHeadersWidth = 51;
            this.dgUrunler.RowTemplate.Height = 24;
            this.dgUrunler.Size = new System.Drawing.Size(905, 380);
            this.dgUrunler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "GARSON";
            // 
            // frmGarson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUrunler);
            this.Name = "frmGarson";
            this.Text = "frmGarson";
            this.Load += new System.EventHandler(this.frmGarson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUrunler;
        private System.Windows.Forms.Label label1;
    }
}