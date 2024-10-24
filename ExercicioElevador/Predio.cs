using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioElevador
{
    public class Predio
    {
        public int Andares;
        public List<Elevador> Elevadores;

        
        public Predio(int andares) { Andares = andares; }
        public void ExibirElevadores()
        {
            foreach (var elv in Elevadores)
            {
                Console.WriteLine($"Elevador {Elevadores.IndexOf(elv)}: {elv.Andar}º andar - {elv.Estado}");
            }
        }

        //Método para Subir
        public void Subir() { }

        //Método para Descer
        public void Descer() { }

    }
}
