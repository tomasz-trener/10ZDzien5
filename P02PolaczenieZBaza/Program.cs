using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    class Program
    {
        static void Main(string[] args)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik= pzb.WyslijPolecenieSQL("select imie_t, nazwisko_t from trenerzy");

            foreach (var w in wynik)
                Console.WriteLine(string.Join(" ", w));

            Console.ReadKey();
        }
    }
}
