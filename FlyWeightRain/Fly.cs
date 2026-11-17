using System.Drawing;

namespace FlyWeightRain
{
    public class Param
    {
        public Bitmap pic;

        public Param()
        {
        }
    }

    public class Param1 : Param
    {
        public Param1()
        {
            pic = new Bitmap("drop1.png");
        }
    }

    public class Param2 : Param
    {
        public Param2()
        {
            pic = new Bitmap("drop2.png");
        }
    }

    class FlyDrop
    {
        Point p;
        int h, w;
        int speed;
        Param param;

        public FlyDrop()
        {
            p = new Point(0, 0);
            h = 30; w = 20;
            speed = 8;
        }

        public FlyDrop(int x, int y, Param param)
        {
            p = new Point(x, y);
            h = 30; w = 20;
            speed = 8;
            this.param = param;
        }

        public FlyDrop(int x, int y, int speed, Param param)
        {
            p = new Point(x, y);
            h = 30; w = 20;
            this.speed = speed;
            this.param = param;
        }

        public void Move(int maxHeight)
        {
            p.Y += speed;
            if (p.Y > maxHeight)
                p.Y = -h;
        }

        public void Show(Graphics g)
        {
            g.DrawImage(param.pic, new Rectangle(p.X, p.Y, w, h));
        }
    }
}
