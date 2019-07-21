using System;

namespace CSharpIntermediate
{
    public class Order
    {
        public void Foo()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}