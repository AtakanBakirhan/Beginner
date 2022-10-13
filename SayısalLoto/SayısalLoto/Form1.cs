using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int d = 0, k = 0, t = 10, f = 0, b;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            pictureBox1.BackColor = Color.Gray;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepSkyBlue;
            pictureBox1.BackColor = Color.DeepSkyBlue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            pictureBox1.BackColor = Color.LimeGreen;
        }

        private void bordoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Maroon;
            pictureBox1.BackColor = Color.Maroon;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
        }

        private void sonuçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(f + " el oynadın ve elde ettiğin toplam " + b + " Türk Lirasıdır. istersen seçenekler/exit butonundan çıkabilirsin.", "Sonuç");
        }

        private void kurallarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" KURALLAR BASİTTİR \n Eğer ki sayıyı tutturursan paranı kazanırsın. \n 1 eşleşme 1TL \n 2 eşleşme 2 TL \n 3 eşleşme 4TL\n 4 eşleşme 6TL \n Bakiyen 25TL olursa oyundan çıkmak zorundasın eğer ki 0 olursa kaybedersin. \n \n İYİ ŞANSLAR...","Kurallar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int s1, s2, s3, s4;
            s1 = rast.Next(1,5);
            s2 = rast.Next(1,5);
            s3 = rast.Next(1,5);
            s4 = rast.Next(1,5);
            f++;

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            label10.Text = k.ToString();
            if (label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
                d++;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
                d++;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
                d++;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
                d++;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            button1.Enabled = false;
            button2.Enabled = true;

            label9.Text = d.ToString();

            if (d == 1)
            {
                k++;
            }
            else if(d == 2)
            {
                k += 2;
            }
            else if (d == 3)
            {
                k += 4;
            }
            else if (d == 4)
            {
                k += 6;
            }
            t -= 2;
            b = t - 10;
            label8.Text = t.ToString();

            label10.Text = k.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            button1.Enabled = true;
            button2.Enabled = false;
            t = t + k;
            d = 0;
            k = 0;
            
            if(label8.Text == "25")
            {
                MessageBox.Show("Tebrikler kazandınız.");
                t = 10;
            }
            if (label8.Text == "0")
            {
                MessageBox.Show("Loser kaybettin.");
                t = 10;

            }
            label9.Text = d.ToString();
            label10.Text = k.ToString();
            label8.Text = t.ToString();
        }
    }
}
