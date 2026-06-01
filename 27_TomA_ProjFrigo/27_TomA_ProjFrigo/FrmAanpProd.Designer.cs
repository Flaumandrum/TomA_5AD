namespace _27_TomA_ProjFrigo
{
    partial class FrmAanpProd
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
            this.lblKies = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnAanp = new System.Windows.Forms.Button();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(53, 19);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(163, 24);
            this.lblKies.TabIndex = 0;
            this.lblKies.Text = "Kies een product: ";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(222, 16);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(211, 32);
            this.cmbKies.TabIndex = 1;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(42, 70);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(174, 24);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Text = "Naam van product: ";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(22, 119);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(194, 24);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Vervaldatum product: ";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(222, 67);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(211, 29);
            this.txtNaam.TabIndex = 4;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(222, 116);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(211, 29);
            this.txtDatum.TabIndex = 5;
            // 
            // btnAanp
            // 
            this.btnAanp.Location = new System.Drawing.Point(12, 175);
            this.btnAanp.Name = "btnAanp";
            this.btnAanp.Size = new System.Drawing.Size(204, 38);
            this.btnAanp.TabIndex = 6;
            this.btnAanp.Text = "Aanpassen";
            this.btnAanp.UseVisualStyleBackColor = true;
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(229, 175);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(204, 38);
            this.btnAnnul.TabIndex = 7;
            this.btnAnnul.Text = "Annuleren";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // FrmAanpProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 241);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnul);
            this.Controls.Add(this.btnAanp);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAanpProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product aanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnAanp;
        private System.Windows.Forms.Button btnAnnul;
    }
}