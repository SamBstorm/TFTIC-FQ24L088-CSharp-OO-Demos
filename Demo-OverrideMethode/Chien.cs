using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OverrideMethode
{
    internal class Chien : Animal
    {
        public Chien(string nom) : base(nom)
        {
        }

        public override void Manger()
        {
            Console.WriteLine($"{Nom} se dirige vers sa gamelle.");
            base.Manger();
            RemuerQueue();
        }

        public void RemuerQueue()
        {
            Console.WriteLine($"{Nom} remue sa queue!");
        }
    }
}
