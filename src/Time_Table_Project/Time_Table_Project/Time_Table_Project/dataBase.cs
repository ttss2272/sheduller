using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Project
{
    class dataBase
    {
        public void add_date_firstDay(string date,int line,string first, string sec, string thi, string four, string fiv, string six, string sev,string eig,string nin,string ten,string ele)
        {
            string connect = "datasource = localhost; port = 3306; username = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlCommand sda = new MySqlCommand(@"insert into shedulling.tablelayout1 values
                    ('" + date + "','" + line + "','" + first + "','" + sec + "','" + thi + "','" + four + "','" + fiv + "', '" + six + "','" + sev + "','" + eig + "','" + nin + "', '" + ten + "', '" + ele + "')", conn);

            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = sda.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }

        public void add_data_secondDay(string date, int line,string first, string sec, string thi, string four, string fiv, string six, string sev, string eig, string nin, string ten, string ele)
        {
            string connect = "datasource = localhost; port = 3306; username = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlCommand sda = new MySqlCommand(@"insert into shedulling.tablelayout1 values
                    ('" + date + "','" + line + "','" + first + "','" + sec + "','" + thi + "','" + four + "','" + fiv + "', '" + six + "','" + sev + "','" + eig + "','" + nin + "', '" + ten + "', '" + ele + "')", conn);

            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = sda.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }

        public void update_first_table_data(string date,int line, string first, string sec, string thi, string four, string fiv, string six, string sev, string eig, string nin, string ten, string ele)
        {
            string connect = "datasource = localhost; port = 3306; username = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlCommand sda = new MySqlCommand(@"Update shedulling.tablelayout1 set date =
                    '" + date + "',line = '"+line+"',col1 = '" + first + "', col2 = '" + sec + "',col3 = '" + thi + "',col4 = '" + four + "',col5 = '" + fiv + "', col6 = '" + six + "',col7 = '" + sev + "',col8 = '" + eig + "',col9 = '" + nin+ "', col10 = '" + ten + "',col11 = '" + ele + "' where date = '"+date+"' AND line = '"+line+"'" , conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = sda.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }

        // prolem only in left side data updation :/
        public void update_secondtable_data(string date,int line, string first, string sec, string thi, string four, string fiv, string six, string sev, string eig, string nin, string ten, string ele)
        {
            string connect = "datasource = localhost; port = 3306; username = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlCommand sda = new MySqlCommand(@"Update shedulling.tablelayout1 set date =
                    '" + date + "',line = '" + line + "',col1 = '" + first + "', col2 = '" + sec + "',col3 = '" + thi + "',col4 = '" + four + "',col5 = '" + fiv + "', col6 = '" + six + "',col7 = '" + sev + "',col8 = '" + eig + "',col9 = '" + nin + "', col10 = '" + ten + "',col11 = '" + ele + "' where date = '"+date+"' AND line = '" + line + "'", conn);
            MySqlDataReader reader;
            try
            {
                conn.Open();

                reader = sda.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }

        Boolean found = false;
        Boolean date_of_Table2 = false;
        string s;

        public string reading_left_date(string date, int number_of_Line)
        {
            string connect = "datasource = localhost; port = 3306; username = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlCommand sda = new MySqlCommand(@"select * from shedulling.tablelayout1 where date = '" + date + "' AND line = '" + number_of_Line + "'", conn);
            MySqlDataReader reader;

            //int r = tableLayoutPanel1.RowCount;

            string a, b, c, d, e, f, g, h, i, j, k; // storing data from database
            try
            {
                conn.Open();
                reader = sda.ExecuteReader();
                while (reader.Read())
                {
                    a = reader.GetString(2);
                    b = reader.GetString(3);
                    c = reader.GetString(4);
                    d = reader.GetString(5);
                    e = reader.GetString(6);
                    f = reader.GetString(7);
                    g = reader.GetString(8);
                    h = reader.GetString(9);
                    i = reader.GetString(10);
                    j = reader.GetString(11);
                    k = reader.GetString(12);

                    s = a + " !" + b + " !" + c + " !" + d + " !" + e + " !" + f + "! " + g + " !" + h + "! " + i + " !" + j + " !" + k + " !";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return s;
        }
 

         public string reading_rightt_date(string date, int number_of_Line)
 {
     string connect = "datasource = localhost; port = 3306; username = root; password = ;";
     MySqlConnection conn = new MySqlConnection(connect);
     MySqlCommand sda = new MySqlCommand(@"select * from shedulling.tablelayout1 where date = '" + date + "' AND line = '" + number_of_Line + "'", conn);
     MySqlDataReader reader;

     //int r = tableLayoutPanel1.RowCount;

     int r = 0; // count rows
     //int cl = 11; // number of columns
     string a, b, c, d, e, f, g, h, i, j, k; // storing data from database
     try
     {
         conn.Open();
         reader = sda.ExecuteReader();
         while (reader.Read())
         {
             a = reader.GetString(2);
             b = reader.GetString(3);
             c = reader.GetString(4);
             d = reader.GetString(5);
             e = reader.GetString(6);
             f = reader.GetString(7);
             g = reader.GetString(8);
             h = reader.GetString(9);
             i = reader.GetString(10);
             j = reader.GetString(11);
             k = reader.GetString(12);

             s = a + " !" + b + " !" + c + " !" + d + " !" + e + " !" + f + "! " + g + " !" + h + "! " + i + " !" + j + " !" + k + " !";
         }
     }
     catch (Exception ex)
     {
         MessageBox.Show(ex.Message);
     }
     return s;
 }


        //searching for date of right day if it already exist in database
        public bool search_date_of_right_day(string date,int l)
        {
            // add Line integer as i did in finding dates in left date in db :)  
            string first_table;
            try
            {
                string connect = "datasource = localhost; port = 3306; username = root; password = ;";
                MySqlConnection conn = new MySqlConnection(connect);
                //Query to select Maximum ID from Database;
                MySqlCommand sda = new MySqlCommand(@"Select date,line from shedulling.tablelayout1", conn);
                MySqlDataReader reader;
                //openingthe Connection
                conn.Open();
                //executing the querey;
                reader = sda.ExecuteReader();
                //read data from database untill the read object has no data
                while (reader.Read())
                {
                    first_table = reader.GetString(0);
                    string ll = reader.GetString(1);
                    if (first_table == date && Convert.ToInt32(ll) == l)
                    {
                        found = true;
                        break;
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return found;
        }

        //searching for date of left day if it already exist in database
        public bool search_date_of_left_day(string date,int li)
        {
            string first_table;
            try
            {
                string connect = "datasource = localhost; port = 3306; username = root; password = ;";
                MySqlConnection conn = new MySqlConnection(connect);
                //Query to select Maximum ID from Database;
                MySqlCommand sda1 = new MySqlCommand(@"Select date,line from shedulling.tablelayout1", conn);
                MySqlDataReader reader;
                //openingthe Connection
                conn.Open();
                //executing the querey;
                reader = sda1.ExecuteReader();
                
                //read data from database untill the read object has no data
                while (reader.Read())
                {
                    first_table = reader.GetString(0);
                    string ll  = reader.GetString(1);
                    if (first_table == date && Convert.ToInt32(ll)==li )
                    {
                        date_of_Table2 = true;
                        break;
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return date_of_Table2;
        }

        // adding names to database
        public void adding_names()
        {
            string connect = "datasource = localhost; port = 3306; username = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlCommand sda = new MySqlCommand(@"insert into shedulling.names values
                    (' ',' Pablo  ',' Drop Offs','Juan','Brad','Kevin','bobalu','Brandon', 'Javier','Micheal','Pending')", conn);

            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = sda.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }

        // adding Dates to database
        public void adding_dates()
        {
            string connect = "datasource = localhost; port = 3306; username = root; password = ;";
            MySqlConnection conn = new MySqlConnection(connect);
            MySqlCommand sda = new MySqlCommand(@"insert into shedulling.dates values
                    (' 8:00
-----
8:30',' 9:00
-----
9:30',' 10:00
-----
10:30',' 11:00
-----
11:30',' 12:00
-----
12:30',' 1:00
-----
1:30',' 2:00
-----
2:30',' 3:00
-----
3:30', ' 4:00
-----
4:30',' 5:00
-----
5:30',' 6:00
-----
6:30')", conn);

            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = sda.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }


        
    }
}
