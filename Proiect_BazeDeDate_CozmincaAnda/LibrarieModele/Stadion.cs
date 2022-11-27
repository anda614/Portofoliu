using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Stadion
    {
        public int id;
        public string nume;
        public string locatie;
        public int capacitate;

        public Stadion(int Id, string Nume, string Locatie, int Capacitate)
        {
            id = Id;
            nume = Nume;
            locatie = Locatie;
            capacitate = Capacitate;
        }

        public Stadion(DataRow dr)
        {
            id = Convert.ToInt32(dr["id"].ToString());
            nume = dr["nume"].ToString();
            locatie =  dr["locatie"].ToString();
            capacitate = Convert.ToInt32(dr["capacitate"].ToString());
        }
    }
}
