using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiSommesNous.Models
{
    public class Plat
    {
      
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Prix { get; set; }
        public string  Type { get; set; }
        public string Recommandation { get; set; }

        public Plat()
        {

        }

        public Plat(int id, string nom, int prix, string type, string recommandation)
        {
            Id = id;
            Nom = nom;
            Prix = prix;
            Type = type;
            Recommandation = recommandation;
        }
    }

}
