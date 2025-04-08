using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaAObjetos
{
    public class Tatsugiri : Polemon      //tanto la clase pokemon como la clase heredada deben ser publicas, NO INTERNAL
    {
        public Tatsugiri() : base() 
        {
            pokemonName = "Tatsugiri";
            pokemonType = "Dragon";
            healthPoints = 65;
        }
    }
}
