using System;
using System.IO;
using System.Windows.Forms;

namespace Seminarski
{
    public partial class StajanjaApp : Form
    {
        public int[] brzineucitano = new int[19864];
        public bool ucitano = false;

        public StajanjaApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //=================================================================================================\\

        private void tsm_ucitaj_Click(object sender, EventArgs e)
        {
            ucitajPodatke();
        }

        private void tsm_izracunBrojaStajanja_Click(object sender, EventArgs e)
        {
            brojStajanja();
        }

        private void tsm_brzineIznadOgranicenja_Click(object sender, EventArgs e)
        {
            brojBrzina();
        }
        
        private void tsm_dohvatPodataka_Click(object sender, EventArgs e)
        {
            ispisBrzina();
        }

        // Svaka od tekstualnih kutija poziva svoju metodu kada se pritisne Enter
        //============================================================================\\
        private void txt_brzinaogranicenja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                brojBrzina();
                e.Handled = true;
            }
        }

        private void txt_krajnjiIndeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ispisBrzina();
                e.Handled = true;
            }
        }

        private void txt_pocetniIndeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ispisBrzina();
                e.Handled = true;
            }
        }



        //=================================================================================================\\
             // Metode \\ // Metode \\ // Metode \\ // Metode \\ // Metode \\ // Metode \\ // Metode \\
        //=================================================================================================\\


        // Učitavanje podataka iz datoteke
        private void ucitajPodatke()
        {
            if (File.Exists("podaciD.txt"))
            {
                StreamReader ulaz = new StreamReader("podaciD.txt");
                int i = 0;

                try
                {
                    while (!ulaz.EndOfStream)
                    {
                        brzineucitano[i] = int.Parse(ulaz.ReadLine());
                        i++;
                    }
                    MessageBox.Show("Uspješno učitani podaci!");
                    ulaz.Close();
                    ucitano = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Neuspjelo učitavanje datoteke" + ex);
                }
            }
            else
            {
                string putanja = Directory.GetCurrentDirectory();
                MessageBox.Show("Datoteka podaciD.txt ne postoji u ovom direktoriju te nije učitana!");
                MessageBox.Show("Molimo Vas da je prebacite u direktorij gdje se nalazi izvršna datoteka: \n" + putanja);

            }
        }

        // Ispis broja stajanja
        private void brojStajanja()
        {
            if (ucitano == false)
            {
                MessageBox.Show("Niste učitali podatke!");
                return;
            }


            rtxt_brojStajanja.Clear();
            int pocetakIntervala = 0, krajIntervala = 0;
            int brojacstajanja = 0;

            rtxt_brojStajanja.AppendText("Ispis stajanja: \n");

            for (int i = 0; i < brzineucitano.Length; i++)
            {
                if (brzineucitano[i] == 0)
                {
                    if (i > 0 && brzineucitano[i - 1] != 0)
                    {
                        pocetakIntervala = i;

                        if ((i < brzineucitano.Length - 1 && brzineucitano[i + 1] != 0) || i == brzineucitano.Length)
                        {
                            krajIntervala = i;
                            brojacstajanja++;
                            rtxt_brojStajanja.AppendText($"{brojacstajanja}:{pocetakIntervala}-{krajIntervala} \n");
                        }
                    }
                    else if ((i < brzineucitano.Length - 1 && brzineucitano[i + 1] != 0) || i == brzineucitano.Length)
                    {
                        krajIntervala = i;
                        brojacstajanja++;
                        rtxt_brojStajanja.AppendText($"{brojacstajanja}:{pocetakIntervala}-{krajIntervala} \n");
                    }
                }
            }

            xlbl_brojStajanja.Text = $"{brojacstajanja}";
        }

        // Ispis broja brzina iznad upisanog ograničenja
        private void brojBrzina()
        {
            if (ucitano == false)
            {
                MessageBox.Show("Niste učitali podatke!");
                return;
            }


            try
            {
                int donjaGranica = int.Parse(txt_brzinaogranicenja.Text);
                int brojac = 0;

                for (int i = 0; i < brzineucitano.Length; i++)
                {
                    if (brzineucitano[i] > donjaGranica)
                    {
                        brojac++;
                    }
                }
                xlbl_brojBrzina.Text = $"{brojac}";
            }
            catch
            {
                xlbl_brojBrzina.Text = "-";
                MessageBox.Show("Prozor je ostao prazan ili je krivi format!");
            }
        }

        // Ispis brzina između unesenih indeksa
        private void ispisBrzina()
        {
            if (ucitano == false)
            {
                MessageBox.Show("Niste učitali podatke!");
                return;
            }


            int pocetniIndeks, krajnjiIndeks;

            if (!string.IsNullOrEmpty(txt_krajnjiIndeks.Text) && !string.IsNullOrEmpty(txt_pocetniIndeks.Text))
            {
                try
                {
                    pocetniIndeks = int.Parse(txt_pocetniIndeks.Text);
                    krajnjiIndeks = int.Parse(txt_krajnjiIndeks.Text);

                    if (pocetniIndeks < 0 || pocetniIndeks > brzineucitano.Length || krajnjiIndeks < 0 || krajnjiIndeks > brzineucitano.Length)
                    {
                        MessageBox.Show("Uneseni indeksi nisu u rasponu!");
                    }

                    else if (pocetniIndeks > krajnjiIndeks)
                    {
                        MessageBox.Show("Početni indeks ne moze biti veći od krajnjeg!");
                    }
                    else
                    {
                        rtxt_brzine.Clear();
                        for (int i = pocetniIndeks; i <= krajnjiIndeks; i++)
                        {
                            rtxt_brzine.AppendText($"{brzineucitano[i]} \n");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Krivi format!");
                }
            }
            else
            {
                MessageBox.Show("Barem jedna od granica nije upisana");
            }
        }
    }
}
