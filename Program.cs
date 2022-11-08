using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examan
{
    public class Point
    {
        public float x;
        public float y;
        public int Getx()
        {
            return x;


        }
        public void Setx(float ax)
        {
            this.x = x;

        }
        public int Gety()
        {
            return y;
        }
        public void Sety(float ay)
        {
            this.y = y;

        }
        public Point(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public float distance(Point p1)
        {
            float dis =(float) Math.Sqrt(Math.Pow(x - p1.x, 2) + Math.Pow(y - p1.x, 2));
            return dis;    
        }
        public bool comparer(Point p1)
        {
            if (x == p1.x && y == p1.y)
                return true;

            return false;
        }
         public void translation(float a)
        {
            x += a;
            y += a;
        }
        public bool liniarite(Point p1 , Point p2 )
        {
            float li = (p2.y - y)*(p1.x - x) - (p1.y - y)*(p2.x - x);

               if ( li== 0)
                return true;
            else return false;

        }


    }







}
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
