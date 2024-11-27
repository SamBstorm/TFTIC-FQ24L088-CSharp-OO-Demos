using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.entities
{
    public class Personne
    {

        public Personne(string nom, string prenom, int age, int taille)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.taille = taille;
        }

        private string _nom;
        public string nom {
            get {
                return _nom;
            }
            set
            {
                if ((value.Length > 1) && (value[0] == value.ToUpper()[0]))
                {
                    this._nom = value;
                    Console.WriteLine(this._nom);
                } else Console.WriteLine("Erreur");
            } }

        private string _prenom;
        public string prenom { get; private set; }

        private int _taille;
        public int taille { get; set; } // en cm

        private int _age;
        public int age { get; set; }
    }
}
