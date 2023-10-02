using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Senador : Legislador
    {
        public Senador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado) : base(partidoPolitico, departamentoQueRepresenta, numDespacho, nombre, apellido, edad, casado)
        {

        }
        public int NumAsientoCamaraAlta;

        public void setNumAsientoCamaraAlta(int numAsientoCamaraAlta)
        {
            this.NumAsientoCamaraAlta = numAsientoCamaraAlta;
        }

        public int getNumAsientoCamaraAlta()
        {
            return (this.NumAsientoCamaraAlta);
        }

        public override void PresentarPropuestaLegislativa(string propuesta)
        {
            Console.WriteLine($"{Nombre} {Apellido} presenta la propuesta legislativa en el Senado: {propuesta}");
        }

        public override void Votar(string votacion)
        {
            Console.WriteLine($"{Nombre} {Apellido} votó en el Senado: {votacion}");
        }

        public override void ParticiparDebate(string debate)
        {
            Console.WriteLine($"{Nombre} {Apellido} participa en el debate en el Senado sobre el tema: {debate}");
        }

        public override string GetCamara()
        {
            return "Senado";
        }

    }
}
