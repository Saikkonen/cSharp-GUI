namespace Matikkapeli
{
    partial class PääFormi
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
            this.InfoTeksti = new System.Windows.Forms.Label();
            this.btn_YhteenLasku = new System.Windows.Forms.Button();
            this.btn_VähennysLasku = new System.Windows.Forms.Button();
            this.btn_KertoLasku = new System.Windows.Forms.Button();
            this.btn_JakoLasku = new System.Windows.Forms.Button();
            this.tb_käyttäjätunnus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PisteTaulukko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoTeksti
            // 
            this.InfoTeksti.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTeksti.Location = new System.Drawing.Point(76, 50);
            this.InfoTeksti.Name = "InfoTeksti";
            this.InfoTeksti.Size = new System.Drawing.Size(498, 52);
            this.InfoTeksti.TabIndex = 0;
            this.InfoTeksti.Text = "Tervetuloa matikkapeliin. Syötä käyttäjätunnus ja valitse peli alla olevista nape" +
    "ista.";
            this.InfoTeksti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_YhteenLasku
            // 
            this.btn_YhteenLasku.Location = new System.Drawing.Point(76, 166);
            this.btn_YhteenLasku.Name = "btn_YhteenLasku";
            this.btn_YhteenLasku.Size = new System.Drawing.Size(120, 35);
            this.btn_YhteenLasku.TabIndex = 1;
            this.btn_YhteenLasku.Text = "Yhteenlasku";
            this.btn_YhteenLasku.UseVisualStyleBackColor = true;
            this.btn_YhteenLasku.Click += new System.EventHandler(this.Btn_YhteenLasku_Click);
            // 
            // btn_VähennysLasku
            // 
            this.btn_VähennysLasku.Location = new System.Drawing.Point(202, 166);
            this.btn_VähennysLasku.Name = "btn_VähennysLasku";
            this.btn_VähennysLasku.Size = new System.Drawing.Size(120, 35);
            this.btn_VähennysLasku.TabIndex = 2;
            this.btn_VähennysLasku.Text = "Vähennyslasku";
            this.btn_VähennysLasku.UseVisualStyleBackColor = true;
            this.btn_VähennysLasku.Click += new System.EventHandler(this.Btn_VähennysLasku_Click);
            // 
            // btn_KertoLasku
            // 
            this.btn_KertoLasku.Location = new System.Drawing.Point(328, 166);
            this.btn_KertoLasku.Name = "btn_KertoLasku";
            this.btn_KertoLasku.Size = new System.Drawing.Size(120, 35);
            this.btn_KertoLasku.TabIndex = 3;
            this.btn_KertoLasku.Text = "Kertolasku";
            this.btn_KertoLasku.UseVisualStyleBackColor = true;
            this.btn_KertoLasku.Click += new System.EventHandler(this.Btn_KertoLasku_Click);
            // 
            // btn_JakoLasku
            // 
            this.btn_JakoLasku.Location = new System.Drawing.Point(454, 166);
            this.btn_JakoLasku.Name = "btn_JakoLasku";
            this.btn_JakoLasku.Size = new System.Drawing.Size(120, 35);
            this.btn_JakoLasku.TabIndex = 4;
            this.btn_JakoLasku.Text = "Jakolasku";
            this.btn_JakoLasku.UseVisualStyleBackColor = true;
            this.btn_JakoLasku.Click += new System.EventHandler(this.Btn_JakoLasku_Click);
            // 
            // tb_käyttäjätunnus
            // 
            this.tb_käyttäjätunnus.Location = new System.Drawing.Point(328, 116);
            this.tb_käyttäjätunnus.Name = "tb_käyttäjätunnus";
            this.tb_käyttäjätunnus.Size = new System.Drawing.Size(120, 22);
            this.tb_käyttäjätunnus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(199, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Käyttäjätunnus:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PisteTaulukko
            // 
            this.btn_PisteTaulukko.Location = new System.Drawing.Point(264, 207);
            this.btn_PisteTaulukko.Name = "btn_PisteTaulukko";
            this.btn_PisteTaulukko.Size = new System.Drawing.Size(120, 35);
            this.btn_PisteTaulukko.TabIndex = 7;
            this.btn_PisteTaulukko.Text = "Pistetaulukko";
            this.btn_PisteTaulukko.UseVisualStyleBackColor = true;
            this.btn_PisteTaulukko.Click += new System.EventHandler(this.Btn_PisteTaulukko_Click);
            // 
            // PääFormi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 325);
            this.Controls.Add(this.btn_PisteTaulukko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_käyttäjätunnus);
            this.Controls.Add(this.btn_JakoLasku);
            this.Controls.Add(this.btn_KertoLasku);
            this.Controls.Add(this.btn_VähennysLasku);
            this.Controls.Add(this.btn_YhteenLasku);
            this.Controls.Add(this.InfoTeksti);
            this.Name = "PääFormi";
            this.Text = "Matiikkapeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoTeksti;
        private System.Windows.Forms.Button btn_YhteenLasku;
        private System.Windows.Forms.Button btn_VähennysLasku;
        private System.Windows.Forms.Button btn_KertoLasku;
        private System.Windows.Forms.Button btn_JakoLasku;
        private System.Windows.Forms.TextBox tb_käyttäjätunnus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PisteTaulukko;
    }
}

