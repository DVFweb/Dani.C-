using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dani.C_
{
    internal class Program
    {
        static void Main(string[] args)
        {   Address address = new Address(1, "Rua 10", "27A");
            DateTime data = DateTime.Now;
            Pessoa pessoa1 = new Pessoa(1, "Daniela", "dani@gmail.com", 40, address ,data , "2312-4578", "Curitiba");

            Console.WriteLine(pessoa1.ToString());

        }
    }
}
