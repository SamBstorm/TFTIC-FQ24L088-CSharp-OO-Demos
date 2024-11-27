using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OverrideMethode
{
    internal class Chat : Animal
    {
        public Chat(string nom) : base(nom)
        {
        }

        public override void Manger()
        {
            Console.WriteLine($"{Nom} se dirige vers sa gamelle.");
            base.Manger();
            Ronroner();
        }

        public void Ronroner()
        {
            Console.WriteLine($"{Nom} ronrone");
        }

        public override string ToString()
        {
            return $"Je suis un chat qui se nomme {Nom}.";
        }

        public new void SeDeplacer()
        {
            Console.WriteLine($"{Nom} se promène en silence.");
        }
    }
}
