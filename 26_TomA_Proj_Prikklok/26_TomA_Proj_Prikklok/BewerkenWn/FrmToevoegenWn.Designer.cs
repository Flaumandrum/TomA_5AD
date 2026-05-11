namespace _26_TomA_Proj_Prikklok
{
    partial class FrmToevoegenWn
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
            this.lblVn = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.txtVn = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnToev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVn
            // 
            this.lblVn.AutoSize = true;
            this.lblVn.Location = new System.Drawing.Point(28, 29);
            this.lblVn.Name = "lblVn";
            this.lblVn.Size = new System.Drawing.Size(171, 24);
            this.lblVn.TabIndex = 0;
            this.lblVn.Text = "Geef de voornaam:";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(28, 69);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(186, 24);
            this.lblAn.TabIndex = 1;
            this.lblAn.Text = "Geef de achternaam:";
            // 
            // txtVn
            // 
            this.txtVn.Location = new System.Drawing.Point(239, 24);
            this.txtVn.Name = "txtVn";
            this.txtVn.Size = new System.Drawing.Size(208, 29);
            this.txtVn.TabIndex = 2;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(239, 66);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(208, 29);
            this.txtAn.TabIndex = 3;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(239, 122);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(208, 43);
            this.btnTerug.TabIndex = 9;
            this.btnTerug.Text = "Annuleren";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // btnToev
            // 
            this.btnToev.Location = new System.Drawing.Point(21, 122);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(208, 43);
            this.btnToev.TabIndex = 8;
            this.btnToev.Text = "Toevoegen";
            this.btnToev.UseVisualStyleBackColor = true;
            // 
            // FrmToevoegenWn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 190);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnToev);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtVn);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblVn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmToevoegenWn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voeg een werknemer toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVn;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.TextBox txtVn;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnToev;
    }
}