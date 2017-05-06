using System;
using System.Collections.Generic;
using System.Text;

namespace Lavirint
{
    class Kutija
    {


        public Kutija(Kutija temp)
        {
            this.X = temp.X;
            this.Y = temp.Y;
            this.ID = temp.ID;
        }

        public Kutija()
        {

        }
        public Kutija(int x, int y, int ID)
        {
            this.X = x;
            this.Y = y;
            this.ID = ID;
        }

        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


    }
}
