using System;

namespace diff_class_struct
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer()
        {

        }
    }
    internal class Program : Customer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
