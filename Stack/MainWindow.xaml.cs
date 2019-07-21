using System;
using System.Windows;

namespace Stack
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var stack = new Stack();

            stack.Push(3);
            stack.Push("x");
            stack.Push(new NullReferenceException("this was pushed on the stack and popped"));


            MessageBox.Show(stack.Pop().ToString());
            MessageBox.Show(stack.Pop().ToString());
            MessageBox.Show(stack.Pop().ToString());
        }
    }
}
