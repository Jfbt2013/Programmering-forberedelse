using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDBSetup
{
    public class SqliteDataAccess
    {
        // Lav en Query (forespørgsel) om alle attributter fra "Person"
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("SELECT * FROM PERSON", new DynamicParameters());
                return output.ToList();
            }
        }

        // Gem en ny person i tabllen "Person"
        public static void SavePerson(PersonModel Person)
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO PERSON (Name, Age) VALUES (@name, @age)", Person);
            }
        }

        // Opret forbindelse til Databasen, opsat i App.config
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
