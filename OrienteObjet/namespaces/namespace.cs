using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ctrl E + ctrl W

namespace OrienteObjet.namespaces
{
    internal class Namespace
    {
        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}

namespace Super
{
    public class SuperClass
    {
        public void superFunc()
        {
            Console.WriteLine("coucou");
        }
    }

    namespace Hyper
    {

        public class Telephone
        {
            private int _numero;
            public string _marque;


            public Telephone(int numero, string marque)
            {
                this._numero = numero; // Ici le this est explicite et représente une instance de classe (un objet) créé à partir d'un constructeur de cette classe
                _marque = marque; // Ici le this est implicite.
            }

            public void Téléphoner(int numero)
            {
                Console.WriteLine($"La personne avec le numéro {numero} ne répond pas");
            }
        }
    }


    

}

namespace TestEnumAccessibility
{
    public enum Val { Val, Val2} // si public n'est pas précisé alors mon énumération est moins accessible que son utilisation dans MaClasse créant une erreur de compilation

    public class MaClasse
    {
        public Val val;
    }

}



