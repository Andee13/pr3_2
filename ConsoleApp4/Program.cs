using System;
using System.IO;
using System.Text;

namespace ComsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello ";
            string world = "world";
            string helloWorld = hello + world;
            Console.WriteLine(helloWorld);

            world = "cat";
            String rat = world.Insert(0, "r");
            Console.WriteLine(rat);
            string newWorld = helloWorld.Replace(hello, "hi ");
            Console.WriteLine(newWorld);

            String afterremove = helloWorld.Remove(5);
            Console.WriteLine("afterRemove = " + afterremove);
            Console.WriteLine("equals = " + helloWorld.Equals(hello + world));

            String a = "abc";
            String b = "nbs abc";
            Console.WriteLine("The second symbol i s equal?"+ (a[1] == b[1]));
            
            Console.WriteLine(b.IndexOf(a));
        }

           
            
        
    }
}
