namespace _26_TomA_Proj_Prikklok
{
    partial class FrmAanpassenWn
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnAanp = new System.Windows.Forms.Button();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtVn = new System.Windows.Forms.TextBox();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblVn = new System.Windows.Forms.Label();
            this.lblKies = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(251, 191);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(208, 43);
            this.btnTerug.TabIndex = 15;
            this.btnTerug.Text = "Annuleren";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnAanp
            // 
            this.btnAanp.Location = new System.Drawing.Point(33, 191);
            this.btnAanp.Name = "btnAanp";
            this.btnAanp.Size = new System.Drawing.Size(208, 43);
            this.btnAanp.TabIndex = 14;
            this.btnAanp.Text = "Aanpassen";
            this.btnAanp.UseVisualStyleBackColor = true;
            this.btnAanp.Click += new System.EventHandler(this.btnAanp_Click);
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(251, 135);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(208, 29);
            this.txtAn.TabIndex = 13;
            // 
            // txtVn
            // 
            this.txtVn.Location = new System.Drawing.Point(251, 93);
            this.txtVn.Name = "txtVn";
            this.txtVn.Size = new System.Drawing.Size(208, 29);
            this.txtVn.TabIndex = 12;
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(40, 138);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(186, 24);
            this.lblAn.TabIndex = 11;
            this.lblAn.Text = "Geef de achternaam:";
            // 
            // lblVn
            // 
            this.lblVn.AutoSize = true;
            this.lblVn.Location = new System.Drawing.Point(40, 98);
            this.lblVn.Name = "lblVn";
            this.lblVn.Size = new System.Drawing.Size(171, 24);
            this.lblVn.TabIndex = 10;
            this.lblVn.Text = "Geef de voornaam:";
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(44, 44);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(189, 24);
            this.lblKies.TabIndex = 16;
            this.lblKies.Text = "Kies een werknemer:";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(251, 41);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(208, 32);
            this.cmbKies.TabIndex = 17;
            // 
            // FrmAanpassenWn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 263);
            this.ControlBox = false;
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnAanp);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtVn);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblVn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAanpassenWn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gegevens werknemer aanpassen";
            this.Load += new System.EventHandler(this.FrmAanpassenWn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnAanp;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtVn;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblVn;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.ComboBox cmbKies;
    }
}