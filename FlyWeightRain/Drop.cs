using System.Drawing;

namespace FlyWeightRain
{
    public class Drop
    {
        Point p;
        int h, w;
        Bitmap pic;

        public Drop()
        {
            p = new Point(0, 0);
            h = 30; w = 20;
            pic = new Bitmap("drop1.png");
        }

        public Drop(int x, int y)
        {
            p = new Point(x, y);
            h = 30; w = 20;
            pic = new Bitmap("drop1.png");
        }

        public void Show(Graphics g)
        {
            g.DrawImage(pic, new Rectangle(p.X, p.Y, w, h));
        }
    }
}
