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

		#region Događaji (Events)

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
		#endregion

		#region Metode

		// Učitavanje podataka iz datoteke
		private void ucitajPodatke()
		{
			if (!File.Exists("podaciD.txt"))
			{
				string putanja = Directory.GetCurrentDirectory();
				MessageBox.Show("Datoteka podaciD.txt ne postoji u ovom direktoriju te nije učitana!");
				MessageBox.Show("Molimo Vas da je prebacite u direktorij gdje se nalazi izvršna datoteka: \n" + putanja);
				return;
			}

			try
			{
				StreamReader ulaz = new StreamReader("podaciD.txt");
				for (int i = 0; !ulaz.EndOfStream; i++)
				{
					brzineucitano[i] = int.Parse(ulaz.ReadLine());
				}
				MessageBox.Show("Uspješno učitani podaci!");
				ucitano = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Neuspjelo učitavanje datoteke" + ex);
			}
		}

		// Ispis broja stajanja
		private void brojStajanja()
		{
			if (!ucitano)
			{
				MessageBox.Show("Niste učitali podatke!");
				return;
			}

			rtxt_brojStajanja.Clear();
			int pocetakIntervala = 0, krajIntervala = 0, brojacstajanja = 0;
			rtxt_brojStajanja.AppendText("Ispis stajanja: \n");

			for (int i = 0; i < brzineucitano.Length; i++)
			{
				if (brzineucitano[i] != 0)
				{
					continue;
				}

				if (pocetakIntervala == 0)
				{
					pocetakIntervala = i;
				}

				if (i == brzineucitano.Length - 1 || brzineucitano[i + 1] != 0)
				{
					krajIntervala = i;
					brojacstajanja++;

					rtxt_brojStajanja.AppendText($"{brojacstajanja}:{pocetakIntervala}-{krajIntervala} \n");
					pocetakIntervala = 0;
				}
			}

			xlbl_brojStajanja.Text = $"{brojacstajanja}";
		}

		// Ispis broja brzina iznad upisanog ograničenja
		private void brojBrzina()
		{
			if (!ucitano)
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
			if (!ucitano)
			{
				MessageBox.Show("Niste učitali podatke!");
				return;
			}

			int pocetniIndeks, krajnjiIndeks;

			if (string.IsNullOrEmpty(txt_krajnjiIndeks.Text) && string.IsNullOrEmpty(txt_pocetniIndeks.Text))
			{
				MessageBox.Show("Barem jedna od granica nije upisana");
			}

			try
			{
				pocetniIndeks = int.Parse(txt_pocetniIndeks.Text);
				krajnjiIndeks = int.Parse(txt_krajnjiIndeks.Text);

				if (pocetniIndeks < 0 || pocetniIndeks > brzineucitano.Length || krajnjiIndeks < 0 || krajnjiIndeks > brzineucitano.Length)
				{
					MessageBox.Show("Uneseni indeksi nisu u rasponu!");
					return;
				}

				if (pocetniIndeks > krajnjiIndeks)
				{
					MessageBox.Show("Početni indeks ne moze biti veći od krajnjeg!");
					return;
				}

				rtxt_brzine.Clear();
				for (int i = pocetniIndeks; i <= krajnjiIndeks; i++)
				{
					rtxt_brzine.AppendText($"{brzineucitano[i]} \n");
				}
			}
			catch
			{
				MessageBox.Show("Krivi format!");
			}

		}
		#endregion
	}
}
