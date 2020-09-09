using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    class RGB
    {
        private double red;
        private double green;
        private double blue;
        public double Red
        {
            get 
            {
                return red;
            }
        }
        public double Green
        {
            get
            {
                return green;
            }
        }

        public double Blue
        {
            get
            {
                 return blue;
            }
        }

        public double Cyan
        {
            get
            {
                return 1-red;
            }
        }
        public double Magenta
        {
            get
            {
                 return 1 - green;
            }
        }
        public double Yellow
        {
            get
            {
                 return 1 - blue;
            }
        }
        private RGB(double r,double g,double b)
        {
            if (r < 0 || r > 1 || g < 0 || g > 1 || b < 0 || b > 1) throw new ArgumentException();
            red = r;
            green = g;
            blue = b;
        }
        static public RGB CreateFromRGB(double r, double g, double b) => new RGB(r,g,b);
        static public RGB CreateFromCMY(double c, double m, double y) => new RGB(1 - c, 1 - m, 1 - y);
         
        static public RGB operator +(RGB a, RGB b)
        {
            double ans = a.red + b.red;
            ans = ans > 1 ? ans-1 : ans;
            double ans1 = a.green + b.green;
            ans1 = ans1 > 1 ? ans1-1: ans1;
            double ans2 = a.blue + b.blue;
            ans2 = ans2 > 1 ? ans2-1 : ans2;
            return new RGB(ans,ans1,ans2);
        }
        static public RGB operator -(RGB a, RGB b)
        {
            double ans = a.red - b.red;
            ans = ans < 0 ? ans+1 : ans;
            double ans1 = a.green - b.green;
            ans1 = ans1 < 0 ? ans1+1 : ans1;
            double ans2 = a.blue - b.blue;
            ans2 = ans2 < 0 ? ans2+1 : ans2;
            return new RGB(ans, ans1, ans2);
        }
        public override string ToString()
        {
            return "RGB->"+Red+" "+Green+" "+Blue+"\n"+ "CMY->"+Cyan+" "+Magenta+" "+Yellow; 
        }
    }
}
