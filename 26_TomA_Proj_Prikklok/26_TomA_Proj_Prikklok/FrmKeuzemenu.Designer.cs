namespace _26_TomA_Proj_Prikklok
{
    partial class FrmKeuzemenu
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
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnWn = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(23, 28);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(334, 24);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Maak uw keuze uit onderstaand menu:";
            // 
            // btnWn
            // 
            this.btnWn.Location = new System.Drawing.Point(27, 93);
            this.btnWn.Name = "btnWn";
            this.btnWn.Size = new System.Drawing.Size(330, 39);
            this.btnWn.TabIndex = 1;
            this.btnWn.Text = "Registreren werknemer";
            this.btnWn.UseVisualStyleBackColor = true;
            // 
            // btnAdm
            // 
            this.btnAdm.Location = new System.Drawing.Point(27, 138);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(330, 39);
            this.btnAdm.TabIndex = 2;
            this.btnAdm.Text = "Inloggen als Admin";
            this.btnAdm.UseVisualStyleBackColor = true;
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(27, 183);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(330, 39);
            this.btnAfsluiten.TabIndex = 3;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            // 
            // FrmKeuzemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 255);
            this.ControlBox = false;
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.btnWn);
            this.Controls.Add(this.lblIntro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmKeuzemenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keuzemenu:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnWn;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}

