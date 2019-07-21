using System;
using System.Windows;

namespace PolymorphismExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new SqlConnection("Connection string");

            db.Open();
            db.Close();
            Console.WriteLine("Connection string is: {0}", db.ConnectionString);

        }

        
    }
}
