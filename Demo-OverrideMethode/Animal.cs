using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OverrideMethode
{
    internal class Animal
    {
        public string Nom { get; private set; }

        public Animal(string nom)
        {
            Nom = nom;
        }

        public virtual void Manger()
        {
            Console.WriteLine($"{Nom} se nourri.");
        }

        public override string ToString()
        {
            return $"Je suis un animal qui se nomme {Nom}.";
        }

        public void SeDeplacer()
        {
            Console.WriteLine($"{Nom} se promène.");
        }
    }
}
