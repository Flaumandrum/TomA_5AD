namespace _27_TomA_ProjFrigo
{
    partial class FrmToonVervProd
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
            this.lblToon = new System.Windows.Forms.Label();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.btnAnnul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblToon
            // 
            this.lblToon.AutoSize = true;
            this.lblToon.Location = new System.Drawing.Point(52, 28);
            this.lblToon.Name = "lblToon";
            this.lblToon.Size = new System.Drawing.Size(286, 24);
            this.lblToon.TabIndex = 0;
            this.lblToon.Text = "Hier zijn de vervallen producten: ";
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtToon.Location = new System.Drawing.Point(30, 66);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToon.Size = new System.Drawing.Size(340, 237);
            this.txtToon.TabIndex = 1;
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(88, 328);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(201, 38);
            this.btnAnnul.TabIndex = 8;
            this.btnAnnul.Text = "Terug";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // FrmToonVervProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 395);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnul);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.lblToon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmToonVervProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vervallen producten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToon;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Button btnAnnul;
    }
}