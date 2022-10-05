using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matikkapeli
{
    public partial class PääFormi : Form
    {
        public PääFormi()
        {
            InitializeComponent();
        }

        private void TarkistaKäyttäjäTunnus()
        {
            if (tb_käyttäjätunnus.Text.Length == 0)
            {
                MessageBox.Show("Jos pelaat ilman käyttäjätunnusta, pisteitäsi ei voida tallentaa", "Huom!");
            }
        }

        private void TallennaTiedosto(int x)
        {
            if (tb_käyttäjätunnus.Text.Length > 0)
            {
                File.AppendAllText("Pistetaulukko.txt", tb_käyttäjätunnus.Text + ": " + x.ToString() + "\n");
            }
        }
        
        private void Btn_YhteenLasku_Click(object sender, EventArgs e)
        {
            TarkistaKäyttäjäTunnus();

            using (var yhteenlasku = new FormYhteenlasku())
            {
                yhteenlasku.ShowDialog();
                int pisteet = yhteenlasku.PalautaPisteet;

                TallennaTiedosto(pisteet);
            }
        }

        private void Btn_VähennysLasku_Click(object sender, EventArgs e)
        {
            TarkistaKäyttäjäTunnus();
            using (var vähennyslasku = new FormVähennyslasku())
            {
                vähennyslasku.ShowDialog();
                int pisteet = vähennyslasku.PalautaPisteet;

                TallennaTiedosto(pisteet);
            }
        }

        private void Btn_KertoLasku_Click(object sender, EventArgs e)
        {
            TarkistaKäyttäjäTunnus();
            using (var kertolasku = new FormKertolasku())
            {
                kertolasku.ShowDialog();
                int pisteet = kertolasku.PalautaPisteet;

                TallennaTiedosto(pisteet);
            }
        }

        private void Btn_JakoLasku_Click(object sender, EventArgs e)
        {
            TarkistaKäyttäjäTunnus();
            using (var jakolasku = new FormJakolasku())
            {
                jakolasku.ShowDialog();
                int pisteet = jakolasku.PalautaPisteet;

                TallennaTiedosto(pisteet);
            }
        }

        private void Btn_PisteTaulukko_Click(object sender, EventArgs e)
        {
            FormPisteTaulukko pistetaulukko = new FormPisteTaulukko();
            pistetaulukko.Show();
        }
    }
}
