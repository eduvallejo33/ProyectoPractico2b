using ProyectoPractico2b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GrupoTuristico
{
    string razonSocial;
    string cif;
    string direccion;
    string telefono;
    string id;
    string nombre;
    string apellidos;
    string estado;

    public GrupoTuristico()
    {
    }

    public GrupoTuristico(string razonSocial, string cif, string direccion, string telefono)
    {
        RazonSocial = razonSocial;
        Cif = cif;
        Direccion = direccion;
        Telefono = telefono;
        RazonSocial = razonSocial;
        Cif = cif;
        Direccion = direccion;
        Telefono = telefono;
    }

    public string RazonSocial { get => razonSocial; set => razonSocial = value; }
    public string Cif { get => cif; set => cif = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }

    public string Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    
    public string Estado(String id, String nombre, String apellidos)
    {
        return Id = id;
       
    }
    
    public override string ToString()
    {
        return ToString();
    }


    private static void Main(string[] args)
    {

        
        string[] nombreEmpleados = { "Manolito", "Pepito", "Josito", "Jaimito" };
        
        foreach (string i in nombreEmpleados)
        {
            Console.WriteLine(i);


        }
        
    }
}