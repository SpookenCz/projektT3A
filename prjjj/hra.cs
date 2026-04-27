using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace prjjj
{
    public partial class hra : Form
    {
        string[] otazkyLehke = { "Kolik je 2 + 2?", "Který sport nepoužívá míč", "Jaký je chemický symbol pro kyslík?", "Jaký strom má žaludy?", "Jaké je skupenství vody při 0 °C a níž?", "Která barva vznikne smícháním modré a žluté?", "Jaké národnosti byl panovník Hirohito", "Jaká velikost triček neexistuje?", "Která z uvedených rostlin není luštěnina?", "Přímý úhel měří:"};
        string[,] odpovediLehke =
        {
             {"3","4","5","6"}, {"Fotbal","Basketbal","Hokej","Volejbal"}, {"S","H","Hg","O"}, {"Dub","Buk","Borovice","Lípa"}, {"Plynné","Kapalné","Pevné","Žádné"}, {"Fialová","Oranžová","Hnědá","Zelená"}, {"Japonské","Vietnamské","Čínské","Korejské"}, {"M","S","L","X"}, {"Sója","Proso","Bob","Čočka"}, {"45 stupňů","60 stupňů","90 stupňů","180 stupňů"},
        };
        int[] spravnaLehke = { 1, 2, 3, 0, 2, 3, 0, 3, 1, 3};

        string[] otazkyStredni = { "Kolik je 5 * 5?", "Kolik hráčů má jeden fotbalový tým na hřišti?", "Kdo složil slavnou „9. symfonii“?", "Který oceán leží mezi Amerikou a Evropou?", "Jaká měna se používá v Japonsku?", "Nejlepší portugalský hráč", "Kdo objevil Ameriku v roce 1492?", "Která kryptoměna byla vytvořena jako první v roce 2009?", "Která symfonie je oficiální hymnou EU?" };
        string[,] odpovediStredni =
        {
            {"10","20","25","30"}, {"9","10","11","12"}, {"Mozart","Beethoven","Mach","Chopin"}, {"Severní ledový","Tichý","Indický","Atlantský"}, {"Jen","Won","Chuan","Dollar",}, {"Eusébio","Luís Fígo","Cristiano Ronaldo","Rui Costa",}, {"Vasco da Gama","Kryštof Kolumbus","Marco Polo","Amerigo Vespucci",}, {"Bitcoin","Etherum","Litecoin","Dogecoin",}, {"Óda na radost","Jupiterská","Rozlučková","Kde domov můj",}
        };
        int[] spravnaStredni = { 2, 2, 1, 3, 0, 2, 1, 0, 0};

        string[] otazkyTezke = { "Kolik je 12 * 12?", "Jaký vynález je spojen s bratry Wrightovými?", "Jaký je hlavní prvek v jádru hvězd?", "Kdo byl poslední panovník Ruska před revolucí v roce 1917?", "Který chemik vyvinul periodickou tabulku prvků?", "Ve kterém roce byl představen první iPhone?", "Jak se jmenuje část Prahy, které se říká pražské Benátky?", "V roce 1750 mělo v Evropě nejvíce obyvatel město", "Co předepsal doktor polámenému mravenečkovi v dětské básničce?", "Které z následujících příborů jsou vyobrazeny na dopravní značce informující o blízkosti restaurace?" };
        string[,] odpovediTezke =
        {
            {"100","144","120","130"}, {"Letadlo","Auto","Rádio","Motocykl"}, {"Helium","Kyslík","Vodík","Uhlík"}, {"Ivan Hrozný","Petr Veliký","Alexandra I.","Mikuláš II."}, {"Mendělejev","Einstein","Curie","Lavoisier"}, {"2005","2007","2004","2006"}, {"Kajetánka","Vyšehrad","Bertramka","Kampa"}, {"Berlín","Paříž","Madrid","Londýn"}, {"tabletu analgetika","lžíci sirupu","prášek cukru","kapku medu"}, {"Vidlička a nůž","Lžíce a vidlička","Lžíce a nůž","Lžíce, vidlička a nůž"},
        };
        int[] spravnaTezke = { 1, 0, 2, 3, 0, 1, 3, 3, 2, 1 };

        int aktualniOtazka = 0;
        int obtiznost = 0; // 0 = lehká, 1 = střední, 2 = těžká
        int pocetSpravnych = 1;
        int[] penize = { 1000, 2000, 3000, 4000, 5000, 10000, 20000, 50000, 75000, 100000, 250000, 500000, 690420, 750000, 1000000 };
        bool[] pouzite;
        Random rnd = new Random();
        int posun = 0;
        bool[] aktivniOdpovedi = { true, true, true, true };


        private Form1 mainForm;

        public hra(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void hra_Load(object sender, EventArgs e)
        {
            InicializujPouzite();
            NactiOtazku();
            label1.Text = penize[0].ToString() + " Kč";
            label2.Text = penize[1].ToString() + " Kč";
            label3.Text = penize[2].ToString() + " Kč";
            label4.Text = penize[3].ToString() + " Kč";
            label5.Text = penize[4].ToString() + " Kč";
            label1.BackColor = Color.DarkOrange;
            label5.ForeColor = Color.Yellow;
            

        }

        void NactiOtazku()
        {
            for (int i = 0; i < 4; i++)
            {
                aktivniOdpovedi[i] = true;
            }
            aktualniOtazka = VyberNahodnouOtazku();

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

            if (obtiznost == 0)
            {
                labelOtazka.Text = pocetSpravnych + ". " + otazkyLehke[aktualniOtazka];
                buttonA.Text = "A: " + odpovediLehke[aktualniOtazka, 0];
                buttonB.Text = "B: " + odpovediLehke[aktualniOtazka, 1];
                buttonC.Text = "C: " + odpovediLehke[aktualniOtazka, 2];
                buttonD.Text = "D: " + odpovediLehke[aktualniOtazka, 3];
            }
            else if (obtiznost == 1)
            {
                labelOtazka.Text = pocetSpravnych + ". " + otazkyStredni[aktualniOtazka];
                buttonA.Text = "A: " + odpovediStredni[aktualniOtazka, 0];
                buttonB.Text = "B: " + odpovediStredni[aktualniOtazka, 1];
                buttonC.Text = "C: " + odpovediStredni[aktualniOtazka, 2];
                buttonD.Text = "D: " + odpovediStredni[aktualniOtazka, 3];
            }
            else
            {
                labelOtazka.Text = pocetSpravnych + ". " + otazkyTezke[aktualniOtazka];
                buttonA.Text = "A: " + odpovediTezke[aktualniOtazka, 0];
                buttonB.Text = "B: " + odpovediTezke[aktualniOtazka, 1];
                buttonC.Text = "C: " + odpovediTezke[aktualniOtazka, 2];
                buttonD.Text = "D: " + odpovediTezke[aktualniOtazka, 3];
            }

        }

        void ZkontrolujOdpoved(int index)
        {

            if (index == spravnaAktualni())
            {
                MessageBox.Show("Správně!", "Milionář");
                pocetSpravnych++;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;

                if (pocetSpravnych == 14)
                {
                    posun++;
                }
                if (posun == 0)
                {
                    label1.BackColor = Color.DarkGreen;
                    label2.BackColor = Color.DarkOrange;
                    posun++;
                }
                else if (posun == 1)
                {
                    label2.BackColor = Color.DarkGreen;
                    label3.BackColor = Color.DarkOrange;
                    posun++;
                }
                else if (posun == 2)
                {
                    label1.Text = penize[pocetSpravnych - 3].ToString() + " Kč";
                    label2.Text = penize[pocetSpravnych - 2].ToString() + " Kč";
                    label3.Text = penize[pocetSpravnych - 1].ToString() + " Kč";
                    label4.Text = penize[pocetSpravnych].ToString() + " Kč";
                    label5.Text = penize[pocetSpravnych + 1].ToString() + " Kč";
                }
                else if (posun == 3)
                {
                    label3.BackColor = Color.DarkGreen;
                    label4.BackColor = Color.DarkOrange;
                    posun++;
                }
                else if (posun == 4)
                {
                    label4.BackColor = Color.DarkGreen;
                    label5.BackColor = Color.DarkOrange;
                }

                if (label1.Text == "5000 Kč" || label1.Text == "100000 Kč" || label1.Text == "1000000 Kč")
                {
                    label1.ForeColor = Color.Yellow;
                }
                if (label2.Text == "5000 Kč" || label2.Text == "100000 Kč" || label2.Text == "1000000 Kč")
                {
                    label2.ForeColor = Color.Yellow;
                }
                if (label3.Text == "5000 Kč" || label3.Text == "100000 Kč" || label3.Text == "1000000 Kč")
                {
                    label3.ForeColor = Color.Yellow;
                }
                if (label4.Text == "5000 Kč" || label4.Text == "100000 Kč" || label4.Text == "1000000 Kč")
                {
                    label4.ForeColor = Color.Yellow;
                }
                if (label5.Text == "5000 Kč" || label5.Text == "100000 Kč" || label5.Text == "1000000 Kč")
                {
                    label5.ForeColor = Color.Yellow;
                }




                if (obtiznost == 0 && pocetSpravnych > 5)
                {
                    obtiznost = 1;
                    InicializujPouzite();
                }
                else if (obtiznost == 1 && pocetSpravnych > 10)
                {
                    obtiznost = 2;
                    InicializujPouzite();
                }
                else if (obtiznost == 2 && pocetSpravnych > 15)
                {
                    label5.BackColor = Color.DarkGreen;
                    MessageBox.Show("Vyhrál jsi 1 000 000 Kč!");
                    mainForm.Show();
                    this.Close();
                    return;
                }

                NactiOtazku();
            }
            else
            {
                string spr = "";

                if (spravnaAktualni() == 0)
                    spr = "A";
                else if (spravnaAktualni() == 1)
                    spr = "B";
                else if (spravnaAktualni() == 2)
                    spr = "C";
                else
                    spr = "D";

                if (pocetSpravnych < 6)
                {
                    MessageBox.Show($"Jste strašný Milhouse, nevyhrál jste ani korunu, nevracejte se tu už nikdy!. Správná odpověď byla za {spr}", "Konec");
                }
                else if (pocetSpravnych < 11)
                {
                    MessageBox.Show($"Bohužel, ale vyhráváte aspoň 5 000 Kč. Správná odpověď byla za {spr}", "Konec");
                }
                else if (pocetSpravnych < 16)
                {
                    MessageBox.Show($"Špatná odpověď, ale dokázal jste vyhrát alespoň 100 000 Kč. Správná odpověď byla za {spr}", "Konec");
                }

                mainForm.Show();
                this.Close();
            }
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult vysledek = MessageBox.Show("Opravdu se chceš vrátit do hlavního menu?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vysledek == DialogResult.Yes)
            {
                mainForm.Show();
                this.Close();
            }
        }

        private void nápovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            napoveda help = new napoveda();
            help.ShowDialog();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            ZkontrolujOdpoved(0);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            ZkontrolujOdpoved(1);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ZkontrolujOdpoved(2);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ZkontrolujOdpoved(3);
        }

        int spravnaAktualni()
        {
            if (obtiznost == 0)
                return spravnaLehke[aktualniOtazka];
            else if (obtiznost == 1)
                return spravnaStredni[aktualniOtazka];
            else
                return spravnaTezke[aktualniOtazka];
        }

        void InicializujPouzite()
        {
            int pocet = 0;

            if (obtiznost == 0)
                pocet = otazkyLehke.Length;
            else if (obtiznost == 1)
                pocet = otazkyStredni.Length;
            else
                pocet = otazkyTezke.Length;

            pouzite = new bool[pocet];
        }
        int VyberNahodnouOtazku()
        {
            int pocet = pouzite.Length;
            int index;

            do
            {
                index = rnd.Next(pocet);
            } while (pouzite[index]);

            pouzite[index] = true;
            return index;
        }

        private void ukončitAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vysledek = MessageBox.Show("Opravdu chceš vypnout hru?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vysledek == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int spravna = spravnaAktualni();

            int[] spatne = new int[3];
            int index = 0;

            for (int i = 0; i < 4; i++)
            {
                if (i != spravna)
                {
                    spatne[index] = i;
                    index++;
                }
            }

            int nahodnaSpatna = spatne[rnd.Next(3)];

            for (int i = 0; i < 4; i++)
            {
                if (i != spravna && i != nahodnaSpatna)
                {
                    if (i == 0)
                    {
                        buttonA.Text = "A: nic";
                        buttonA.Enabled = false;
                        aktivniOdpovedi[i] = false;
                    }
                    if (i == 1)
                    {
                        buttonB.Text = "B: nic";
                        buttonB.Enabled = false;
                        aktivniOdpovedi[i] = false;
                    }
                    if (i == 2)
                    {
                        buttonC.Text = "C: nic";
                        buttonC.Enabled = false;
                        aktivniOdpovedi[i] = false;
                    }
                    if (i == 3)
                    {
                        buttonD.Text = "D: nic";
                        buttonD.Enabled = false;
                        aktivniOdpovedi[i] = false;
                    }
                }
            }
            button2.Enabled = false;
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            pictureBox3.Visible = true;

            int spravna = spravnaAktualni();
            int[] procenta = new int[4];

            int spravneProcenta;

            if (obtiznost == 0) spravneProcenta = rnd.Next(60, 81);
            else if (obtiznost == 1) spravneProcenta = rnd.Next(40, 61);
            else spravneProcenta = rnd.Next(25, 41);

            procenta[spravna] = spravneProcenta;

            int zbytek = 100 - spravneProcenta;

            int pocetAktivnich = 0;
            for (int i = 0; i < 4; i++)
            {
                if (i != spravna && aktivniOdpovedi[i])
                    pocetAktivnich++;
            }

            for (int i = 0; i < 4; i++)
            {
                if (i != spravna && aktivniOdpovedi[i])
                {
                    int nahodne;

                    if (pocetAktivnich > 1)
                    {
                        nahodne = rnd.Next(0, zbytek + 1);
                    }
                    else
                    {
                        nahodne = zbytek;
                    }

                    procenta[i] = nahodne;
                    zbytek -= nahodne;
                    pocetAktivnich--;
                }
            }

            MessageBox.Show($"A: {procenta[0]}%\nB: {procenta[1]}%\nC: {procenta[2]}%\nD: {procenta[3]}%", "Hlasování publika");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            pictureBox2.Visible = true;
            int spravna = spravnaAktualni();
            int tip;
            int sance;
            int[] aktivni = new int[4];
            int pocet = 0;

            for (int i = 0; i < 4; i++)
            {
                if (aktivniOdpovedi[i])
                {
                    aktivni[pocet] = i;
                    pocet++;
                }
            }

            if (obtiznost == 0) sance = 95;
            else if (obtiznost == 1) sance = 75;
            else sance = 50;

            if (aktivniOdpovedi[spravna] && rnd.Next(100) < sance)
            {
                tip = spravna;
            }
            else
            {
                tip = aktivni[rnd.Next(pocet)];
            }

            string[] pismena = { "A", "B", "C", "D" };

            int styl = rnd.Next(4);

            string zprava = "";
            string kamos = "";

            if (styl == 0)
            {
                kamos = "Jeffrey";
                zprava = $"Jo, tohle vím jistě! Je to {pismena[tip]}.";

            }
            else if (styl == 1)
            {
                kamos = "Checkpoint Blinker";
                zprava = $"Hmm... nejsem si úplně jistý, ale tipnul bych {pismena[tip]}.";
            }
            else if (styl == 2)
            {
                kamos = "Milhouse";
                zprava = "Co je tohle za prank? *ukončil hovor*";
            }
            else
            {
                kamos = "Chamtivý Žigr";
                zprava = $"Musí to být za mě {pismena[tip]}! Dej mi pak aspoň půlku jak vyhraješ.";
            }
            MessageBox.Show(zprava, kamos);
        }
    }
}
