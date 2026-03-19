namespace _24_TomA_FormsStart
{
    partial class StartForm
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
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.lblHallo = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnHallo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(55, 194);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(125, 58);
            this.btnAfsluiten.TabIndex = 0;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // lblHallo
            // 
            this.lblHallo.AutoSize = true;
            this.lblHallo.Location = new System.Drawing.Point(51, 21);
            this.lblHallo.Name = "lblHallo";
            this.lblHallo.Size = new System.Drawing.Size(137, 24);
            this.lblHallo.TabIndex = 1;
            this.lblHallo.Text = "Geef uw naam:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(55, 59);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(125, 29);
            this.txtNaam.TabIndex = 2;
            // 
            // btnHallo
            // 
            this.btnHallo.Location = new System.Drawing.Point(55, 125);
            this.btnHallo.Name = "btnHallo";
            this.btnHallo.Size = new System.Drawing.Size(125, 58);
            this.btnHallo.TabIndex = 3;
            this.btnHallo.Text = "Zeg Hallo";
            this.btnHallo.UseVisualStyleBackColor = true;
            this.btnHallo.Click += new System.EventHandler(this.btnHallo_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(244, 264);
            this.ControlBox = false;
            this.Controls.Add(this.btnHallo);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblHallo);
            this.Controls.Add(this.btnAfsluiten);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welkom!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Label lblHallo;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnHallo;
    }
}

