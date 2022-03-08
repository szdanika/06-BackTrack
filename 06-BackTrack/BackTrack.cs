using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BackTrack
{
    abstract internal class BackTrack
    {
        protected int N;
        protected int[] M;
        protected object[,] R;
        public abstract void ft(int x, object y);
        public abstract void fk(int x, object y, int x0, object y0);
        public delegate void AllapotFigyelo(int x, object[] tomb);
        public event AllapotFigyelo Probalkozas;
    }
}
