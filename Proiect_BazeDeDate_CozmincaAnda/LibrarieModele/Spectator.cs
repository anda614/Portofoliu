using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Spectator
    {
        public int idSpec;
        public string numeSpec;
        public int idMeci;
        public int nrScaun;

        public Spectator(int Id, string Nume, int IdMeci, int NrScaun)
        {
            idSpec = Id;
            numeSpec = Nume;
            idMeci = IdMeci;
            nrScaun = NrScaun;
        }

        public Spectator(DataRow dr)
        {
            idSpec = Convert.ToInt32(dr["id"].ToString());
            numeSpec = dr["nume"].ToString();
            idMeci = Convert.ToInt32(dr["meci"].ToString());
            nrScaun = Convert.ToInt32(dr["nr_scaun"].ToString());
        }
    }
}
