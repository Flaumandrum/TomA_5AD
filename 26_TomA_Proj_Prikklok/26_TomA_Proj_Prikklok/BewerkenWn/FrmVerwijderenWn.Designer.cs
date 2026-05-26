namespace _26_TomA_Proj_Prikklok
{
    partial class FrmVerwijderenWn
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
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnVerw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(252, 28);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(208, 32);
            this.cmbKies.TabIndex = 19;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(30, 31);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(189, 24);
            this.lblKies.TabIndex = 18;
            this.lblKies.Text = "Kies een werknemer:";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(252, 81);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(208, 43);
            this.btnTerug.TabIndex = 21;
            this.btnTerug.Text = "Annuleren";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnVerw
            // 
            this.btnVerw.Location = new System.Drawing.Point(34, 81);
            this.btnVerw.Name = "btnVerw";
            this.btnVerw.Size = new System.Drawing.Size(208, 43);
            this.btnVerw.TabIndex = 20;
            this.btnVerw.Text = "Verwijderen";
            this.btnVerw.UseVisualStyleBackColor = true;
            this.btnVerw.Click += new System.EventHandler(this.btnVerw_Click);
            // 
            // FrmVerwijderenWn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 157);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnVerw);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmVerwijderenWn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwijderen werknemer";
            this.Load += new System.EventHandler(this.FrmVerwijderenWn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnVerw;
    }
}