using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Isdelie
    {
        private string name = new string(' ', 20);
        private string shifr = new string(' ', 20);
        private int kolvo;

        public Isdelie()
        {
            this.name = "название";
            this.shifr = "шифр";
            this.kolvo = 0;
    
        }
        public Isdelie(string name, string shifr, int kolvo)
        {
            this.name = name;
            this.shifr = shifr;
            this.kolvo = kolvo;

        }
        public string Name
        {
            set
            {
                name = value;
            }

        }
        public string Shifr
        {
            set
            {
                shifr = value;
            }

        }
        public int Kolvo
        {
            set
            {
                kolvo = value;
            }

        }
        public void GetInfo()
        {
            Console.WriteLine("название - {0}; Шифр {1}; Количество {2}.", name,shifr,kolvo);
        }
    }
}

