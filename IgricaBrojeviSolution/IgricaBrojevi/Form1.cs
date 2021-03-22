using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgricaBrojevi
{
    public partial class Form1 : Form
    {

        private DateTime pocetnoVreme;
        private Random ran; 


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int brojacKlikova = int.Parse(button1.Text);

            brojacKlikova++;

            

            button1.Text = brojacKlikova.ToString();

            if (brojacKlikova == 10)
            {
                DateTime krajnjeVreme = DateTime.Now;
                int sekunde = (krajnjeVreme - pocetnoVreme).Seconds;
                int milisekunde = ((krajnjeVreme - pocetnoVreme).Milliseconds) % 1000; 
                label1.Text = "Vreme : " + sekunde + ":" + milisekunde;

                
            }
            
            ran = new Random();

            int xKordinata = ran.Next(0, this.Width - 100);
            int yKordinata = ran.Next(0, this.Height - 100);

            button1.Location = new Point(xKordinata, yKordinata);

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "0";
            label1.Text = "";
            pocetnoVreme = DateTime.Now;
            ran = new Random();

            int xKordinata = ran.Next(0, this.Width - 100);
            int yKordinata = ran.Next(0, this.Height - 100);

            button1.Location = new Point(xKordinata, yKordinata); 
        }
    }
}
