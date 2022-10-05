using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Miinaharava
{
    internal class Nappi : Button
    {
        bool onkoMiina = false;
        bool onkoLippu = false;
        int _x, _y;
        int viereisetMiinat;
        List<Nappi> _vieresetNapit;
        bool _avattu;
        bool _tarkistettu;

        public int ViereisetMiinat { get => viereisetMiinat; set => viereisetMiinat = value; }
        public bool Avattu { get => _avattu; }
        public bool Tarkistettu { get => _tarkistettu; }

        public Nappi(int x, int y) : base()
        {
            _avattu = false;
            _tarkistettu = false;
            _vieresetNapit = new List<Nappi>();
            ViereisetMiinat = 0;
            _x = x;
            _y = y;
            MouseDown += new MouseEventHandler(Miina_Click);
            Size = new Size(40, 40);
            Location = new Point(x * 40, y * 40);
            BackColor = ColorTranslator.FromHtml("#8bf51b");
            FlatStyle = FlatStyle.Flat;
        }

        void Miina_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!Avattu)
                {
                    if (!onkoLippu)
                    {
                        this.BackgroundImage = Properties.Resources.lippu;
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                        this.onkoLippu = true;
                    }
                    else
                    {
                        this.BackgroundImage = null;
                        this.onkoLippu = false;
                    }
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                Aukea();
            }
        }

        public void LisaaViereisetNapit(Nappi[,] napit)
        {
            LisaaYlaRivi(napit, _y - 1);
            LisaaAlaRivi(napit, _y + 1);
            LisaaSamaRivi(napit);
        }

        void LisaaYlaRivi(Nappi[,] napit, int rivi)
        {
            
            if (_y > 0)
            {
                for (int sarake = _x - 1; sarake <= _x + 1; sarake++)
                {
                    if (sarake >= 0 && sarake <= napit.GetUpperBound(0))
                    {
                        _vieresetNapit.Add(napit[sarake, rivi]);
                    }                
                }
            }
        }

        void LisaaSamaRivi(Nappi[,] napit)
        {
            if (_x > 0)
            {
                _vieresetNapit.Add(napit[_x - 1, _y]);
            }
            if(_x< napit.GetUpperBound(0))
                _vieresetNapit.Add(napit[_x + 1, _y]);
        }

        void LisaaAlaRivi(Nappi[,] napit, int rivi)
        {
            if (_y < napit.GetUpperBound(1))
            {
                for (int sarake = _x - 1; sarake <= _x + 1; sarake++)
                {
                    if (sarake >= 0 && sarake <= napit.GetUpperBound(0))
                        _vieresetNapit.Add(napit[sarake, rivi]);
                }
            }
        }

        public bool AsetaMiina()
        {
            if (onkoMiina)
            {
                return false;
            }
            else
            {
                onkoMiina = true;
                foreach(Nappi but in _vieresetNapit)
                {
                    but.ViereisetMiinat++;
                }
                return true;
            }
        }

        public bool Aukea()
        {
            if (!Avattu)
            {
                _avattu = true;
                if (onkoMiina)
                {
                    NaytaKaikkiMiinat();
                    MessageBox.Show("Hävisit pelin!");
                    return false;
                }
                else
                {
                    this.BackColor = ColorTranslator.FromHtml("#8fffa9");
                    if (viereisetMiinat == 0)
                    {
                        foreach (Nappi but in _vieresetNapit)
                        {
                            but.Aukea();
                        }
                    }
                    else
                    {
                        Text = ViereisetMiinat.ToString();
                    }
                }
                return true;
            }
            return true;
        }

        public void NaytaKaikkiMiinat()
        {
            if (!Tarkistettu)
            {
                _tarkistettu = true;
                if (onkoMiina)
                {
                    this.BackgroundImage = Properties.Resources.miina;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    this.BackColor = Color.Red;
                }
                foreach (Nappi but in _vieresetNapit)
                {
                    but.NaytaKaikkiMiinat();
                }
            }
        }
    }
}