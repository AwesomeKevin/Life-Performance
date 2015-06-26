using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace GreenShark_Live_Performance
{
    public class Databasekoppeling
    {
        //Fields
        private OracleConnection conn;
        private OracleCommand command;
        string user = "dbi318713"; //Dit is de gebruikersnaam
        string pw = "V7brKp3nww"; //Dit is het wachtwoord

        public Databasekoppeling()
        {
            conn = new OracleConnection();
            command = conn.CreateCommand();
            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + "//192.168.15.50:1521/fhictora" + ";";
        }

        public int VraagHoogsteMissieIDOp()
        {
            int hoogsteID = 0;

            try
            {
                conn.Open();
                string query = "select * from MISSIE where ID = (select max(ID) from MISSIE)";
                command = new OracleCommand(query, conn);
                OracleDataReader datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    hoogsteID = Convert.ToInt32(datareader["ID"]);
                }
                return hoogsteID;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public int VraagHoogsteSINIDOp()
        {
            int hoogsteID = 0;

            try
            {
                conn.Open();
                string query = "select * from SIN where MISSIE_ID = (select max(MISSIE_ID) from SIN)";
                command = new OracleCommand(query, conn);
                OracleDataReader datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    hoogsteID = Convert.ToInt32(datareader["MISSIE_ID"]);
                }
                return hoogsteID;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public int VraagHoogsteHOPEIDOp()
        {
            int hoogsteID = 0;

            try
            {
                conn.Open();
                string query = "select * from HOPE where MISSIE_ID = (select max(MISSIE_ID) from HOPE)";
                command = new OracleCommand(query, conn);
                OracleDataReader datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    hoogsteID = Convert.ToInt32(datareader["MISSIE_ID"]);
                }
                return hoogsteID;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool VoegMissieToe(int id)
        {
            try
            {
                conn.Open();
                string query = "insert into MISSIE(ID) VALUES(" + id + ")";
                command = new OracleCommand(query, conn);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();

            }
            return false;
        }

        public bool VoegSINToe(int id, string naam, string beginddatum, int locatieX, int locatieY)
        {
            try
            {
                conn.Open();
                string query = "insert into SIN(MISSIE_ID, Naam, Begindatum, LocatieX, LocatieY, Bemanning) VALUES(" + id + ", '" + naam + "', '" + beginddatum + "', " + locatieX + ", " + locatieY + ", 'Harry Holmes')"; //De bemanning voer ik wegens tijdnood handmatig in
                command = new OracleCommand(query, conn);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();

            }
            return false;
        }

        public bool VoegHOPEToe(int id, string naam, string beginddatum, string einddatum, int locatieX, int locatieY)
        {
            try
            {
                conn.Open();
                string query = "insert into HOPE(MISSIE_ID, Naam, Begindatum, Einddatum, LocatieX, LocatieY, Bemanning) VALUES(" + id + ", '" + naam + "', '" + beginddatum + "', '" + einddatum + "', " + locatieX + ", " + locatieY + ", 'Harry Holmes')"; //De bemanning voer ik wegens tijdnod handmatig in
                command = new OracleCommand(query, conn);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();

            }
            return false;
        }
    }
}
