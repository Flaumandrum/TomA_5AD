namespace _27_TomA_ProjFrigo
{
    partial class FrmToevoegen
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
            this.btnAnnul = new System.Windows.Forms.Button();
            this.btnToev = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(240, 133);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(201, 38);
            this.btnAnnul.TabIndex = 13;
            this.btnAnnul.Text = "Annuleren";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnToev
            // 
            this.btnToev.Location = new System.Drawing.Point(20, 133);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(204, 38);
            this.btnToev.TabIndex = 12;
            this.btnToev.Text = "Toevoegen";
            this.btnToev.UseVisualStyleBackColor = true;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(230, 74);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(211, 29);
            this.txtDatum.TabIndex = 11;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(230, 25);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(211, 29);
            this.txtNaam.TabIndex = 10;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(30, 77);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(194, 24);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "Vervaldatum product: ";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(50, 28);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(174, 24);
            this.lblNaam.TabIndex = 8;
            this.lblNaam.Text = "Naam van product: ";
            // 
            // FrmToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 196);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnul);
            this.Controls.Add(this.btnToev);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnToev;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblNaam;
    }
}