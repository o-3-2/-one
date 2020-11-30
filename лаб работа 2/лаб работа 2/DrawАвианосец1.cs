using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace лаб_работа_2
{
    

    public class Aircraftcarrier : Vehicle
    {

        protected readonly int АвианосецWidth = 100;

        protected readonly int АвианосецHeight = 100;
        protected double chWidth = 1.1;
        protected double chHeight = 3.2;

        public Aircraftcarrier(int maxSpeed, float weight, Color mainColor)
        {

            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
           
        }

        protected Aircraftcarrier(int maxSpeed, float weight, Color mainColor, int АвианосецWidth, int АвианосецHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.АвианосецWidth = АвианосецWidth;
            this.АвианосецHeight = АвианосецHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - АвианосецWidth * chHeight)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево                
                case Direction.Left:
                    if (_startPosX - step > 0 )

                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх                 
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }

                    break;
                //вниз                
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - АвианосецHeight * chWidth)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawАвианосец(Graphics g)
        {


            Pen pen = new Pen(Color.Black);



            //g.DrawRectangle(pen, _startPosX + 40, _startPosY + 30, 140, 40);

            //g.FillRectangle(Brushes.Coral, _startPosX + 40, _startPosY + 30, 140, 40);


            //g.DrawRectangle(pen, _startPosX + 80, _startPosY + 35, 150, 30);

            //g.FillRectangle(Brushes.Coral, _startPosX + 80, _startPosY + 35, 150, 30);

            //g.DrawEllipse(pen, _startPosX + 190, _startPosY + 13, 35, 80);


            Brush brRed = new SolidBrush(Color.Red);
            g.FillEllipse(brRed, _startPosX + 190, _startPosY + 13, 35, 80);
            // dbadh
            g.FillEllipse(Brushes.Coral, _startPosX + 95, _startPosY - 2, 40, 30);

            g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY - 30, 10, 30);


                                                     


            g.FillRectangle(Brushes.Teal, _startPosX + 30, _startPosY + 15, 150, 72);
            g.FillEllipse(Brushes.Teal, _startPosX + 30, _startPosY + 20, 285, 62);
            g.FillEllipse(Brushes.Goldenrod, _startPosX + 170, _startPosY + 35, 120, 30);

            g.FillRectangle(Brushes.Goldenrod, _startPosX + 40, _startPosY + 30, 140, 40);
          g.FillRectangle(Brushes.Goldenrod, _startPosX + 80, _startPosY + 35, 150, 30);




            

            g.FillRectangle(Brushes.Maroon, _startPosX + 190, _startPosY + 38, 10, 25);

            g.FillRectangle(Brushes.Maroon, _startPosX + 170, _startPosY + 38, 10, 25);
            g.FillRectangle(Brushes.Maroon, _startPosX + 150, _startPosY + 38, 10, 25);



           


            g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY + 9, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY + 9, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY + 9, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 2, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY - 2, 8, 8);
            g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY - 2, 8, 8);

        }
    }
}































































//////g.DrawEllipse(pen, _startPosX + 45, _startPosY + 37, 25, 25);
//////g.DrawEllipse(pen, _startPosX + 160, _startPosY + 45, 10, 10);
//////g.DrawRectangle(pen, _startPosX + 55, _startPosY + 33, 140, 33);
//////g.DrawRectangle(pen, _startPosX + 80, _startPosY + 45, 140, 10);
//////g.DrawRectangle(pen, _startPosX + 190, _startPosY + 38, 10, 25);
//////g.DrawRectangle(pen, _startPosX + 170, _startPosY + 38, 10, 25);
//////g.DrawRectangle(pen, _startPosX + 150, _startPosY + 38, 10, 25);






//////plane
//////g.FillEllipse(Brushes.Coral, _startPosX + 160, _startPosY + 87, 25, 10);
//////g.FillEllipse(Brushes.Coral, _startPosX + 170, _startPosY + 83, 5, 18);

//////g.FillEllipse(Brushes.Coral, _startPosX + 130, _startPosY + 87, 25, 10);
//////g.FillEllipse(Brushes.Coral, _startPosX + 140, _startPosY + 83, 5, 18);

//////g.FillEllipse(Brushes.Coral, _startPosX + 100, _startPosY + 87, 25, 10);
//////g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY + 83, 5, 18);

//////g.FillEllipse(Brushes.Coral, _startPosX + 70, _startPosY + 87, 25, 10);
//////g.FillEllipse(Brushes.Coral, _startPosX + 80, _startPosY + 83, 5, 18);


////////rsas
//////g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 56, 8, 8);

//////g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 66, 8, 8);

//////g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 46, 8, 8);
//////g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY + 20, 8, 8);
//////g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY + 20, 8, 8);
//////g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY + 20, 8, 8);




//////g.DrawRectangle(pen, _startPosX + 40, _startPosY + 30, 140, 40);

//////g.FillRectangle(Brushes.Coral, _startPosX + 40, _startPosY + 30, 140, 40);


//////g.DrawRectangle(pen, _startPosX + 80, _startPosY + 35, 150, 30);

//////g.FillRectangle(Brushes.Coral, _startPosX + 80, _startPosY + 35, 150, 30);

//////g.DrawEllipse(pen, _startPosX + 190, _startPosY + 13, 35, 80);


//////Brush brRed = new SolidBrush(Color.Red);
//////g.FillEllipse(brRed, _startPosX + 190, _startPosY + 13, 35, 80);
//////// dbadh
//////g.FillEllipse(Brushes.Coral, _startPosX + 95, _startPosY - 2, 40, 30);

//////g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY - 30, 10, 30);
