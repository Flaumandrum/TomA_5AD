namespace _26_TomA_Proj_Prikklok
{
    partial class FrmInlogAdm
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
            this.btnInlog = new System.Windows.Forms.Button();
            this.txtWw = new System.Windows.Forms.TextBox();
            this.lblWw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(198, 93);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(165, 43);
            this.btnTerug.TabIndex = 7;
            this.btnTerug.Text = "Annuleren";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnInlog
            // 
            this.btnInlog.Location = new System.Drawing.Point(29, 93);
            this.btnInlog.Name = "btnInlog";
            this.btnInlog.Size = new System.Drawing.Size(165, 43);
            this.btnInlog.TabIndex = 6;
            this.btnInlog.Text = "Inloggen";
            this.btnInlog.UseVisualStyleBackColor = true;
            this.btnInlog.Click += new System.EventHandler(this.btnInlog_Click);
            // 
            // txtWw
            // 
            this.txtWw.Location = new System.Drawing.Point(194, 26);
            this.txtWw.Name = "txtWw";
            this.txtWw.Size = new System.Drawing.Size(169, 29);
            this.txtWw.TabIndex = 5;
            // 
            // lblWw
            // 
            this.lblWw.AutoSize = true;
            this.lblWw.Location = new System.Drawing.Point(25, 29);
            this.lblWw.Name = "lblWw";
            this.lblWw.Size = new System.Drawing.Size(126, 24);
            this.lblWw.TabIndex = 4;
            this.lblWw.Text = "Wachtwoord: ";
            // 
            // FrmInlogAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 168);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnInlog);
            this.Controls.Add(this.txtWw);
            this.Controls.Add(this.lblWw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmInlogAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggen admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnInlog;
        private System.Windows.Forms.TextBox txtWw;
        private System.Windows.Forms.Label lblWw;
    }
}