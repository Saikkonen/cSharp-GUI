namespace Matikkapeli
{
    partial class FormPisteTaulukko
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
            this.rtb_Pistetaulukko = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_Pistetaulukko
            // 
            this.rtb_Pistetaulukko.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Pistetaulukko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Pistetaulukko.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Pistetaulukko.Location = new System.Drawing.Point(0, 0);
            this.rtb_Pistetaulukko.Name = "rtb_Pistetaulukko";
            this.rtb_Pistetaulukko.ReadOnly = true;
            this.rtb_Pistetaulukko.Size = new System.Drawing.Size(422, 523);
            this.rtb_Pistetaulukko.TabIndex = 0;
            this.rtb_Pistetaulukko.Text = "";
            // 
            // FormPisteTaulukko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 523);
            this.Controls.Add(this.rtb_Pistetaulukko);
            this.Name = "FormPisteTaulukko";
            this.Text = "Pistetaulukko";
            this.Load += new System.EventHandler(this.FormPisteTaulukko_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Pistetaulukko;
    }
}