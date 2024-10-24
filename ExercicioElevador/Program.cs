using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioElevador
{
    class Program
    {

        static void Main(string[] args)
        {
            Predio p = new Predio(10);
            Elevador elevadorA = new Elevador();
            Elevador elevadorB = new Elevador();
            Elevador elevadorC = new Elevador();

            elevadorA.DefinirEstadoInicial();
            elevadorB.DefinirEstadoInicial();
            elevadorC.DefinirEstadoInicial();

            p.Elevadores.Add(elevadorA);
            //p.Elevadores.Add(elevadorB);
            //p.Elevadores.Add(elevadorC);
            //p.ExibirElevadores();
            Console.ReadKey();
        }
    }
}
