//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//namespace лаб_работа_2
//{
//    public class DrawАвианосец1 : Vehicle
//    {

//        protected const int carWidth = 100;

//        protected const int carHeight = 60;
//        public DrawАвианосец1(int maxSpeed, float weight, Color mainColor)
//        {
//            MaxSpeed = maxSpeed;
//            Weight = weight;
//            MainColor = mainColor;
//        }






//        public override void MoveTransport(Direction direction)
//        {
//            float step = MaxSpeed * 100 / Weight;
//            switch (direction)
//            {
//                // вправо
//                case Direction.Right:
//                    if (_startPosX + step < _pictureWidth - carWidth - 205)
//                    {
//                        _startPosX += step;
//                    }
//                    break;
//                //влево                
//                case Direction.Left:
//                    if (_startPosX - step > 0 - 20)

//                    {
//                        _startPosX -= step;
//                    }
//                    break;
//                //вверх                 
//                case Direction.Up:
//                    if (_startPosY - step > 0 + 60)
//                    {
//                        _startPosY -= step;
//                    }

//                    break;
//                //вниз                
//                case Direction.Down:
//                    if (_startPosY + step < _pictureHeight - carHeight - 40)
//                    {
//                        _startPosY += step;
//                    }
//                    break;
//            }
//        }

//        public override void DrawАвианосец(Graphics g)
//        {


//            Pen pen = new Pen(Color.Black);


//            g.FillRectangle(Brushes.Teal, _startPosX + 15, _startPosY + 15, 185, 72);
//            g.FillEllipse(Brushes.Teal, _startPosX + 30, _startPosY + 20, 285, 62);
//            g.FillEllipse(Brushes.Goldenrod, _startPosX + 170, _startPosY + 35, 120, 30);

//            g.FillRectangle(Brushes.Goldenrod, _startPosX + 40, _startPosY + 30, 140, 40);
//            g.FillRectangle(Brushes.Goldenrod, _startPosX + 80, _startPosY + 35, 150, 30);




//            g.DrawEllipse(pen, _startPosX + 45, _startPosY + 37, 25, 25);
//            g.DrawEllipse(pen, _startPosX + 160, _startPosY + 45, 10, 10);
//            g.DrawRectangle(pen, _startPosX + 55, _startPosY + 33, 140, 33);
//            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 45, 140, 10);
//            g.DrawRectangle(pen, _startPosX + 190, _startPosY + 38, 10, 25);
//            g.DrawRectangle(pen, _startPosX + 170, _startPosY + 38, 10, 25);
//            g.DrawRectangle(pen, _startPosX + 150, _startPosY + 38, 10, 25);



//            g.FillRectangle(Brushes.Maroon, _startPosX + 190, _startPosY + 38, 10, 25);

//            g.FillRectangle(Brushes.Maroon, _startPosX + 170, _startPosY + 38, 10, 25);
//            g.FillRectangle(Brushes.Maroon, _startPosX + 150, _startPosY + 38, 10, 25);



//            // plane
//            g.FillEllipse(Brushes.Coral, _startPosX + 160, _startPosY + 87, 25, 10);
//            g.FillEllipse(Brushes.Coral, _startPosX + 170, _startPosY + 83, 5, 18);

//            g.FillEllipse(Brushes.Coral, _startPosX + 130, _startPosY + 87, 25, 10);
//            g.FillEllipse(Brushes.Coral, _startPosX + 140, _startPosY + 83, 5, 18);

//            g.FillEllipse(Brushes.Coral, _startPosX + 100, _startPosY + 87, 25, 10);
//            g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY + 83, 5, 18);

//            g.FillEllipse(Brushes.Coral, _startPosX + 70, _startPosY + 87, 25, 10);
//            g.FillEllipse(Brushes.Coral, _startPosX + 80, _startPosY + 83, 5, 18);
//        }
//    }




//    //    public class Car : Vehicle
//    //    {
//    //        private float _startPosX;
//    //        /// <summary>
//    //        /// Правая кооридната отрисовки автомобиля
//    //        /// </summary>
//    //        private float _startPosY;
//    //        /// <summary>
//    //        /// Ширина окна отрисовки
//    //        /// </summary>
//    //        private int _pictureWidth;
//    //        /// <summary>
//    //        /// Высота окна отрисовки
//    //        /// </summary>
//    //        private int _pictureHeight;
//    //        /// <summary>
//    //        /// Ширина отрисовки автомобиля
//    //        /// </summary>
//    //        private const int carWidth = 100;
//    //        /// <summary>
//    //        /// Ширина отрисовки автомобиля
//    //        /// </summary>
//    //        private const int carHeight = 60;
//    //        /// <summary>
//    //        /// Максимальная скорость
//    //        /// </summary>


//    //        public ArmorCar(int maxSpeed, float weight, Color mainColor)
//    //        {
//    //            MaxSpeed = maxSpeed;
//    //            Weight = weight;
//    //            MainColor = mainColor;

//    //        }
//    //        public override void MoveTransport(Direction direction)
//    //        {
//    //            float step = MaxSpeed * 100 / Weight;
//    //            switch (direction)
//    //            {
//    //                // вправо
//    //                case Direction.Right:
//    //                    if (_startPosX + step < _pictureWidth - carWidth)
//    //                    {
//    //                        _startPosX += step;
//    //                    }
//    //                    break;
//    //                //влево
//    //                case Direction.Left:
//    //                    if (_startPosX - step > 0)
//    //                    {
//    //                        _startPosX -= step;
//    //                    }
//    //                    break;
//    //                //вверх
//    //                case Direction.Up:
//    //                    if (_startPosY - step > 0)
//    //                    {
//    //                        _startPosY -= step;
//    //                    }
//    //                    break;
//    //                //вниз
//    //                case Direction.Down:
//    //                    if (_startPosY + step < _pictureHeight - carHeight)
//    //                    {
//    //                        _startPosY += step;
//    //                    }
//    //                    break;
//    //            }
//    //        }
//    //        public override void DrawCar(Graphics g)
//    //        {
//    //            Pen pen = new Pen(Color.Black);
//    //            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
//    //            Brush br = new SolidBrush(MainColor);
//    //            g.FillRectangle(br, _startPosX + 10, _startPosY + 20, 70, 22);


//    //            Brush br2 = new SolidBrush(Color.Brown);

//    //            g.DrawRectangle(pen, _startPosX + 7, _startPosY + 42, 75, 10);
//    //            g.FillRectangle(br2, _startPosX + 7, _startPosY + 42, 75, 10);
//    //            g.DrawEllipse(pen, _startPosX + 8, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 17, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 26, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 35, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 44, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 53, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 62, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 71, _startPosY + 42, 9, 9);


//    //            List<Point> star = new List<Point>(12);
//    //            star.Add(new Point((int)_startPosX + 41, (int)_startPosY + 26));
//    //            star.Add(new Point((int)_startPosX + 39, (int)_startPosY + 29));
//    //            star.Add(new Point((int)_startPosX + 36, (int)_startPosY + 29));
//    //            star.Add(new Point((int)_startPosX + 39, (int)_startPosY + 32));
//    //            star.Add(new Point((int)_startPosX + 38, (int)_startPosY + 35));
//    //            star.Add(new Point((int)_startPosX + 41, (int)_startPosY + 32));
//    //            star.Add(new Point((int)_startPosX + 44, (int)_startPosY + 35));
//    //            star.Add(new Point((int)_startPosX + 43, (int)_startPosY + 32));
//    //            star.Add(new Point((int)_startPosX + 46, (int)_startPosY + 29));
//    //            star.Add(new Point((int)_startPosX + 43, (int)_startPosY + 29));

//    //            Pen pen2 = new Pen(Color.Red);

//    //            g.DrawPolygon(pen2, star.ToArray<Point>());



//    //        }
//    //    }
//    //}





//}












        
