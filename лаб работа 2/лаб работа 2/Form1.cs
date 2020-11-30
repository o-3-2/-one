using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб_работа_2
{
    public partial class Form1 : Form
    {
        
        private ITransport Aircraftcarrier;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureCars.Width, pictureCars.Height);
            Graphics gr = Graphics.FromImage(bmp);


            
            Aircraftcarrier.DrawАвианосец(gr);
            pictureCars.Image = bmp;



           


        }
        private void button1_Click(object sender, EventArgs e)
        {



            Random rnd = new Random();
            Aircraftcarrier = new Aircraftcarrier(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
            Aircraftcarrier.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureCars.Width,
          pictureCars.Height);
            Draw();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            Aircraftcarrier = new Warship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,Color.Yellow,true,true );
            Aircraftcarrier.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureCars.Width, pictureCars.Height);


           

            Draw();
        }
     

        private void button3_Click(object sender, EventArgs e)
        {
           
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        Aircraftcarrier.MoveTransport(Direction.Up);
                           
                            break;
                    case "buttonDown":
                        Aircraftcarrier.MoveTransport(Direction.Down);
                          
                            break;
                    case "buttonLeft":
                    Aircraftcarrier.MoveTransport(Direction.Left);
                           
                            break;
                    case "buttonRight":
                        Aircraftcarrier.MoveTransport(Direction.Right);
                           
                            break;
                }
                Draw();

            


        }

        private void pictureCars_Click(object sender, EventArgs e)
        {

        }
    }
}
