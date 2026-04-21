namespace _25_TomA_Lln
{
    partial class FrmIngLln
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnIngeven = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lbNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(16, 190);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(262, 43);
            this.btnAnnuleren.TabIndex = 7;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnIngeven
            // 
            this.btnIngeven.Location = new System.Drawing.Point(16, 141);
            this.btnIngeven.Name = "btnIngeven";
            this.btnIngeven.Size = new System.Drawing.Size(262, 43);
            this.btnIngeven.TabIndex = 6;
            this.btnIngeven.Text = "Ingeven";
            this.btnIngeven.UseVisualStyleBackColor = true;
            this.btnIngeven.Click += new System.EventHandler(this.btnIngeven_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(16, 84);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(262, 29);
            this.txtNaam.TabIndex = 5;
            // 
            // lbNaam
            // 
            this.lbNaam.AutoSize = true;
            this.lbNaam.Location = new System.Drawing.Point(12, 38);
            this.lbNaam.Name = "lbNaam";
            this.lbNaam.Size = new System.Drawing.Size(266, 24);
            this.lbNaam.TabIndex = 4;
            this.lbNaam.Text = "Geef de naam van uw leerling:";
            // 
            // FrmIngLln
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnIngeven);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lbNaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmIngLln";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toevoegen leerling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnIngeven;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lbNaam;
    }
}