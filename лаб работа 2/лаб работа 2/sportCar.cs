//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//namespace лаб_работа_2
//{
//    class sportDrawАвианосец : DrawАвианосец1
//    {

//        public enum Direction
//        {
//            Up,

//            Down,

//            Left,

//            Right
//        }


//        public Color DopColor { private set; get; }

//        public bool FrontSpoiler { private set; get; }

//        public bool SideSpoiler { private set; get; }

//        public bool BackSpoiler { private set; get; }
//        private int _countLines;


//        public int MaxSpeed { private set; get; }


//        public float GunRange { private set; get; }

//        public float Weight { private set; get; }


//        public bool Flag { private set; get; }

//        public Color MainColor { private set; get; }
//        public int CountLines
//        {
//            set
//            {
//                if (value > 0 && value < 4) _countLines = value;
//            }
//            get
//            {
//                return _countLines;
//            }
//        }
//        public sportDrawАвианосец(int maxSpeed, float weight, Color mainColor, Color dopColor,
// bool frontSpoiler, bool sideSpoiler, bool backSpoiler) :
//  base(maxSpeed, weight, mainColor)
//        {

//            DopColor = dopColor;
//            FrontSpoiler = frontSpoiler;
//            SideSpoiler = sideSpoiler;
//            BackSpoiler = backSpoiler;
//           // GunRange = gunRange;
//            Random rnd = new Random();
//            CountLines = rnd.Next(1, 4);

//        }

//        public override void DrawАвианосец(Graphics g)
//        {

//            Pen pen = new Pen(Color.Black);
//            Brush dopBrush = new SolidBrush(DopColor);
//            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка автомобиля на него "легла")             
//            if (FrontSpoiler)
//            {

//                g.DrawEllipse(pen, _startPosX + 190, _startPosY + 13, 35, 80);


//                Brush brRed = new SolidBrush(Color.Red);
//                g.FillEllipse(brRed, _startPosX + 190, _startPosY + 13, 35, 80);







//                //dbadh


//                g.FillEllipse(Brushes.Coral, _startPosX + 95, _startPosY - 2, 40, 30);

//                g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY - 30, 10, 30);




//                // rsas
//                g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 56, 8, 8);

//                g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 66, 8, 8);

//                g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 46, 8, 8);


//                g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY + 20, 8, 8);
//                g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY + 20, 8, 8);
//                g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY + 20, 8, 8);



//                g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY + 9, 8, 8);
//                g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY + 9, 8, 8);
//                g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY + 9, 8, 8);



//                g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 2, 8, 8);
//                g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY - 2, 8, 8);
//                g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY - 2, 8, 8);


//                g.FillEllipse(Brushes.Teal, _startPosX + 60, _startPosY + 80, 150, 30);
//                g.FillRectangle(Brushes.Teal, _startPosX + 40, _startPosY + 81, 40, 20);
//            }

//            base.DrawАвианосец(g);

//        }

//    }






//    //    class sportCar : Car
//    //    {
//    //        private float _startPosX;
//    //        
//    //        private float _startPosY;
//    //        
//    //        private int _pictureWidth;
//    //        
//    //        private int _pictureHeight;
//    //        
//    //        private const int carWidth = 100;
//    //        
//    //        private const int carHeight = 60;
//    //       
//    //        public int MaxSpeed { private set; get; }

//    //       
//    //        public float GunRange { private set; get; }
//    //        
//    //        public float Weight { private set; get; }

//    //       
//    //        public bool Flag { private set; get; }
//    //        
//    //        public Color MainColor { private set; get; }

//    //       

//    //        public sportCar(int maxSpeed, float weight, Color mainColor, Color dopColor,
//    //      float gunRange, bool flag, bool mask)
//    //      float gunRange, bool flag, bool mask) : base(maxSpeed, weight, mainColor)
//    //        {
//    //            MaxSpeed = maxSpeed;
//    //            Weight = weight;
//    //            MainColor = mainColor;

//    //            DopColor = dopColor;
//    //            GunRange = gunRange;
//    //            Flag = flag;
//    //            Mask = mask;

//    //        }
//    //    
//    //    public void SetPosition(int x, int y, int width, int height)
//    //    {
//    //        _startPosX = x;
//    //        _startPosY = y;
//    //        _pictureWidth = width;
//    //        _pictureHeight = height;
//    //    }
//    //    
//    //    public void MoveTransport(Direction direction)
//    //    {
//    //        float step = MaxSpeed * 100 / Weight;
//    //        switch (direction)
//    //        {
//    //            // вправо
//    //            case Direction.Right:
//    //                if (_startPosX + step < _pictureWidth - carWidth)
//    //                {
//    //                    _startPosX += step;
//    //                }
//    //                break;
//    //            //влево
//    //            case Direction.Left:
//    //                if (_startPosX - step > 0)
//    //                {
//    //                    _startPosX -= step;
//    //                }
//    //                break;
//    //            //вверх
//    //            case Direction.Up:
//    //                if (_startPosY - step > 0)
//    //                {
//    //                    _startPosY -= step;
//    //                }
//    //                break;
//    //            //вниз
//    //            case Direction.Down:
//    //                if (_startPosY + step < _pictureHeight - carHeight)
//    //                {
//    //                    _startPosY += step;
//    //                }
//    //                break;
//    //        }
//    //    }
//    //    public  void DrawCar(Graphics g)

//    //        public override void DrawCar(Graphics g)
//    //    {
//    //        Pen pen = new Pen(Color.Black);
//    //        g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
//    //        Brush br1 = new SolidBrush(DopColor);
//    //        g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
//    //        g.DrawRectangle(pen, _startPosX + 10, _startPosY + 20, 70, 22);
//    //        g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
//    //        if (Flag)
//    //        {
//    //            g.DrawRectangle(pen, _startPosX + 45, _startPosY - 10, 7, 5);
//    //public void DrawArmorCar(Graphics g)
//    //                g.DrawLine(pen, _startPosX + 52, _startPosY - 5, _startPosX + 52, _startPosY + 5);

//    //    }
//    //    Brush br = new SolidBrush(MainColor);
//    //    g.FillRectangle(br, _startPosX + 10, _startPosY + 20, 70, 22);
//    //            Brush br1 = new SolidBrush(DopColor);
//    //    g.FillRectangle(br1, _startPosX + 22, _startPosY + 5, 47, 15);
//    //            Brush br2 = new SolidBrush(Color.Brown);
//    //    List<Point> star = new List<Point>(12);
//    //    star.Add(new Point((int) _startPosX + 41, (int) _startPosY + 26));
//    //            star.Add(new Point((int) _startPosX + 39, (int) _startPosY + 29));
//    //            star.Add(new Point((int) _startPosX + 36, (int) _startPosY + 29));
//    //            star.Add(new Point((int) _startPosX + 39, (int) _startPosY + 32));
//    //            star.Add(new Point((int) _startPosX + 38, (int) _startPosY + 35));
//    //            star.Add(new Point((int) _startPosX + 41, (int) _startPosY + 32));
//    //            star.Add(new Point((int) _startPosX + 44, (int) _startPosY + 35));
//    //            star.Add(new Point((int) _startPosX + 43, (int) _startPosY + 32));
//    //            star.Add(new Point((int) _startPosX + 46, (int) _startPosY + 29));
//    //            star.Add(new Point((int) _startPosX + 43, (int) _startPosY + 29));
//    //            Pen pen2 = new Pen(Color.Red);
//    //    Brush br4 = new SolidBrush(Color.Red);
//    //    g.DrawPolygon(pen2, star.ToArray<Point>());
//    //            g.DrawRectangle(pen, _startPosX + 7, _startPosY + 42, 77, 10);
//    //            g.FillRectangle(br2, _startPosX + 7, _startPosY + 42, 77, 10);
//    //            g.DrawEllipse(pen, _startPosX + 8, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 17, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 26, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 35, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 44, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 53, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 62, _startPosY + 42, 9, 9);
//    //            g.DrawEllipse(pen, _startPosX + 71, _startPosY + 42, 9, 9);
//    //            g.DrawLine(pen, _startPosX + 69, _startPosY + 12, _startPosX + 89, _startPosY + 12);
//    //            base.DrawCar(g);

//    //            if (Mask)
//    //            {
//    //                Pen pen1 = new Pen(MainColor);
//    // public void DrawCar(Graphics g)
//    //                g.DrawLine(pen1, _startPosX + 80, _startPosY, _startPosX, _startPosY + 60);
//    //                g.DrawLine(pen1, _startPosX + 70, _startPosY, _startPosX - 10, _startPosY + 60);
//    //            }
//    //            }


//    //        }
//    //    }
//    //}




//}








