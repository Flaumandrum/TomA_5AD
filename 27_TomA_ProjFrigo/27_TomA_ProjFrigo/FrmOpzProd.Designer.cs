namespace _27_TomA_ProjFrigo
{
    partial class FrmOpzProd
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
            this.btnOpz = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnul
            // 
            this.btnAnnul.Location = new System.Drawing.Point(240, 89);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.Size = new System.Drawing.Size(201, 38);
            this.btnAnnul.TabIndex = 9;
            this.btnAnnul.Text = "Annuleren";
            this.btnAnnul.UseVisualStyleBackColor = true;
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnOpz
            // 
            this.btnOpz.Location = new System.Drawing.Point(20, 89);
            this.btnOpz.Name = "btnOpz";
            this.btnOpz.Size = new System.Drawing.Size(204, 38);
            this.btnOpz.TabIndex = 8;
            this.btnOpz.Text = "Opzoeken";
            this.btnOpz.UseVisualStyleBackColor = true;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(230, 33);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(211, 29);
            this.txtNaam.TabIndex = 11;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(50, 36);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(174, 24);
            this.lblNaam.TabIndex = 10;
            this.lblNaam.Text = "Naam van product: ";
            // 
            // FrmOpzProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 166);
            this.ControlBox = false;
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnAnnul);
            this.Controls.Add(this.btnOpz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmOpzProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product opzoeken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnul;
        private System.Windows.Forms.Button btnOpz;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblNaam;
    }
}