using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace лаб_работа_2
{
    interface ITransport
    {


        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);


        void DrawАвианосец(Graphics g);

    }
}
