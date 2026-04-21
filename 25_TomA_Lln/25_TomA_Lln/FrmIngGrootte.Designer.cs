namespace _25_TomA_Lln
{
    partial class FrmIngGrootte
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
            this.lblGrootte = new System.Windows.Forms.Label();
            this.txtGrootte = new System.Windows.Forms.TextBox();
            this.btnIngeven = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGrootte
            // 
            this.lblGrootte.AutoSize = true;
            this.lblGrootte.Location = new System.Drawing.Point(50, 38);
            this.lblGrootte.Name = "lblGrootte";
            this.lblGrootte.Size = new System.Drawing.Size(189, 24);
            this.lblGrootte.TabIndex = 0;
            this.lblGrootte.Text = "Hoe groot is uw klas?";
            // 
            // txtGrootte
            // 
            this.txtGrootte.Location = new System.Drawing.Point(54, 84);
            this.txtGrootte.Name = "txtGrootte";
            this.txtGrootte.Size = new System.Drawing.Size(185, 29);
            this.txtGrootte.TabIndex = 1;
            // 
            // btnIngeven
            // 
            this.btnIngeven.Location = new System.Drawing.Point(54, 141);
            this.btnIngeven.Name = "btnIngeven";
            this.btnIngeven.Size = new System.Drawing.Size(185, 43);
            this.btnIngeven.TabIndex = 2;
            this.btnIngeven.Text = "Ingeven";
            this.btnIngeven.UseVisualStyleBackColor = true;
            this.btnIngeven.Click += new System.EventHandler(this.btnIngeven_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(54, 190);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(185, 43);
            this.btnAnnuleren.TabIndex = 3;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // FrmIngGrootte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 279);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnIngeven);
            this.Controls.Add(this.txtGrootte);
            this.Controls.Add(this.lblGrootte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmIngGrootte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aanmaken klas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrootte;
        private System.Windows.Forms.TextBox txtGrootte;
        private System.Windows.Forms.Button btnIngeven;
        private System.Windows.Forms.Button btnAnnuleren;
    }
}