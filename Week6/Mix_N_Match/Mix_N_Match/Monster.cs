using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mix_N_Match
{
    public abstract class Monster
    {
        protected string name;
        protected Bitmap head;
        protected Bitmap body;
        protected Bitmap legs;

        public Bitmap getHead()
        {
            return head;
        }

        public Bitmap getBody()
        {
            return body;
        }

        public Bitmap getLegs()
        {
            return legs;
        }

        public Monster()
        {
            name = "";
            
        }

        public void SetBitmaps()
        {
            head = new Bitmap("../../Images/" + name + "_0.png");
            body = new Bitmap("../../Images/" + name + "_1.png");
            legs = new Bitmap("../../Images/" + name + "_2.png");
        }
    }
}
