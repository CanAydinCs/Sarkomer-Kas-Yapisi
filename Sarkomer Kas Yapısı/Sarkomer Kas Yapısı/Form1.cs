using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarkomer_Kas_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ResimAyarla(int xBasla,int yBasla,int xOrta,int yOrta)
        {
            int x = xBasla;
            int y = yBasla;

            solKol0.Location = new Point(x, y);
            y += 50;
            solKol1.Location = new Point(x, y);
            y += 50;
            solKol2.Location = new Point(x, y);
            y += 50;
            solKol3.Location = new Point(x, y);
            y += 50;
            solKol4.Location = new Point(x, y);
            y += 50;
            solKol5.Location = new Point(x, y);

            x = xOrta;
            y = yOrta;

            sagKol0.Location = new Point(x, y);
            y += 50;
            sagKol1.Location = new Point(x, y);
            y += 50;
            sagKol2.Location = new Point(x, y);
            y += 50;
            sagKol3.Location = new Point(x, y);
            y += 50;
            sagKol4.Location = new Point(x, y);
            y += 50;
            sagKol5.Location = new Point(x, y);

            if (kontrol)
            {
                solZ.Location = new Point((solZ.Location.X + 1), solZ.Location.Y);
                sagZ.Location = new Point((sagZ.Location.X - 1), sagZ.Location.Y);
            }
            else
            {
                solZ.Location = new Point((solZ.Location.X - 1), solZ.Location.Y);
                sagZ.Location = new Point((sagZ.Location.X + 1), sagZ.Location.Y);
            }
        }

        string yol;
        int say;
        bool kontrol;

        private void Form1_Load(object sender, EventArgs e)
        {
            yol = Application.StartupPath + "\\Resimler\\";
            pictureBox1.ImageLocation = yol + "tam.png";

            solKol0.ImageLocation = yol + "sol_kol.png";
            solKol1.ImageLocation = yol + "sol_kol.png";
            solKol2.ImageLocation = yol + "sol_kol.png";
            solKol3.ImageLocation = yol + "sol_kol.png";
            solKol4.ImageLocation = yol + "sol_kol.png";
            solKol5.ImageLocation = yol + "sol_kol.png";

            sagKol0.ImageLocation = yol + "sağ_kol.png";
            sagKol1.ImageLocation = yol + "sağ_kol.png";
            sagKol2.ImageLocation = yol + "sağ_kol.png";
            sagKol3.ImageLocation = yol + "sağ_kol.png";
            sagKol4.ImageLocation = yol + "sağ_kol.png";
            sagKol5.ImageLocation = yol + "sağ_kol.png";

            solZ.ImageLocation = yol + "sagz.png";
            sagZ.ImageLocation = yol + "solZKısmı.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            solZ.Location = new Point(2, 22);
            sagZ.Location = new Point(703, 49);

            ResimAyarla(286, 87,450,79);

            timer1.Start();
            say = 39;
            kontrol = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            solZ.Location = new Point(30, 22);
            sagZ.Location = new Point(673, 49);

            ResimAyarla(326, 87, 410, 79);

            timer1.Start();
            say = 28;
            kontrol = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int xSol = solKol0.Location.X;
            int xSag = sagKol0.Location.X;

            if(say == 0)
            {
                timer1.Stop();
            }

            if (kontrol)
            {
                xSol++;
                xSag--;
            }
            else
            {
                xSol--;
                xSag++;
            }

            ResimAyarla(xSol, 87, xSag, 79);
            say--;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
