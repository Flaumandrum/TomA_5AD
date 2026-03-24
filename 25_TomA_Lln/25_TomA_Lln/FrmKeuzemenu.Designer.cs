namespace _25_TomA_Lln
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
            this.btnGrootte = new System.Windows.Forms.Button();
            this.btnToev = new System.Windows.Forms.Button();
            this.btnToon = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGrootte
            // 
            this.btnGrootte.Location = new System.Drawing.Point(28, 26);
            this.btnGrootte.Name = "btnGrootte";
            this.btnGrootte.Size = new System.Drawing.Size(301, 41);
            this.btnGrootte.TabIndex = 0;
            this.btnGrootte.Text = "Pas de grootte van de klas aan";
            this.btnGrootte.UseVisualStyleBackColor = true;
            // 
            // btnToev
            // 
            this.btnToev.Location = new System.Drawing.Point(28, 73);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(301, 41);
            this.btnToev.TabIndex = 1;
            this.btnToev.Text = "Voeg leerlingen toe";
            this.btnToev.UseVisualStyleBackColor = true;
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(28, 120);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(301, 41);
            this.btnToon.TabIndex = 2;
            this.btnToon.Text = "Toon de leerlingen";
            this.btnToon.UseVisualStyleBackColor = true;
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(28, 167);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(301, 41);
            this.btnAfsluiten.TabIndex = 3;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // FrmKeuzemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 231);
            this.ControlBox = false;
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.btnToev);
            this.Controls.Add(this.btnGrootte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmKeuzemenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welkom!";
            this.Load += new System.EventHandler(this.FrmKeuzemenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrootte;
        private System.Windows.Forms.Button btnToev;
        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}

