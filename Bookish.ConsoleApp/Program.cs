using System;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace Bookish.ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cs = @"Server=localhost;Database=bookish;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var users = con.Query<User>("SELECT * FROM users").ToList();

            users.ForEach(Console.WriteLine);
        }
    }
}
