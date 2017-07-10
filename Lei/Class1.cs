using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    partial class point
    {
        public point(int ax,int ay,int bx,int by)
        {
            Ax = ax;
            Bx = bx;
            Ay = ay;
            By = by;
        }
        public point()
        {

        }
        public double cal()
        {
            return Math.Sqrt(Math.Pow(this.Ax - this.Bx, 2) + Math.Pow(this.Ay - this.By, 2));
        }
        public void set(int ax, int ay, int bx, int by)
        {
            Ax = ax;
            Bx = bx;
            Ay = ay;
            By = by;
        }
    }
}
