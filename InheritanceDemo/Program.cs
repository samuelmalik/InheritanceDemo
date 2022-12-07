using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Oliverko Krška");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Oliverko Krška", true, "https://images.com/shoes");
            Console.WriteLine(imagePost1.ToString());
        }
    }
}
