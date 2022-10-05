using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class FormKertolasku : Form
    {
        public FormKertolasku()
        {
            InitializeComponent();
        }

        private int luku1;
        private int luku2;
        private int pisteet = 0;
        private int kierrokset = 0;

        private void LuoRandomLuvut()
        {
            var random = new Random();

            luku1 = random.Next(0, 10);
            luku2 = random.Next(0, 10);

            Luku1.Text = luku1.ToString();
            Luku2.Text = luku2.ToString();
        }

        public int PalautaPisteet
        {
            get { return pisteet; }
        }
        private void FormKertolasku_Load(object sender, EventArgs e)
        {
            LuoRandomLuvut();
        }

        private void Btn_Tarkista_Click(object sender, EventArgs e)
        {
            int vastaus = luku1 * luku2;

            bool success = int.TryParse(tb_Vastaus.Text, out int vastaus2);
            if (success == false)
            {
                MessageBox.Show("Vastauksen pitää olla kokonaisluku!", "Huom!");
            }
            else
            {
                kierrokset++;

                if (vastaus == vastaus2)
                {
                    pisteet++;
                }
                lb_Kierrokset.Text = kierrokset.ToString();
                LuoRandomLuvut();

                if (kierrokset == 10)
                {
                    MessageBox.Show(String.Format("Peli loppui. Sait {0}/10 oikein.", pisteet.ToString()));
                    Close();
                }
            }
        }
    }
}
