using System;

namespace PolymorphismExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Oracle constructor called");
        }

        public override void Open()
        {
            Console.WriteLine("Open Oracle");
        }

        public override void Close()
        {
            Console.WriteLine("Close Oracle");
        }
    }
}