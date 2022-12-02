using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysql.Data.MysqlClient;
namespace CSharpMySQLConsoleApp
{
    class Program
    {
        static void Main(string[] args){
            try{
                string connectionString;
                connectionString="server=localhost;port=3306;uid=admin;pwdadmin123;database=management;SslMode=none;";
                MySqlConnection can = new MySqlConnection(connectionString);
                con.Open();
                Console.WriteLine("Connectin is" + con.State.ToString() + Environment.NewLine);

                con.Close();
            }catch(Mysql.Data.MysqlClient.MySqlException ex)
            {
                Console.WriteLine("Error: "+ ex.Message.ToString());
            }
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}