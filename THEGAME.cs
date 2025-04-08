using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaAObjetos
{
    internal class THEGAME
    {
        static void Main(string[] args)
        {
            List<Polemon> availablePokamons = new List<Polemon>();

            List<Polemon> myPokemons = new List<Polemon>();

            Squirtle sq = new Squirtle();
            Darumaka dr = new Darumaka();
            Coalossal cl = new Coalossal();
            Tatsugiri ts = new Tatsugiri();


            availablePokamons.Add(dr);
            availablePokamons.Add(sq);
            availablePokamons.Add(cl);
            availablePokamons.Add(ts);

            bool running = true;


            while (running)
            {
                
                Random pokemonType = new Random();
                int newPokemon = pokemonType.Next(0, availablePokamons.Count());

                Console.WriteLine("Ha aparecido un " + availablePokamons[newPokemon].GetPokemonName() + " salvaje, que quieres hacer?");
                Console.WriteLine("Pulsa 0 para huir (cierra el programa) o cualquier otro numero para intentar capturarlo");

                int answer = int.Parse(Console.ReadLine());
                Random random = new Random();
                

                if (answer == 0 )
                {
                    Console.WriteLine("Has huido");
                    //running = false;
                }
                else
                {
                    float catchChance = random.Next(0, 100);
                    if (catchChance < 50 )
                    {
                        Console.WriteLine("El pokemon ha huido, MANCO");
                    }
                    else
                    {
                        Console.WriteLine("Has capturado al pokemon");
                        myPokemons.Add(availablePokamons[newPokemon]);
                    }
                }
                foreach(Polemon polemon in myPokemons)
                {
                    Console.WriteLine("Nombre del pokemon: " + polemon.GetPokemonName());
                    Console.WriteLine("Vida del pokemon: " + polemon.GetHealthPoints());
                    Console.WriteLine("Pokemon de tipo: " + polemon.GetPokemonType());
                    Console.WriteLine(polemon.GetPokemonName() + " dice " + polemon.PokemonName());
                }




            }


        }

        
    }
}
