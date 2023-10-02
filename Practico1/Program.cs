using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Parlamento parlamento = new Parlamento();
            Console.WriteLine("prueba");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menú de Gestión del Parlamento");
                Console.WriteLine("1. Registrar Legislador");
                Console.WriteLine("2. Listar Cámaras");
                Console.WriteLine("3. Cantidad de Legisladores por Tipo");
                Console.WriteLine("4. Presentar Propuesta Legislativa");
                Console.WriteLine("5. Emitir Voto");
                Console.WriteLine("6. Participar en Debate");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarLegislador(parlamento);
                        break;
                    case "2":
                        parlamento.ListarCamaras();
                        break;
                    case "3":
                        parlamento.CantidadLegisladoresPorTipo();
                        break;
                    case "4":
                        PresentarPropuestaLegislativa(parlamento);
                        break;
                    case "5":
                        EmitirVoto(parlamento);
                        break;
                    case "6":
                        ParticiparDebate(parlamento);
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void RegistrarLegislador(Parlamento parlamento)
        {
            Console.Clear();
            Console.WriteLine("Registro de Legislador");
            Console.Write("Partido Politico: ");
            string partido = Console.ReadLine();
            Console.Write("Departamento que representa: ");
            string depto = Console.ReadLine();
            Console.Write("Número de despacho: ");
            int NumDespacho = int.Parse(Console.ReadLine());

            //DECLARAMOS LAS VARIABLES PARA PODER HACERLE VALIDACIONES
            string nombre = string.Empty;
            string apellido = string.Empty;
            int edad = 0;

            //VALIDACION PARA NOMBRE
            bool isValidNombre = false;
            while (!isValidNombre)
            {
                Console.Write("Nombre (solo letras): ");
                nombre = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nombre) && nombre.All(char.IsLetter))
                {
                    isValidNombre = true;
                }
                else
                {
                    Console.WriteLine("Nombre no válido. Ingrese un nombre válido.");
                }
            }
            //VALIDACION PARA APELLIDO

            bool isValidApellido = false;
            while (!isValidApellido)
            {
                Console.Write("Apellido (solo letras): ");
                apellido = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(apellido) && apellido.All(char.IsLetter))
                {
                    isValidApellido = true;
                }
                else
                {
                    Console.WriteLine("Apellido no válido. Ingrese un apellido válido.");
                }
            }

            //VALIDACION PARA LA EDAD
            bool isValidAge = false;
            while (!isValidAge)
            {
                Console.Write("Edad (mayor a 18 años): ");
                if (int.TryParse(Console.ReadLine(), out edad) && edad >= 18)
                {
                    isValidAge = true;
                }
                else
                {
                    Console.WriteLine("Edad no válida. Ingrese una edad válida.");
                }
            }

            Console.Write("Casado (true o false): ");
            bool casado = bool.Parse(Console.ReadLine());




            Console.WriteLine("Seleccione el tipo de legislador:");
            Console.WriteLine("1. Senador");
            Console.WriteLine("2. Diputado");
            Console.Write("Opción: ");
            string opcionTipo = Console.ReadLine();


            if (opcionTipo == "1")
            {
                Console.Write("Número de Asiento en el Senado: ");
                int numAsiento = int.Parse(Console.ReadLine());
                Senador senador = new Senador(partido, depto, NumDespacho, nombre, apellido, edad, casado);
               
                parlamento.RegistrarLegislador(senador);
            }
            else if (opcionTipo == "2")
            {
                Console.Write("Número de Asiento en la Cámara Baja: ");
                int numAsiento = int.Parse(Console.ReadLine());


                Diputado diputado = new Diputado(partido, depto, NumDespacho, nombre, apellido, edad, casado);
               
                parlamento.RegistrarLegislador(diputado);
            }
            else
            {
                Console.WriteLine("Opción no válida. El legislador no se ha registrado.");
            }

            Console.WriteLine("Legislador registrado exitosamente.");
        }

        static void PresentarPropuestaLegislativa(Parlamento parlamento)
        {
            Console.Clear();
            Console.WriteLine("Presentar Propuesta Legislativa");
            Console.Write("Nombre del legislador: ");
            string nombreLegislador = Console.ReadLine();

            var legislador = parlamento.BuscarLegisladorPorNombre(nombreLegislador);

            if (legislador != null)
            {
                Console.Write("Propuesta legislativa: ");
                string propuesta = Console.ReadLine();


                if (legislador is Senador senador)
                {
                    Console.WriteLine($"El Senador {senador.getNombre()} {senador.getApellido()} presenta la propuesta legislativa: {propuesta}");
                }
                else if (legislador is Diputado diputado)
                {
                    Console.WriteLine($"El Diputado {diputado.getNombre()} {diputado.getApellido()} presenta la propuesta legislativa: {propuesta}");
                }
                else
                {
                    Console.WriteLine($"No se encontró un legislador con el nombre '{nombreLegislador}'.");
                }
            }
            else
            {
                Console.WriteLine($"No se encontró un legislador con el nombre '{nombreLegislador}'.");
            }
        }

        static void EmitirVoto(Parlamento parlamento)
        {
            Console.Clear();
            Console.WriteLine("Emitir Voto");
            Console.Write("Nombre del legislador: ");
            string nombreLegislador = Console.ReadLine();

            var legislador = parlamento.BuscarLegisladorPorNombre(nombreLegislador);

            if (legislador != null)
            {
                Console.Write("Votación (A favor, En contra, Abstención): ");
                string votacion = Console.ReadLine();
                legislador.Votar(votacion);
                if (legislador is Senador senador)
                {
                    Console.WriteLine($"El Senador {senador.getNombre()} {senador.getApellido()} votó: {votacion}");
                }
                else if (legislador is Diputado diputado)
                {
                    Console.WriteLine($"El Diputado {diputado.getNombre()} {diputado.getApellido()} votó: {votacion}");
                }
                else
                {
                    Console.WriteLine($"No se encontró un legislador con el nombre '{nombreLegislador}'.");
                }
            }
            else
            {
                Console.WriteLine($"No se encontró un legislador con el nombre '{nombreLegislador}'.");
            }
        }

        static void ParticiparDebate(Parlamento parlamento)
        {
            Console.Clear();
            Console.WriteLine("Participar en Debate");
            Console.Write("Nombre del legislador: ");
            string nombreLegislador = Console.ReadLine();

            var legislador = parlamento.BuscarLegisladorPorNombre(nombreLegislador);

            if (legislador != null)
            {
                Console.Write("Tema del debate: ");
                string debate = Console.ReadLine();


                if (legislador is Senador senador)
                {
                    Console.WriteLine($"El Senador {senador.getNombre()} {senador.getApellido()} quiere participar en el debate sobre el tema: {debate}");
                }
                else if (legislador is Diputado diputado)
                {
                    Console.WriteLine($"El Diputado {diputado.getNombre()} {diputado.getApellido()} quiere participar en el debate sobre el tema: {debate}");
                }
                else
                {
                    Console.WriteLine($"No se encontró un legislador con el nombre '{nombreLegislador}'.");
                }
            }
            else
            {
                Console.WriteLine($"No se encontró un legislador con el nombre '{nombreLegislador}'.");
            }
        }

    }

}
