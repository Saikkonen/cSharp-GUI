namespace Matikkapeli
{
    partial class FormVähennyslasku
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
            this.Scoreboard = new System.Windows.Forms.Label();
            this.lb_Kierrokset = new System.Windows.Forms.Label();
            this.btn_Tarkista = new System.Windows.Forms.Button();
            this.Luku2 = new System.Windows.Forms.Label();
            this.PlusMerkki = new System.Windows.Forms.Label();
            this.OnyhtäkuinMerkki = new System.Windows.Forms.Label();
            this.tb_Vastaus = new System.Windows.Forms.TextBox();
            this.Luku1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Scoreboard
            // 
            this.Scoreboard.AutoSize = true;
            this.Scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreboard.Location = new System.Drawing.Point(657, 302);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(32, 20);
            this.Scoreboard.TabIndex = 15;
            this.Scoreboard.Text = "/10";
            // 
            // lb_Kierrokset
            // 
            this.lb_Kierrokset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Kierrokset.Location = new System.Drawing.Point(630, 302);
            this.lb_Kierrokset.Name = "lb_Kierrokset";
            this.lb_Kierrokset.Size = new System.Drawing.Size(32, 20);
            this.lb_Kierrokset.TabIndex = 14;
            this.lb_Kierrokset.Text = "0";
            this.lb_Kierrokset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Tarkista
            // 
            this.btn_Tarkista.Location = new System.Drawing.Point(428, 237);
            this.btn_Tarkista.Name = "btn_Tarkista";
            this.btn_Tarkista.Size = new System.Drawing.Size(100, 30);
            this.btn_Tarkista.TabIndex = 13;
            this.btn_Tarkista.Text = "Tarkista";
            this.btn_Tarkista.UseVisualStyleBackColor = true;
            this.btn_Tarkista.Click += new System.EventHandler(this.Btn_Tarkista_Click);
            // 
            // Luku2
            // 
            this.Luku2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku2.Location = new System.Drawing.Point(346, 196);
            this.Luku2.Name = "Luku2";
            this.Luku2.Size = new System.Drawing.Size(40, 40);
            this.Luku2.TabIndex = 12;
            this.Luku2.Text = "16";
            this.Luku2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusMerkki
            // 
            this.PlusMerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusMerkki.Location = new System.Drawing.Point(310, 196);
            this.PlusMerkki.Name = "PlusMerkki";
            this.PlusMerkki.Size = new System.Drawing.Size(30, 40);
            this.PlusMerkki.TabIndex = 11;
            this.PlusMerkki.Text = "-";
            this.PlusMerkki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OnyhtäkuinMerkki
            // 
            this.OnyhtäkuinMerkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnyhtäkuinMerkki.Location = new System.Drawing.Point(392, 196);
            this.OnyhtäkuinMerkki.Name = "OnyhtäkuinMerkki";
            this.OnyhtäkuinMerkki.Size = new System.Drawing.Size(30, 40);
            this.OnyhtäkuinMerkki.TabIndex = 10;
            this.OnyhtäkuinMerkki.Text = "=";
            this.OnyhtäkuinMerkki.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Vastaus
            // 
            this.tb_Vastaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Vastaus.Location = new System.Drawing.Point(428, 201);
            this.tb_Vastaus.Name = "tb_Vastaus";
            this.tb_Vastaus.Size = new System.Drawing.Size(100, 30);
            this.tb_Vastaus.TabIndex = 9;
            // 
            // Luku1
            // 
            this.Luku1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luku1.Location = new System.Drawing.Point(264, 196);
            this.Luku1.Name = "Luku1";
            this.Luku1.Size = new System.Drawing.Size(40, 40);
            this.Luku1.TabIndex = 8;
            this.Luku1.Text = "23";
            this.Luku1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVähennyslasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Scoreboard);
            this.Controls.Add(this.lb_Kierrokset);
            this.Controls.Add(this.btn_Tarkista);
            this.Controls.Add(this.Luku2);
            this.Controls.Add(this.PlusMerkki);
            this.Controls.Add(this.OnyhtäkuinMerkki);
            this.Controls.Add(this.tb_Vastaus);
            this.Controls.Add(this.Luku1);
            this.Name = "FormVähennyslasku";
            this.Text = "Vähennyslasku";
            this.Load += new System.EventHandler(this.FormVähennyslasku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Scoreboard;
        private System.Windows.Forms.Label lb_Kierrokset;
        private System.Windows.Forms.Button btn_Tarkista;
        private System.Windows.Forms.Label Luku2;
        private System.Windows.Forms.Label PlusMerkki;
        private System.Windows.Forms.Label OnyhtäkuinMerkki;
        private System.Windows.Forms.TextBox tb_Vastaus;
        private System.Windows.Forms.Label Luku1;
    }
}