using System;
using System.Drawing;
using System.Windows.Forms;

namespace Miinaharava
{
    public partial class MiinaharavaForm : Form
    {
        public MiinaharavaForm()
        {
            InitializeComponent();
        }
        
        public void Luonappi(int PelialueX, int PelialueY, int MiinojenMaara)
        {
            
            Nappi[,] napit = new Nappi[PelialueX, PelialueY];

            PelialuePaneeli.Controls.Clear(); // tyhjentää kentän että napit ei mene edellisten päälle

            lb_Liput.Text = MiinojenMaara.ToString();

            for (int x = 0; x < PelialueX; x++)
            {
                for (int y = 0; y < PelialueY; y++)
                {
                    napit[x, y] = new Nappi(x, y);

                    PelialuePaneeli.Controls.Add(napit[x, y]);

                }
            }
            HaeNapeilleNaapurit(napit);
            ArvoMiinat(PelialueX, PelialueY, MiinojenMaara, napit);
        }

        private void HaeNapeilleNaapurit(Nappi[,] buttons)
        {
            foreach(Nappi but in buttons)
            {
                but.LisaaViereisetNapit(buttons);
            }
        }
        private static void ArvoMiinat(int PelialueX, int PelialueY, int MiinojenMaara, Nappi[,] napit)
        {
            var rand = new Random();
            for (int i = 0; i < MiinojenMaara; i++)
            {
                int luku1 = rand.Next(0, PelialueX);
                int luku2 = rand.Next(0, PelialueY);

                if(!napit[luku1, luku2].AsetaMiina())
                {
                    i--;
                }
            }
        }

        private void Helppo_Click(object sender, EventArgs e)
        {
            ClientSize = new Size(360, 384);
            Luonappi(9, 9, 10);
        }

        private void Keskitaso_Click(object sender, EventArgs e)
        {
            ClientSize = new Size(640, 664);
            Location = new Point(400, 80);
            Luonappi(16, 16, 40);
        }

        private void Vaikea_Click(object sender, EventArgs e)
        {
            ClientSize = new Size(1200, 664);
            Location = new Point(170, 80);
            Luonappi(30, 16, 99);
        }
    }
}