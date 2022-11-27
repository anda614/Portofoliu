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
    public class AdministrareSpectatori : IStocareSpectatori
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Spectator> GetSpectatori()
        {
            var result = new List<Spectator>();
            var dsSpectatori = SqlDBHelper.ExecuteDataSet("select * from spectatori_CAE", CommandType.Text);

            foreach (DataRow linieDB in dsSpectatori.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Spectator(linieDB));
            }
            return result;
        }

        public bool AddSpectator(Spectator s)
        {

            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO spectatori_CAE VALUES (id_spectatori_cae.nextval, :Nume, :IdMeci, :NrScaun)", CommandType.Text,
                //new OracleParameter(":Id", OracleDbType.Int32, s.id, ParameterDirection.Input),
                new OracleParameter(":Nume", OracleDbType.NVarchar2, s.numeSpec, ParameterDirection.Input),
                new OracleParameter(":IdMeci", OracleDbType.Int32, s.idMeci, ParameterDirection.Input),
                new OracleParameter(":NrScaun", OracleDbType.Int32, s.nrScaun, ParameterDirection.Input)
                );
        }

        public bool DeleteSpectator(Spectator s)
        {

            return SqlDBHelper.ExecuteNonQuery(
                "DELETE FROM spectatori_cae WHERE id = :Id", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, s.idSpec, ParameterDirection.Input)
                );
        }
        public Spectator GetSpectator(int id)
        {
            Spectator result = null;
            var dsSpectator = SqlDBHelper.ExecuteDataSet("select * from spectatori_CAE where Id = :Id", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsSpectator.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsSpectator.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Spectator(linieDB);
            }
            return result;
        }
        public bool UpdateSpectator(Spectator s)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE spectator_CAE set nume = :Nume, meci = :IdMeci, nr_scaun = :NrScaun where id = " + s.idSpec, CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.NVarchar2, s.numeSpec, ParameterDirection.Input),
                new OracleParameter(":IdMeci", OracleDbType.Int32, s.idMeci, ParameterDirection.Input),
                new OracleParameter(":NrScaun", OracleDbType.Int32, s.nrScaun , ParameterDirection.Input)
            );
        }
    }
}
