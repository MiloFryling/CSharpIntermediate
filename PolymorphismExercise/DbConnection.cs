using System;

namespace PolymorphismExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        protected DbConnection(string connectionString)
        {
            Console.WriteLine("DbConnection constructor called");
            ConnectionString = connectionString ??
                               throw new NullReferenceException("Null connection string when creating DbConnection");
        }

        public abstract void Open();
        public abstract void Close();
    }
}