using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GUI_dolgozok
{
    class Adatbazis
    {
        MySqlCommand SqlCommand = null;
        MySqlConnection connection = null;

        public Adatbazis() 
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "munkasok";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                kapcsolatNyit();

                SqlCommand = connection.CreateCommand();

                kapcsolatZar();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        internal List<Dolgozo> getAllDolgozo()
        {
            List<Dolgozo> dolgozos = new List<Dolgozo>();
            SqlCommand.CommandText = "SELECT * FROM `munkasok`;";
            kapcsolatNyit();
            using (MySqlDataReader dr = SqlCommand.ExecuteReader()) 
            {
                while (dr.Read())
                {
                    Dolgozo a = new Dolgozo
                    {
                        Nev = dr.GetString(0),
                        Neme = dr.GetString(1),
                        Reszleg = dr.GetString(2),
                        Belepesev = int.Parse( dr.GetString(3)),
                        Ber = int.Parse( dr.GetString(4))
                       
                    };
                    dolgozos.Add(a);
                }
            }

                return dolgozos;
        }

        private void kapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
    }
}
