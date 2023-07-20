using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    abstract class Canli
    {
        abstract public void Konus();

        public void Tanit()
        {
            Console.WriteLine("bu bir abstract fonksiyondur");
        }
    }

    class Kedi : Canli
    {
        public override void Konus()
        {
            Console.WriteLine("miaavvvvvvvv");
        }
    }

    class Kopek : Canli
    {
        public override void Konus()
        {
            Console.WriteLine("hav hav");
        }
    }



}
