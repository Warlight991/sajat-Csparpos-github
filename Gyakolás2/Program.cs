using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakolás2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ora, indulas = 0;
            string visszaszamlalas;
            Console.Write("Hány óras visszaszámlálást tervezünk? ");
            ora = int.Parse(Console.ReadLine());
            indulas = ora;



            do
            {
                Console.WriteLine("Visszamlálás: " + ora);
                Console.Write("Fel kell függeszteni a visszaszamlálást (i/n)? ");
                visszaszamlalas = Console.ReadLine();
                if (visszaszamlalas == "n")
                {
                    ora--;
                }
                else
                {
                    indulas++;
                    ora--;
                }
            }
            while (ora > 0);



            
        


            Console.WriteLine($"A rakéta a visszaszámlálást követően ennyi óraval indult: {indulas}");
            
            
            
            
            Console.ReadKey();

        }
    }
}
