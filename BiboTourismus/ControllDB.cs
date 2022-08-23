using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Bibo_Tourismus
{
    public class ControllDB : IController
    {

        SqlConnection conny = new SqlConnection();
        string startpfad;
        public ControllDB(string pfad)
        {
            //verbindungszeichenfolge
            //welcher Server, welche Datenbank, wie anmelden
            startpfad = pfad;
            conny.ConnectionString = pfad;
        }
        //methode zum Öffnen der Datenbankverbindung 
        //Übergabe: keine 
        //Rückgabe: bool (geht oder geht nicht)



 
        public Sight[] AllSight()
        {
            List<Sight> liste = new List<Sight>();
            string sql = "select sid, sname,sort,sbeschreibung,sbild  from sight;";
            conny.Open();
            SqlCommand com = new SqlCommand(sql, conny);
            SqlDataReader reader = com.ExecuteReader();

            //solange noch Zeilen vorhanden sind 
            //lies die nächste Zeile - der Zeiger rückt vor 
            while (reader.Read())
            {
                //der zeiger hat ein array von allen zellen in der zeile 
       


                liste.Add(new Sight(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
            }

            //schließen zeiger auf ergebnistabelle, damit kann Server
            //die tabelle aus Cache entfernen 
            reader.Close();

            //Rückgabe einer List<> suboptimal, weil list kann von view verändert werden
            //Umwandeln in Array, da Array nicht geändert werden kann 
            conny.Close();
            return liste.ToArray();
        }

        public Sight[] AllSight(string _name)
        {
            _name = "%" + _name + "%";
            string sql = "select sid, sname,sort,sbeschreibung,sbild from sight where sname like @name or sort like @name ";
            conny.Open();
            SqlCommand com = new SqlCommand(sql, conny);
            com.Prepare();
            com.Parameters.AddWithValue("@name", _name);
            SqlDataReader reader = com.ExecuteReader();
            List<Sight> liste = new List<Sight>();
            while (reader.Read())
            {
                

                liste.Add(new Sight(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
            }

            //schließen zeiger auf ergebnistabelle, damit kann Server
            //die tabelle aus Cache entfernen 
            reader.Close();

            //Rückgabe einer List<> suboptimal, weil list kann von view verändert werden
            //Umwandeln in Array, da Array nicht geändert werden kann 
            conny.Close();
            return liste.ToArray();

        }
         public Sight GetSight(int _id)
        {
            string sql = "select * from sight where sid = @id";
            SqlCommand com = new SqlCommand(sql, conny);
            conny.Open();
            com.Prepare();
            com.Parameters.AddWithValue("@id", _id);

            SqlDataReader reader = com.ExecuteReader();




            Sight sig = new Sight(reader.GetInt32(0), reader.GetString(1),reader.GetString(2), reader.GetString(3), reader.GetString(4));

            reader.Close();
            conny.Close();
            return sig;
        }

        public Tour[] AllTour()
        {
            List<Tour> liste = new List<Tour>();
            string sql = "select * from  V_touren";
            conny.Open();
            SqlCommand com = new SqlCommand(sql, conny);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {


                liste.Add(new Tour(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3),reader.GetDateTime(4)));
            }
            reader.Close();
            conny.Close();
            return liste.ToArray();
        }

        public Tour[] AllTour(string _sight)
        {
            List<Tour> liste = new List<Tour>();
            string sql = "select * from  V_touren where sname = @sight";
            SqlCommand com = new SqlCommand(sql, conny);
            conny.Open();
            com.Prepare();
            com.Parameters.AddWithValue("@sight", _sight);
            
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {


                liste.Add(new Tour(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3),reader.GetDateTime(4)));
            }
            reader.Close();
            conny.Close();
            return liste.ToArray();
        }

        public Organiser[] AllOrga()
        {
            List<Organiser> liste = new List<Organiser>();
            string sql = "select oid,oname from organiser;";
            conny.Open();
            SqlCommand com = new SqlCommand(sql, conny);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
               



                liste.Add(new Organiser(reader.GetInt32(0), reader.GetString(1)));
            }

        
            reader.Close();

    
            conny.Close();
            return liste.ToArray();
        }

        public Organiser GetOrga(int id)
        {
            
            string sql = "select oid,oname from Organiser where oid = @id";
            SqlCommand com = new SqlCommand(sql, conny);
            conny.Open();
            com.Prepare();
            com.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = com.ExecuteReader();
           
         


                 Organiser org  =new Organiser(reader.GetInt32(0), reader.GetString(1));
            
            reader.Close();
            conny.Close();
            return org;
        }

        public Buchung[] AllBuchung()
        {
            List<Buchung> liste = new List<Buchung>();
            string sql = "select * from v_Buchungen";
            conny.Open();
            SqlCommand com = new SqlCommand(sql, conny);
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {


                liste.Add(new Buchung(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), reader.GetDateTime(5),reader.GetBoolean(6)));
            }
            reader.Close();
            conny.Close();
            return liste.ToArray();
        }

        public Buchung GetBuchung(string name)
        {
            
            string sql = "select * from v_Buchungen ";
            SqlCommand com = new SqlCommand(sql, conny);
            conny.Open();
            com.Prepare();
            com.Parameters.AddWithValue("@id", name);

            SqlDataReader reader = com.ExecuteReader();



            Buchung buchung = new Buchung(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), reader.GetDateTime(5), reader.GetBoolean(6));


            reader.Close();
            conny.Close();
            return buchung;
        }

        public Kunde Insertkunde(string name)
        {
            throw new NotImplementedException();
        }
    }
}
