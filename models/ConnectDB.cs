using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibreriaConnection.models
{
    class ConnectDB
    {
        public MySqlConnection connManager = new MySqlConnection();
        string server = "127.0.0.1;";
        string database = "libreria;";
        string user = "root;";
        string pass = "maxwell55A@;";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"server={server} database={database}Uid={user} password={pass}");
            return connManager;
        }

        internal List<Categorias> SelectCategorias(string sql)
        {
            List<Categorias> listaC = new List<Categorias>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idC = reader.GetInt32(0);
                        string nameC = reader.GetString(1);
                        listaC.Add(new Categorias(idC, nameC));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " +e.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return listaC;
        }

        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                cmd.ExecuteNonQuery();
                result = true;
                //Connect Closed();
            }catch(Exception w)
            {
                Console.WriteLine("ERROR " + w.Message);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }
        public void ConnectOpened()
        {
            //DataSource();
            connManager.Open();
        }
        public void ConnectClosed()
        {
            DataSource();
            connManager.Close();
        }
    }
}
