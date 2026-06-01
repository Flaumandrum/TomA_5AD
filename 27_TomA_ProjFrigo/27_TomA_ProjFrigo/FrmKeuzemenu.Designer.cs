namespace _27_TomA_ProjFrigo
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
            this.btnToev = new System.Windows.Forms.Button();
            this.btnToon = new System.Windows.Forms.Button();
            this.btnToonVerv = new System.Windows.Forms.Button();
            this.btnOpzoek = new System.Windows.Forms.Button();
            this.btnaanpas = new System.Windows.Forms.Button();
            this.btnVerw = new System.Windows.Forms.Button();
            this.btnAfsl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToev
            // 
            this.btnToev.Location = new System.Drawing.Point(27, 12);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(265, 49);
            this.btnToev.TabIndex = 0;
            this.btnToev.Text = "Product toevoegen";
            this.btnToev.UseVisualStyleBackColor = true;
            this.btnToev.Click += new System.EventHandler(this.btnToev_Click);
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(27, 67);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(265, 49);
            this.btnToon.TabIndex = 1;
            this.btnToon.Text = "Producten tonen";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // btnToonVerv
            // 
            this.btnToonVerv.Location = new System.Drawing.Point(27, 122);
            this.btnToonVerv.Name = "btnToonVerv";
            this.btnToonVerv.Size = new System.Drawing.Size(265, 49);
            this.btnToonVerv.TabIndex = 2;
            this.btnToonVerv.Text = "Toon vervallen producten";
            this.btnToonVerv.UseVisualStyleBackColor = true;
            this.btnToonVerv.Click += new System.EventHandler(this.btnToonVerv_Click);
            // 
            // btnOpzoek
            // 
            this.btnOpzoek.Location = new System.Drawing.Point(27, 177);
            this.btnOpzoek.Name = "btnOpzoek";
            this.btnOpzoek.Size = new System.Drawing.Size(265, 49);
            this.btnOpzoek.TabIndex = 3;
            this.btnOpzoek.Text = "Product opzoeken";
            this.btnOpzoek.UseVisualStyleBackColor = true;
            this.btnOpzoek.Click += new System.EventHandler(this.btnOpzoek_Click);
            // 
            // btnaanpas
            // 
            this.btnaanpas.Location = new System.Drawing.Point(27, 232);
            this.btnaanpas.Name = "btnaanpas";
            this.btnaanpas.Size = new System.Drawing.Size(265, 49);
            this.btnaanpas.TabIndex = 4;
            this.btnaanpas.Text = "Product aanpassen";
            this.btnaanpas.UseVisualStyleBackColor = true;
            this.btnaanpas.Click += new System.EventHandler(this.btnaanpas_Click);
            // 
            // btnVerw
            // 
            this.btnVerw.Location = new System.Drawing.Point(27, 287);
            this.btnVerw.Name = "btnVerw";
            this.btnVerw.Size = new System.Drawing.Size(265, 49);
            this.btnVerw.TabIndex = 5;
            this.btnVerw.Text = "Product verwijderen";
            this.btnVerw.UseVisualStyleBackColor = true;
            this.btnVerw.Click += new System.EventHandler(this.btnVerw_Click);
            // 
            // btnAfsl
            // 
            this.btnAfsl.Location = new System.Drawing.Point(27, 342);
            this.btnAfsl.Name = "btnAfsl";
            this.btnAfsl.Size = new System.Drawing.Size(265, 49);
            this.btnAfsl.TabIndex = 6;
            this.btnAfsl.Text = "Afsltuiten";
            this.btnAfsl.UseVisualStyleBackColor = true;
            this.btnAfsl.Click += new System.EventHandler(this.btnAfsl_Click);
            // 
            // FrmKeuzemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 419);
            this.ControlBox = false;
            this.Controls.Add(this.btnAfsl);
            this.Controls.Add(this.btnVerw);
            this.Controls.Add(this.btnaanpas);
            this.Controls.Add(this.btnOpzoek);
            this.Controls.Add(this.btnToonVerv);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.btnToev);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmKeuzemenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keuzemenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToev;
        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.Button btnToonVerv;
        private System.Windows.Forms.Button btnOpzoek;
        private System.Windows.Forms.Button btnaanpas;
        private System.Windows.Forms.Button btnVerw;
        private System.Windows.Forms.Button btnAfsl;
    }
}

