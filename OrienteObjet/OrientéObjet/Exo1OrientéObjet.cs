using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.OrientéObjet
{
    public class Personne
    {
        public string nom {  get; set; }
        public string prenom { get; set; }
        public DateTime dateNaiss { get; set; }
    }

    public class Courant
    {
        public string numero { get; set; }
        public double solde { get; private set; }
        public double ligneDeCredit { get; set; } //limite négative du compte strictement supérieur ou égale à 0;
        public Personne titulaire { get; set; }

        public void Retrait(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant du retrait doit être positif !");
                return;
            }
            if (this.solde - montant >= -this.ligneDeCredit)
            {
                this.solde -= montant;
                Console.WriteLine($"Retrait de {montant} effectué. Nouveau solde : {this.solde}");
            }
            else
            {
                Console.WriteLine("Retrait refusé : dépassement de la ligne de crédit !");
            }
        }

        public void Depot(double montant)
        {
            if (montant > 0)
            {
                this.solde += montant;
                Console.WriteLine($"Dépôt de {montant} effectué. Nouveau solde : {this.solde}");
            }
            else
            {
                Console.WriteLine("Le montant du dépôt doit être positif !");
            }
        }
    }

    public class Banque
    {
        public string Nom { get; set; }

        private List<Courant> comptes = new List<Courant>();
        public Courant this[string numero]
        {
            get
            {
                foreach (var compte in comptes)
                {
                    if (compte.numero == numero) return compte;
                }
                return null;
            }
        }

        public void Ajouter(Courant compte)
        {
            comptes.Add(compte);
            Console.WriteLine($"Le compte {compte.numero} a été ajouté à la banque.");
        }

        public void Supprimer(string numero)
        {
            var compte = this[numero];
            if (compte != null)
            {
                comptes.Remove(compte);
                Console.WriteLine($"Le compte {numero} a été supprimé de la banque.");
            }
            else
            {
                Console.WriteLine($"Aucun compte trouvé avec le numéro {numero}.");
            }
        }
    }


}
