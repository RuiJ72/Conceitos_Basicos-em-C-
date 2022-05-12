using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_revisoes
{
    internal class vertex
    {
        private int x1;
        private int y2;
        private int x;
        private int y;

        public vertex()
        {
            this.x = 1;
            this.y = 1;
            this.x1 = 1;
            this.y2 = 1;
        }
        public double X1
        {
            get
            {
                return this.x1;
            }
            set
            {
                if (value >= 0) x1 = (int)value;
                else
                {
                    throw new Exception("A coordenada deve ser maior do que zero");
                }
            }
        }
        public double Y1
        {
            get
            {
                return x1;
            }
            set
                if (value >= 0) x1 = (int)value;
            else
            {
                throw new Exception("A coordenada deve ser maior do que 0");
            }
            }
        }
    }

