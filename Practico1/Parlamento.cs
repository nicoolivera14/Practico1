using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Parlamento
    {
        private List<Legislador> legisladores = new List<Legislador>();

        public void RegistrarLegislador(Legislador legislador)
        {
            legisladores.Add(legislador);
        }

        public void ListarCamaras()
        {
            foreach (var legislador in legisladores)
            {
                Console.WriteLine($"{legislador.getNombre()} {legislador.getApellido()} trabaja en {legislador.GetCamara()} en el despacho {legislador.getNumDespacho()}");
            }
        }

        public void CantidadLegisladoresPorTipo()
        {
            int senadoresCount = 0;
            int diputadosCount = 0;

            Console.WriteLine("Lista de Senadores:");
            foreach (var legislador in legisladores)
            {
                if (legislador is Senador senador)
                {
                    senadoresCount++;
                    Console.WriteLine($"{senadoresCount}. {senador.getNombre()} {senador.getApellido()}");
                }
            }

            Console.WriteLine("\nLista de Diputados:");
            foreach (var legislador in legisladores)
            {
                if (legislador is Diputado diputado)
                {
                    diputadosCount++;
                    Console.WriteLine($"{diputadosCount}. {diputado.getNombre()} {diputado.getApellido()}");
                }
            }

            Console.WriteLine($"Cantidad de Senadores: {senadoresCount}");
            Console.WriteLine($"Cantidad de Diputados: {diputadosCount}");
        }


        public Legislador BuscarLegisladorPorNombre(string nombre)
        {
            return legisladores.Find(legislador => legislador.getNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }


    }
}
