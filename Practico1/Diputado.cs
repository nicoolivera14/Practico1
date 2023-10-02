using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Diputado : Legislador
    {
        public Diputado(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado) : base(partidoPolitico, departamentoQueRepresenta, numDespacho, nombre, apellido, edad, casado)
        {

        }
        public int NumAsientoCamaraBaja;

        public void setNumAsientoCamaraBaja(int numAsientoCamaraBaja)
        {
            this.NumAsientoCamaraBaja = numAsientoCamaraBaja;
        }

        public int getNumAsientoCamaraBaja()
        {
            return (this.NumAsientoCamaraBaja);
        }

        public override void PresentarPropuestaLegislativa(string propuesta)
        {
            Console.WriteLine($"{Nombre} {Apellido} presenta la propuesta legislativa en la Cámara Baja: {propuesta}");
        }

        public override void Votar(string votacion)
        {
            Console.WriteLine($"{Nombre} {Apellido} votó en la Cámara Baja: {votacion}");
        }

        public override void ParticiparDebate(string debate)
        {
            Console.WriteLine($"{Nombre} {Apellido} participa en el debate en la Cámara Baja sobre el tema: {debate}");
        }

        public override string GetCamara()
        {
            return "Diputados";
        }
    }
    
}
