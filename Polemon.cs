using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaAObjetos
{
    internal class Polemon      //pokemon
    {
        //variables publicas que compartiran todos los polemons
        public string pokemonName;

        public string pokemonType;

        public int healthPoints;

        public Polemon(string pokemonName, string pokemonType, int healthPoints)        //Constructor con tres argumentos
        {
            this.pokemonName = pokemonName;

            this.pokemonType = pokemonType;

            this.healthPoints = healthPoints;

            PokemonName(pokemonName);
        }

        public void PokemonName (string pokemonName)                    //Metodo que devuelve el nombre del pokemon y lo muestra en pantalla
        {
            Console.WriteLine(pokemonName + pokemonName + "!");
        }

        //Getters de los argumentos
        public string GetPokemonName()
        {
            return pokemonName;
        }

        public string GetPokemonType()
        {
            return pokemonType;
        }

        public int GetHealthPoints()
        {
            return healthPoints;
        }


    }
}
