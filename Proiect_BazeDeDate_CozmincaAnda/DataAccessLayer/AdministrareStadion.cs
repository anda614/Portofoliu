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
    public class AdministrareStadion : IStocareStadion
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Stadion> GetStadioane()
        {
            var result = new List<Stadion>();
            var dsStadioane = SqlDBHelper.ExecuteDataSet("select * from stadion_CAE", CommandType.Text);

            foreach (DataRow linieDB in dsStadioane.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add( new Stadion(linieDB));
            }
            return result;
        }

        /*public bool createTable(Stadion s)
        {
            return SqlDBHelper.ExecuteNonQuery("CREATE TABLE stadion (:Id, :Nume, :Locatie);", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, s.id, ParameterDirection.Input),
                new OracleParameter(":Nume", OracleDbType.NVarchar2, s.nume, ParameterDirection.Input),
                new OracleParameter(":Locatie", OracleDbType.NVarchar2, s.locatie, ParameterDirection.Input));
        }*/

        public bool AddStadion(Stadion s)
        {

            return SqlDBHelper.ExecuteNonQuery(
                "INSERT INTO stadion_CAE VALUES (id_stadion_cae.nextval, :Nume, :Locatie, :Capacitate)", CommandType.Text,
                //new OracleParameter(":Id", OracleDbType.Int32, s.id, ParameterDirection.Input),
                new OracleParameter(":Nume", OracleDbType.NVarchar2, s.nume, ParameterDirection.Input),
                new OracleParameter(":Locatie", OracleDbType.NVarchar2, s.locatie, ParameterDirection.Input),
                new OracleParameter(":Capacitate", OracleDbType.Int32, s.capacitate, ParameterDirection.Input)
                );
        }

        public bool DeleteStadion(Stadion s)
        {

            return SqlDBHelper.ExecuteNonQuery(
                "DELETE FROM stadion_CAE WHERE id = :Id", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, s.id, ParameterDirection.Input)
                );
        }
        public Stadion GetStadion(int id)
        {
            Stadion result = null;
            var dsStadion = SqlDBHelper.ExecuteDataSet("select * from stadion_CAE where Id = :Id", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsStadion.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieDB = dsStadion.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Stadion(linieDB);
            }
            return result;
        }
        public bool UpdateStadion(Stadion s)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE stadion_CAE set nume = :Nume, locatie = :Locatie, capacitate = :Capacitate where id = "+s.id, CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.NVarchar2, s.nume, ParameterDirection.Input),
                new OracleParameter(":Locatie", OracleDbType.NVarchar2, s.locatie, ParameterDirection.Input),
                new OracleParameter(":Capacitate", OracleDbType.Int32, s.capacitate, ParameterDirection.Input)
            );
        }
    }
}
