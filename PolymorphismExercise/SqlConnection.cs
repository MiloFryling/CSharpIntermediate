using System;

namespace PolymorphismExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("SQL constructor called");
        }

        public override void Open()
        {
            Console.WriteLine("Open SQL");
        }

        public override void Close()
        {
            Console.WriteLine("Close SQL");
        }
    }
}