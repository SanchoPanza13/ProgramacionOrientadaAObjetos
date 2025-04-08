using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaAObjetos
{
    public class Polemon      //pokemon
    {
        //variables publicas que compartiran todos los polemons
        public string pokemonName;

        protected string pokemonType;    //Variables protegidas, solo accesibles para las herencias, no para todo el mundo, por eso son accesibles en el script main pero si en el de squirtle

        public int healthPoints;


        public Polemon()
        {

        }

        public Polemon(string pokemonName, string pokemonType, int healthPoints)        //Constructor con tres argumentos
        {
            this.pokemonName = pokemonName;

            this.pokemonType = pokemonType;

            this.healthPoints = healthPoints;

            PokemonName();
        }

        public string PokemonName ()                    //Metodo que devuelve el nombre del pokemon y lo muestra en pantalla
        {
            return pokemonName + " " + pokemonName + "!";
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
