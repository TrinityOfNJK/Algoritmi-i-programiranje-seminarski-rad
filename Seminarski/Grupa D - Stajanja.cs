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

		#region UI

		private void Form1_Load(object sender, EventArgs e)
		{

		}

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

		// Svaka od tekstualnih kutija poziva svoju metodu kada se pritisne Enter zbog lakšeg korištenja
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

		#region Logika

		//Učitavanje podataka iz datoteke
		private void ucitajPodatke()
		{
			//Ako datoteka ne postoji, ispiši poruku i prekini izvođenje metode
			if (!File.Exists("podaciD.txt"))
			{
				MessageBox.Show("Datoteka podaciD.txt ne postoji u ovom direktoriju te nije učitana!");
				MessageBox.Show("Molimo Vas da je prebacite u direktorij gdje se nalazi izvršna datoteka: \n" + Directory.GetCurrentDirectory());
				return;
			}

			try
			{
				//Stvaranje objekta za čitanje iz datoteke i učitavanje podataka u polje brzineucitano
				//Nakon toga se ispisuje poruka o uspješnom učitavanju i postavlja se varijabla ucitano na true
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

		//Ispis broja stajanja
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
				//Ako je brzina 0, preskoči
				if (brzineucitano[i] != 0)
				{
					continue;
				}

				//Ako je brzina 0, a prethodna brzina nije 0, znači da je to početak stajanja
				if (pocetakIntervala == 0)
				{
					pocetakIntervala = i;
				}

				//Ako je brzina 0, a sljedeća brzina nije 0, znači da je to kraj stajanja te se ispisuje interval i povećava brojač stajanja
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

		//Ispis broja brzina iznad upisanog ograničenja
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

				//Ako je brzina veća od donje granice, povećaj brojač i nakon petlje ispiši brojač na label
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

		//Ispis brzina između unesenih indeksa
		private void ispisBrzina()
		{
			if (!ucitano)
			{
				MessageBox.Show("Niste učitali podatke!");
				return;
			}

			int pocetniIndeks, krajnjiIndeks;

			//Ako su jedno ili oba prozora prazna, ispiši poruku
			if (string.IsNullOrEmpty(txt_krajnjiIndeks.Text) && string.IsNullOrEmpty(txt_pocetniIndeks.Text))
			{
				MessageBox.Show("Barem jedna od granica nije upisana");
			}

			try
			{
				pocetniIndeks = int.Parse(txt_pocetniIndeks.Text);
				krajnjiIndeks = int.Parse(txt_krajnjiIndeks.Text);

				//Ako su indeksi izvan raspona, ispiši poruku
				if (pocetniIndeks < 0 || pocetniIndeks > brzineucitano.Length || krajnjiIndeks < 0 || krajnjiIndeks > brzineucitano.Length)
				{
					MessageBox.Show("Uneseni indeksi nisu u rasponu!");
					return;
				}

				//Ako je početni indeks veći od krajnjeg, ispiši poruku
				if (pocetniIndeks > krajnjiIndeks)
				{
					MessageBox.Show("Početni indeks ne moze biti veći od krajnjeg!");
					return;
				}

				//Ispisuju se brzine između unesenih indeksa, ali ne prije nego se obriše sve što je bilo prije
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
