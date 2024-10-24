using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioElevador
{

    public class Elevador
    {
        public int Andar;
        public string Estado;

        public Elevador() { }

        public Elevador(int andar, string estado) { Andar = ValidarAndar(andar); Estado = ValidarEstado(estado); }

        //Métado para setar estado inicial
        public void DefinirEstadoInicial()
        {
            Console.Write("Digite o andar inicial do elevador: ");
            int andar = int.Parse(Console.ReadLine());
            Andar = ValidarAndar(andar);
            
            Console.Write("Digite o estado inicial do elevador: ");
            string estado = Console.ReadLine();
            Estado = ValidarEstado(estado);
            
            ExibirElevador();
        }

        //Imprimir Estado do Elevador
        public void ExibirElevador()
        {
            Console.WriteLine($"\n-------> Elevador <------- \nAndar: {Andar} Estado: {Estado} \n");
        }


        public int ValidarAndar(int andar)
        {
            if (andar < 1 || andar > 10)
            {    
                throw new ArgumentOutOfRangeException($"Andar não é válido! ");
            }
            else
                return andar; 
        }

        public string ValidarEstado(string estado)
        {
            if (estado != "subindo" && estado != "descendo" && estado != "parado")
            {
                throw new ArgumentOutOfRangeException($"Andar não é válido! ");
            }
            else
                return estado;
        }
    }
}
