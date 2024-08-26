using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1049_Animais
{
    class Program
    {
        static void Main(string[] args)
        {

            String tipoAnimal;

            tipoAnimal = Console.ReadLine();

            if(tipoAnimal == "vertebrado")
            {
                tipoAnimal = Console.ReadLine();
                
                if (tipoAnimal == "ave")
                {
                    tipoAnimal = Console.ReadLine();
                    if (tipoAnimal == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    } 
                    else if (tipoAnimal == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                } 
                else if (tipoAnimal == "mamifero")
                {
                    tipoAnimal = Console.ReadLine();
                    if (tipoAnimal == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (tipoAnimal == "herbívoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            else if (tipoAnimal == "invertebrado")
            {
                tipoAnimal = Console.ReadLine();
                if (tipoAnimal == "inseto")
                {
                    tipoAnimal = Console.ReadLine();
                    if (tipoAnimal == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    } 
                    else if (tipoAnimal == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                } else if (tipoAnimal == "anelideo")
                {
                    tipoAnimal = Console.ReadLine();
                    if (tipoAnimal == "hematofago")
                    {
                        Console.WriteLine("sanguesuga");
                    } else if (tipoAnimal == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }

            }

        }
    }
}
