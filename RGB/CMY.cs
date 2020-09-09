using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    class CMY
    {
        private double cyan;
        private double magenta;
        private double yellow;
        public double Cyan
        {
            get
            {
                return cyan;
            }
        }
        public double Magenta
        {
            get
            {
                return magenta;
            }
        }

        public double Yellow
        {
            get
            {
              return yellow;
            }
        }

        public double Red
        {
            get
            {
               return 1 - cyan;
            }
        }
        public double Green
        {
            get
            {
                 return 1 - magenta;
            }
        }
        public double Blue
        {
            get
            {
                return 1 - yellow;
            }
        }
        private CMY(double c, double m, double y)
        {
            if (c < 0 || c > 1 || m < 0 || m > 1 || y < 0 || y > 1) throw new ArgumentException();
            cyan = c;
            magenta = m;
            yellow = y;
        }
        static public CMY CreateFromRGB(double r, double g, double b) => new CMY(1-r, 1-g,1-b);
        static public CMY CreateFromCMY(double c, double m, double y) => new CMY(c, m, y);

        static public CMY operator +(CMY a, CMY b)
        {
            double ans = a.cyan + b.cyan;
            ans = ans > 1 ?ans-1 : ans;
            double ans1 = a.magenta + b.magenta;
            ans1 = ans1 > 1 ? ans1-1 : ans1;
            double ans2 = a.yellow + b.yellow;
            ans2 = ans2 > 1 ? ans2-1 : ans2;
            return new CMY(ans, ans1, ans2);
        }
        static public CMY operator -(CMY a, CMY b)
        {
            double ans = a.cyan - b.cyan;
            ans = ans <0 ? ans+1 : ans;
            double ans1 = a.magenta - b.magenta;
            ans1 = ans1 < 0  ? ans1+1 : ans1;
            double ans2 = a.yellow - b.yellow;
            ans2 = ans2 < 0  ?ans2+1 : ans2;
            return new CMY(ans, ans1, ans2);
        }
        public override string ToString()
        {
            return "CMY->" + Cyan + " " + Magenta + " " + Yellow + "\n"+ "RGB->" + Red + " " + Green + " " + Blue;
        }
    }
}
