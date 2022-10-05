namespace Miinaharava
{
    partial class MiinaharavaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiinaharavaForm));
            this.PelialuePaneeli = new System.Windows.Forms.Panel();
            this.lb_Liput = new System.Windows.Forms.Label();
            this.lippu = new System.Windows.Forms.PictureBox();
            this.vaikeustasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helppoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keskitasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaikeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lb_ohjeet = new System.Windows.Forms.Label();
            this.PelialuePaneeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lippu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PelialuePaneeli
            // 
            this.PelialuePaneeli.Controls.Add(this.lb_ohjeet);
            this.PelialuePaneeli.Cursor = System.Windows.Forms.Cursors.Default;
            this.PelialuePaneeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PelialuePaneeli.Location = new System.Drawing.Point(0, 30);
            this.PelialuePaneeli.Name = "PelialuePaneeli";
            this.PelialuePaneeli.Size = new System.Drawing.Size(486, 253);
            this.PelialuePaneeli.TabIndex = 0;
            // 
            // lb_Liput
            // 
            this.lb_Liput.BackColor = System.Drawing.Color.Transparent;
            this.lb_Liput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Liput.Location = new System.Drawing.Point(150, 0);
            this.lb_Liput.Name = "lb_Liput";
            this.lb_Liput.Size = new System.Drawing.Size(32, 28);
            this.lb_Liput.TabIndex = 2;
            this.lb_Liput.Text = "10";
            this.lb_Liput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lippu
            // 
            this.lippu.Image = global::Miinaharava.Properties.Resources.lippu;
            this.lippu.Location = new System.Drawing.Point(116, 0);
            this.lippu.Name = "lippu";
            this.lippu.Size = new System.Drawing.Size(28, 28);
            this.lippu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lippu.TabIndex = 8;
            this.lippu.TabStop = false;
            // 
            // vaikeustasoToolStripMenuItem
            // 
            this.vaikeustasoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helppoToolStripMenuItem,
            this.keskitasoToolStripMenuItem,
            this.vaikeaToolStripMenuItem});
            this.vaikeustasoToolStripMenuItem.Name = "vaikeustasoToolStripMenuItem";
            this.vaikeustasoToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.vaikeustasoToolStripMenuItem.Text = "Vaikeustaso";
            // 
            // helppoToolStripMenuItem
            // 
            this.helppoToolStripMenuItem.Name = "helppoToolStripMenuItem";
            this.helppoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.helppoToolStripMenuItem.Text = "Helppo";
            this.helppoToolStripMenuItem.Click += new System.EventHandler(this.Helppo_Click);
            // 
            // keskitasoToolStripMenuItem
            // 
            this.keskitasoToolStripMenuItem.Name = "keskitasoToolStripMenuItem";
            this.keskitasoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.keskitasoToolStripMenuItem.Text = "Keskitaso";
            this.keskitasoToolStripMenuItem.Click += new System.EventHandler(this.Keskitaso_Click);
            // 
            // vaikeaToolStripMenuItem
            // 
            this.vaikeaToolStripMenuItem.Name = "vaikeaToolStripMenuItem";
            this.vaikeaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.vaikeaToolStripMenuItem.Text = "Vaikea";
            this.vaikeaToolStripMenuItem.Click += new System.EventHandler(this.Vaikea_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaikeustasoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lb_ohjeet
            // 
            this.lb_ohjeet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ohjeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ohjeet.Location = new System.Drawing.Point(0, 87);
            this.lb_ohjeet.Name = "lb_ohjeet";
            this.lb_ohjeet.Size = new System.Drawing.Size(486, 23);
            this.lb_ohjeet.TabIndex = 0;
            this.lb_ohjeet.Text = "Valitse vaikeustaso aloittaaksesi pelin";
            this.lb_ohjeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MiinaharavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 283);
            this.Controls.Add(this.lippu);
            this.Controls.Add(this.lb_Liput);
            this.Controls.Add(this.PelialuePaneeli);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MiinaharavaForm";
            this.Text = "Miinaharava";
            this.PelialuePaneeli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lippu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PelialuePaneeli;
        private System.Windows.Forms.Label lb_Liput;
        private System.Windows.Forms.PictureBox lippu;
        private System.Windows.Forms.ToolStripMenuItem vaikeustasoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helppoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keskitasoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaikeaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lb_ohjeet;
    }
}

