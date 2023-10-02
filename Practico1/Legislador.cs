using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
     class Legislador
    {
        protected string PartidoPolitico;
        protected string DepartamentoQueRepresenta;
        protected int NumDespacho;
        protected string Nombre;
        protected string Apellido;
        protected int Edad;
        protected bool Casado;

        public Legislador (string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado)
        {
            PartidoPolitico = partidoPolitico;
            DepartamentoQueRepresenta = departamentoQueRepresenta;
            NumDespacho = numDespacho;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Casado = casado;
        }

        //Setters
        public void setPartidoPolitico(string partido)
        {
            this.PartidoPolitico = partido;
        }

        public void setDepartamentoQueRepresenta(string depto)
        {
            this.DepartamentoQueRepresenta = depto;
        }
        public void setNumDespacho(int NumDespacho)
        {
            this.NumDespacho = NumDespacho;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.Apellido = apellido;
        }

        public void setEdad(int edad)
        {
            this.Edad = edad;
        }

        public void setCasado(bool Casado)
        {
            this.Casado = Casado;
        }
        //Getters

        public string getPartidoPolitico()
        {
            return PartidoPolitico;
        }
        public string getDepartamentoQueRepresenta()
        {
            return DepartamentoQueRepresenta;
        }
        public int getNumDespacho()
        {
            return NumDespacho;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public string getApellido()
        {
            return Apellido;
        }
        public int getEdad()
        {
            return Edad;
        }
        public bool getCasado()
        {
            return Casado;
        }


        public virtual string GetCamara()
        {
            return "Desconocido";
        }

        public virtual void PresentarPropuestaLegislativa(string propuesta)
        {
            Console.WriteLine($"{Nombre} {Apellido} presenta la propuesta legislativa: {propuesta}");
        }

        public virtual void Votar(string votacion)
        {
            Console.WriteLine($"{Nombre} {Apellido} votó: {votacion}");
        }

        public virtual void ParticiparDebate(string debate)
        {
            Console.WriteLine($"{Nombre} {Apellido} participa en el debate sobre el tema: {debate}");
        }
    }
}

