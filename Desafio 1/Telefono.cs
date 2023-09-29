using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Telefono
    {
    // ======= CONSTRUCTOR ===================

        public Telefono (string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        public Telefono ()
        {

        }

    // ======== ATRIBUTOS ====================
        
        private string modelo;
        private string marca;
        private string numeroTelefono;
        private int codigoOperador;

    // ======== PROPIEDAD ====================

        public string Modelo 
        {
            get { return modelo; } 
        }

        public string Marca 
        {
            get { return marca; }
        }

        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }

        public int CodigoOperador 
        {
            get {return codigoOperador; }

            set
            {
                codigoOperador = value;
                switch (value)
                {
                    case 1:
                        Console.WriteLine("CLARO = 1: ");
                        break;

                    case 2:
                        Console.WriteLine("MOVISTAR = 2: ");
                        break;

                    case 3:
                        Console.WriteLine("PERSONAL = 3: ");
                        break;

                    default:
                        codigoOperador = 0;
                        Console.WriteLine("Ingreso un Numero incorrecto...");
                        break;
                }

            }
                
        }

// ============= METODOS ========================

        public string llamar ()
        {
            return "Realizando llamada...";
        }
 // ============ SOBRECARGA DE METODO ===========

        public string llamar (string contacto)
        {
            return "Llamando a ... " + contacto;
        }
    }
}
