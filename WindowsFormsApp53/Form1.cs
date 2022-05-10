using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*Na vstupu je číslo N a N-prvková posloupnost kladných celých čísel z intervalu
<5,120>. Obsahuje posloupnost prvočíslo a jaké? Pro zkrácení běhu programu
použijte typ bool, to znamená, že jakmile najde první prvočíslo tak je cyklus prohledávání ukončen.

Ošetřete uživatelský vstup!*/
            InitializeComponent();
        }
        private bool prvocislo(int x)
        {
            if (x == 2) { return true; }
            if (x == 1 || x == 0 || x % 2 == 0) { return false; }
            for (int i = 3; i <= Math.Sqrt(x); i += 2)
            {
                if (x % i == 0) { return false; }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if((int)numericUpDown1.Value != textBox1.Lines.Count()) { MessageBox.Show("Počet prvků a číslo N nesedí!"); return; }
            foreach(string str in textBox1.Lines)
            {
                int numb = 0;
                try
                {
                    numb = Int32.Parse(str);
                }
                catch (Exception) { MessageBox.Show("Zadal jsi špatné údaje!"); return; }
                if(prvocislo(numb)&&numb >=5 && numb <= 120) { MessageBox.Show("1. prvočíslo je: " + numb); return; }
            }
            MessageBox.Show("V zadaných číslech není prvočíslo");
        }
    }
}
