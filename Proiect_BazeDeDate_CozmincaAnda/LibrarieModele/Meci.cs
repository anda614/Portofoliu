using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Meci
    {
        public int idMeci;
        public string tipSport;
        public string numeEchipa;
        public DateTime dataMeci;
        public int durataInOre;
        public int stadionID;
        public int pretBilet;

        public Meci(int Id, string TipSport, string NumeEchipa, DateTime DataMeci, int Durata, int Stadion, int Pret)
        {
            idMeci = Id;
            tipSport = TipSport;
            numeEchipa = NumeEchipa;
            dataMeci = DataMeci;
            durataInOre = Durata;
            stadionID = Stadion;
            pretBilet = Pret;
        }

        public Meci(DataRow dr)
        {
            idMeci = Convert.ToInt32(dr["id"].ToString());
            tipSport = dr["tip_sport"].ToString();
            numeEchipa = dr["nume_echipa"].ToString();
            dataMeci = Convert.ToDateTime(dr["data"]);
            durataInOre = Convert.ToInt32(dr["durata"].ToString());
            stadionID = Convert.ToInt32(dr["stadion"].ToString());
            pretBilet = Convert.ToInt32(dr["pret_bilet"].ToString());
        }
    }
}
