using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPractico2b
{
    internal class Empleados
    {
        string id;
        string nombre;
        string apellidos;
        string direccion;
        string telefono;


        public Empleados(string id, string nombre, string apellidos, string direccion, string telefono)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Telefono = telefono;

        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }


        public override string ToString()
        {
            return ToString();
        }
        
        public string Estado(String id, String apellidos)
        {
            return Id = id;
            return Apellidos = apellidos;
 
        }


        public string Estado(String id, String nombre, String apellidos)
        {
            return this.Id = id;
            return this.Nombre = nombre;
            return this.Apellidos = apellidos;
        }
        

    }
}
