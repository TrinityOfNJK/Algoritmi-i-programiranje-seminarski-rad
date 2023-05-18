using System;
using System.Windows.Forms;

namespace Seminarski
{
    partial class StajanjaApp
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
			this.gbox_brojStajanja = new System.Windows.Forms.GroupBox();
			this.rtxt_brojStajanja = new System.Windows.Forms.RichTextBox();
			this.xlbl_brojStajanja = new System.Windows.Forms.Label();
			this.gbox_brzine = new System.Windows.Forms.GroupBox();
			this.rtxt_brzine = new System.Windows.Forms.RichTextBox();
			this.xlbl_brojBrzina = new System.Windows.Forms.Label();
			this.lbl_brojBrzina = new System.Windows.Forms.Label();
			this.txt_krajnjiIndeks = new System.Windows.Forms.TextBox();
			this.lbl_krajnjiIndeks = new System.Windows.Forms.Label();
			this.txt_pocetniIndeks = new System.Windows.Forms.TextBox();
			this.lbl_pocetniIndeks = new System.Windows.Forms.Label();
			this.txt_brzinaogranicenja = new System.Windows.Forms.TextBox();
			this.lbl_brzinaOgranicenja = new System.Windows.Forms.Label();
			this.tsm_postavke = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_ucitaj = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_obrada = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_izracunBrojaStajanja = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_brzineIznadOgranicenja = new System.Windows.Forms.ToolStripMenuItem();
			this.tsm_dohvatPodataka = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.gbox_brojStajanja.SuspendLayout();
			this.gbox_brzine.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbox_brojStajanja
			// 
			this.gbox_brojStajanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.gbox_brojStajanja.Controls.Add(this.rtxt_brojStajanja);
			this.gbox_brojStajanja.Controls.Add(this.xlbl_brojStajanja);
			this.gbox_brojStajanja.Location = new System.Drawing.Point(12, 27);
			this.gbox_brojStajanja.Name = "gbox_brojStajanja";
			this.gbox_brojStajanja.Size = new System.Drawing.Size(240, 462);
			this.gbox_brojStajanja.TabIndex = 1;
			this.gbox_brojStajanja.TabStop = false;
			this.gbox_brojStajanja.Text = "Broj stajanja";
			// 
			// rtxt_brojStajanja
			// 
			this.rtxt_brojStajanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.rtxt_brojStajanja.Location = new System.Drawing.Point(6, 42);
			this.rtxt_brojStajanja.Name = "rtxt_brojStajanja";
			this.rtxt_brojStajanja.ReadOnly = true;
			this.rtxt_brojStajanja.Size = new System.Drawing.Size(228, 404);
			this.rtxt_brojStajanja.TabIndex = 1;
			this.rtxt_brojStajanja.Text = "";
			// 
			// xlbl_brojStajanja
			// 
			this.xlbl_brojStajanja.AutoSize = true;
			this.xlbl_brojStajanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xlbl_brojStajanja.Location = new System.Drawing.Point(6, 14);
			this.xlbl_brojStajanja.Name = "xlbl_brojStajanja";
			this.xlbl_brojStajanja.Size = new System.Drawing.Size(17, 24);
			this.xlbl_brojStajanja.TabIndex = 0;
			this.xlbl_brojStajanja.Text = "-";
			// 
			// gbox_brzine
			// 
			this.gbox_brzine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.gbox_brzine.Controls.Add(this.rtxt_brzine);
			this.gbox_brzine.Controls.Add(this.xlbl_brojBrzina);
			this.gbox_brzine.Controls.Add(this.lbl_brojBrzina);
			this.gbox_brzine.Controls.Add(this.txt_krajnjiIndeks);
			this.gbox_brzine.Controls.Add(this.lbl_krajnjiIndeks);
			this.gbox_brzine.Controls.Add(this.txt_pocetniIndeks);
			this.gbox_brzine.Controls.Add(this.lbl_pocetniIndeks);
			this.gbox_brzine.Controls.Add(this.txt_brzinaogranicenja);
			this.gbox_brzine.Controls.Add(this.lbl_brzinaOgranicenja);
			this.gbox_brzine.Location = new System.Drawing.Point(259, 27);
			this.gbox_brzine.Name = "gbox_brzine";
			this.gbox_brzine.Size = new System.Drawing.Size(213, 462);
			this.gbox_brzine.TabIndex = 2;
			this.gbox_brzine.TabStop = false;
			this.gbox_brzine.Text = "Brzine";
			// 
			// rtxt_brzine
			// 
			this.rtxt_brzine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.rtxt_brzine.Location = new System.Drawing.Point(10, 114);
			this.rtxt_brzine.Name = "rtxt_brzine";
			this.rtxt_brzine.ReadOnly = true;
			this.rtxt_brzine.Size = new System.Drawing.Size(197, 332);
			this.rtxt_brzine.TabIndex = 8;
			this.rtxt_brzine.Text = "";
			// 
			// xlbl_brojBrzina
			// 
			this.xlbl_brojBrzina.AutoSize = true;
			this.xlbl_brojBrzina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xlbl_brojBrzina.Location = new System.Drawing.Point(110, 37);
			this.xlbl_brojBrzina.Name = "xlbl_brojBrzina";
			this.xlbl_brojBrzina.Size = new System.Drawing.Size(17, 24);
			this.xlbl_brojBrzina.TabIndex = 7;
			this.xlbl_brojBrzina.Text = "-";
			// 
			// lbl_brojBrzina
			// 
			this.lbl_brojBrzina.AutoSize = true;
			this.lbl_brojBrzina.Location = new System.Drawing.Point(107, 20);
			this.lbl_brojBrzina.Name = "lbl_brojBrzina";
			this.lbl_brojBrzina.Size = new System.Drawing.Size(56, 13);
			this.lbl_brojBrzina.TabIndex = 6;
			this.lbl_brojBrzina.Text = "Broj brzina";
			// 
			// txt_krajnjiIndeks
			// 
			this.txt_krajnjiIndeks.Location = new System.Drawing.Point(113, 87);
			this.txt_krajnjiIndeks.Name = "txt_krajnjiIndeks";
			this.txt_krajnjiIndeks.Size = new System.Drawing.Size(91, 20);
			this.txt_krajnjiIndeks.TabIndex = 5;
			this.txt_krajnjiIndeks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_krajnjiIndeks_KeyPress);
			// 
			// lbl_krajnjiIndeks
			// 
			this.lbl_krajnjiIndeks.AutoSize = true;
			this.lbl_krajnjiIndeks.Location = new System.Drawing.Point(110, 70);
			this.lbl_krajnjiIndeks.Name = "lbl_krajnjiIndeks";
			this.lbl_krajnjiIndeks.Size = new System.Drawing.Size(69, 13);
			this.lbl_krajnjiIndeks.TabIndex = 4;
			this.lbl_krajnjiIndeks.Text = "Krajnji indeks";
			// 
			// txt_pocetniIndeks
			// 
			this.txt_pocetniIndeks.Location = new System.Drawing.Point(10, 87);
			this.txt_pocetniIndeks.Name = "txt_pocetniIndeks";
			this.txt_pocetniIndeks.Size = new System.Drawing.Size(91, 20);
			this.txt_pocetniIndeks.TabIndex = 3;
			this.txt_pocetniIndeks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pocetniIndeks_KeyPress);
			// 
			// lbl_pocetniIndeks
			// 
			this.lbl_pocetniIndeks.AutoSize = true;
			this.lbl_pocetniIndeks.Location = new System.Drawing.Point(7, 70);
			this.lbl_pocetniIndeks.Name = "lbl_pocetniIndeks";
			this.lbl_pocetniIndeks.Size = new System.Drawing.Size(77, 13);
			this.lbl_pocetniIndeks.TabIndex = 2;
			this.lbl_pocetniIndeks.Text = "Početni indeks";
			// 
			// txt_brzinaogranicenja
			// 
			this.txt_brzinaogranicenja.Location = new System.Drawing.Point(10, 37);
			this.txt_brzinaogranicenja.Name = "txt_brzinaogranicenja";
			this.txt_brzinaogranicenja.Size = new System.Drawing.Size(91, 20);
			this.txt_brzinaogranicenja.TabIndex = 1;
			this.txt_brzinaogranicenja.TextChanged += new System.EventHandler(this.txt_brzinaogranicenja_TextChanged);
			this.txt_brzinaogranicenja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_brzinaogranicenja_KeyPress);
			// 
			// lbl_brzinaOgranicenja
			// 
			this.lbl_brzinaOgranicenja.AutoSize = true;
			this.lbl_brzinaOgranicenja.Location = new System.Drawing.Point(7, 20);
			this.lbl_brzinaOgranicenja.Name = "lbl_brzinaOgranicenja";
			this.lbl_brzinaOgranicenja.Size = new System.Drawing.Size(94, 13);
			this.lbl_brzinaOgranicenja.TabIndex = 0;
			this.lbl_brzinaOgranicenja.Text = "Brzina ograničenja";
			// 
			// tsm_postavke
			// 
			this.tsm_postavke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_ucitaj,
            this.tsm_obrada});
			this.tsm_postavke.Name = "tsm_postavke";
			this.tsm_postavke.Size = new System.Drawing.Size(66, 20);
			this.tsm_postavke.Text = "Postavke";
			// 
			// tsm_ucitaj
			// 
			this.tsm_ucitaj.Name = "tsm_ucitaj";
			this.tsm_ucitaj.Size = new System.Drawing.Size(113, 22);
			this.tsm_ucitaj.Text = "Učitaj";
			this.tsm_ucitaj.Click += new System.EventHandler(this.tsm_ucitaj_Click);
			// 
			// tsm_obrada
			// 
			this.tsm_obrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_izracunBrojaStajanja,
            this.tsm_brzineIznadOgranicenja,
            this.tsm_dohvatPodataka});
			this.tsm_obrada.Name = "tsm_obrada";
			this.tsm_obrada.Size = new System.Drawing.Size(113, 22);
			this.tsm_obrada.Text = "Obrada";
			// 
			// tsm_izracunBrojaStajanja
			// 
			this.tsm_izracunBrojaStajanja.Name = "tsm_izracunBrojaStajanja";
			this.tsm_izracunBrojaStajanja.Size = new System.Drawing.Size(202, 22);
			this.tsm_izracunBrojaStajanja.Text = "Izračun broja stajanja";
			this.tsm_izracunBrojaStajanja.Click += new System.EventHandler(this.tsm_izracunBrojaStajanja_Click);
			// 
			// tsm_brzineIznadOgranicenja
			// 
			this.tsm_brzineIznadOgranicenja.Name = "tsm_brzineIznadOgranicenja";
			this.tsm_brzineIznadOgranicenja.Size = new System.Drawing.Size(202, 22);
			this.tsm_brzineIznadOgranicenja.Text = "Brzine iznad ograničenja";
			this.tsm_brzineIznadOgranicenja.Click += new System.EventHandler(this.tsm_brzineIznadOgranicenja_Click);
			// 
			// tsm_dohvatPodataka
			// 
			this.tsm_dohvatPodataka.Name = "tsm_dohvatPodataka";
			this.tsm_dohvatPodataka.Size = new System.Drawing.Size(202, 22);
			this.tsm_dohvatPodataka.Text = "Dohvat podataka";
			this.tsm_dohvatPodataka.Click += new System.EventHandler(this.tsm_dohvatPodataka_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_postavke});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(484, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// StajanjaApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(484, 501);
			this.Controls.Add(this.gbox_brzine);
			this.Controls.Add(this.gbox_brojStajanja);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 540);
			this.MinimumSize = new System.Drawing.Size(500, 540);
			this.Name = "StajanjaApp";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Grupa D - Stajanja";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbox_brojStajanja.ResumeLayout(false);
			this.gbox_brojStajanja.PerformLayout();
			this.gbox_brzine.ResumeLayout(false);
			this.gbox_brzine.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
        #endregion
        private GroupBox gbox_brojStajanja;
        private RichTextBox rtxt_brojStajanja;
        private Label xlbl_brojStajanja;
        private GroupBox gbox_brzine;
        private Label lbl_brzinaOgranicenja;
        private TextBox txt_krajnjiIndeks;
        private Label lbl_krajnjiIndeks;
        private TextBox txt_pocetniIndeks;
        private Label lbl_pocetniIndeks;
        private TextBox txt_brzinaogranicenja;
        private Label lbl_brojBrzina;
        private RichTextBox rtxt_brzine;
        private Label xlbl_brojBrzina;
        private ToolStripMenuItem tsm_postavke;
        private ToolStripMenuItem tsm_ucitaj;
        private ToolStripMenuItem tsm_obrada;
        private ToolStripMenuItem tsm_izracunBrojaStajanja;
        private ToolStripMenuItem tsm_brzineIznadOgranicenja;
        private ToolStripMenuItem tsm_dohvatPodataka;
        private MenuStrip menuStrip1;
    }
}

