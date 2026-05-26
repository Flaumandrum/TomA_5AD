namespace _26_TomA_Proj_Prikklok
{
    partial class FrmRegWn
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
            this.components = new System.ComponentModel.Container();
            this.lblReg = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lbltekst = new System.Windows.Forms.Label();
            this.wacht = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(25, 29);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(138, 24);
            this.lblReg.TabIndex = 0;
            this.lblReg.Text = "Geef uw code: ";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(194, 26);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(169, 29);
            this.txtReg.TabIndex = 1;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(29, 140);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(165, 43);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Registreer";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(198, 140);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(165, 43);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Annuleren";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lbltekst
            // 
            this.lbltekst.AutoSize = true;
            this.lbltekst.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lbltekst.Location = new System.Drawing.Point(25, 72);
            this.lbltekst.Name = "lbltekst";
            this.lbltekst.Size = new System.Drawing.Size(0, 24);
            this.lbltekst.TabIndex = 4;
            // 
            // FrmRegWn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 206);
            this.ControlBox = false;
            this.Controls.Add(this.lbltekst);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.lblReg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmRegWn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registreer je als werknemer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lbltekst;
        private System.Windows.Forms.Timer wacht;
    }
}