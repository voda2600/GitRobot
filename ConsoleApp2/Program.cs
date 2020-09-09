using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group() { GroupId = 1, GroupNum = "11-911" };
            group1[1] = new Student() { Name = "Ilnur",Marks = { 5, 5, 5, 5 } };
            group1[2] = new Student() { Name = "Danil" };
            Console.WriteLine(group1["Ilnur"]);
            Console.WriteLine(group1["Danil"]);
        }
    }
}
