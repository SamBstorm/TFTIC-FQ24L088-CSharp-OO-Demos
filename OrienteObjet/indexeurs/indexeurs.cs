using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.indexeurs
{
    public class NomCollection
    {
        private string[] _noms = new string[3];

        public string this[int index]
        {
            get
            {
                return _noms[index];
            }
            set
            {
                if ((value.Length > 1) && (value[0] == value.ToUpper()[0]))
                {
                    _noms[index] = value;
                }
                else Console.WriteLine("Tu dois respecter la normalisation !");
            }
        }
    }
}
