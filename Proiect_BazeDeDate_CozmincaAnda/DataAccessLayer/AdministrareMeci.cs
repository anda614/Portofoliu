using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using LibrarieModele;

namespace NivelAccesDate
{
    public class AdministrareMeci : IStocareMeci
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Meci> GetMeciuri()
        {
            var result = new List<Meci>();
            var dsMeciuri = SqlDBHelper.ExecuteDataSet("select * from meci_CAE", CommandType.Text);

            foreach (DataRow linieDB in dsMeciuri.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Meci(linieDB));
            }
            return result;
        }

        public bool AddMeci(Meci m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO meci_CAE VALUES (id_meci_cae.nextval, :TipSport, :NumeEchipa, :Data, :Durata, :Stadion, :PretBilet)", CommandType.Text,
                //new OracleParameter(":Id", OracleDbType.Int32, m.id, ParameterDirection.Input),
                new OracleParameter(":TipSport", OracleDbType.NVarchar2, m.tipSport, ParameterDirection.Input),
                new OracleParameter(":NumeEchipa", OracleDbType.NVarchar2, m.numeEchipa, ParameterDirection.Input),
                new OracleParameter(":Data", OracleDbType.Date, m.dataMeci, ParameterDirection.Input),
                new OracleParameter(":Durata", OracleDbType.Int32, m.durataInOre, ParameterDirection.Input),
                new OracleParameter(":Stadion", OracleDbType.Int32, m.stadionID, ParameterDirection.Input),
                new OracleParameter(":PretBilet", OracleDbType.Int32, m.pretBilet, ParameterDirection.Input)
                );
        }
        public bool DeleteMeci(Meci m)
        {

            return SqlDBHelper.ExecuteNonQuery(
                "DELETE FROM meci_CAE WHERE id = :Id", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, m.idMeci, ParameterDirection.Input)
                );
        }
        public Meci GetMeci(int id)
        {
            Meci result = null;
            var dsMeci = SqlDBHelper.ExecuteDataSet("select * from meci_CAE where Id = :Id", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsMeci.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsMeci.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Meci(linieDB);
            }
            return result;
        }

        public bool UpdateMeci(Meci m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE meci_CAE set tip_sport = :TipSport, nume_echipa = :NumeEchipa, data = :Data, durata = :Durata, stadion = :Stadion, pret_bilet :PretBilet where id = " + m.idMeci, CommandType.Text,
                new OracleParameter(":TipSport", OracleDbType.NVarchar2, m.tipSport, ParameterDirection.Input),
                new OracleParameter(":NumeEchipa", OracleDbType.NVarchar2, m.numeEchipa, ParameterDirection.Input),
                new OracleParameter(":Data", OracleDbType.Date, m.dataMeci, ParameterDirection.Input),
                new OracleParameter(":Durata", OracleDbType.Int32, m.durataInOre, ParameterDirection.Input),
                new OracleParameter(":Stadion", OracleDbType.Int32, m.stadionID, ParameterDirection.Input),
                new OracleParameter(":PretBilet", OracleDbType.Int32, m.pretBilet, ParameterDirection.Input)
            );
        }
    }
}
