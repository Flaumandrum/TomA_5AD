namespace _26_TomA_Proj_Prikklok
{
    partial class FrmKeuzeAdm
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
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnTonen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(27, 175);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(330, 39);
            this.btnVerwijderen.TabIndex = 7;
            this.btnVerwijderen.Text = "Verwijderen werknemer";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(27, 130);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(330, 39);
            this.btnAanpassen.TabIndex = 6;
            this.btnAanpassen.Text = "Aanpassen werknemer";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(27, 85);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(330, 39);
            this.btnToevoegen.TabIndex = 5;
            this.btnToevoegen.Text = "Toevoegen werknemer";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(23, 20);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(334, 24);
            this.lblIntro.TabIndex = 4;
            this.lblIntro.Text = "Maak uw keuze uit onderstaand menu:";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(27, 265);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(330, 39);
            this.btnTerug.TabIndex = 11;
            this.btnTerug.Text = "Annuleren";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnTonen
            // 
            this.btnTonen.Location = new System.Drawing.Point(27, 220);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(330, 39);
            this.btnTonen.TabIndex = 10;
            this.btnTonen.Text = "Toon codes";
            this.btnTonen.UseVisualStyleBackColor = true;
            this.btnTonen.Click += new System.EventHandler(this.btnTonen_Click);
            // 
            // FrmKeuzeAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 332);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnTonen);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblIntro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmKeuzeAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnTonen;
    }
}