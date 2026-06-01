namespace _27_TomA_ProjFrigo
{
    partial class FrmVerwProd
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
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.btnVerw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(225, 33);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(211, 32);
            this.cmbKies.TabIndex = 3;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(56, 36);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(163, 24);
            this.lblKies.TabIndex = 2;
            this.lblKies.Text = "Kies een product: ";
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(235, 83);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(201, 38);
            this.btnAnnul.TabIndex = 9;
            this.btnAnnul.Text = "Annuleren";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnVerw
            // 
            this.btnVerw.Location = new System.Drawing.Point(12, 83);
            this.btnVerw.Name = "btnVerw";
            this.btnVerw.Size = new System.Drawing.Size(204, 38);
            this.btnVerw.TabIndex = 8;
            this.btnVerw.Text = "Verwijderen";
            this.btnVerw.UseVisualStyleBackColor = true;
            // 
            // FrmVerwProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 150);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnul);
            this.Controls.Add(this.btnVerw);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmVerwProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product verwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnVerw;
    }
}