using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> Usuarios;
 
    public RepositorioUsuarios()
        {
            Usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Ana",apellidos= "Perez",direccion= "cll 12 45N12",telefono= "3207650934"},
                new Usuario{id=2,nombre="Felipe",apellidos= "Ortiz",direccion= "Cr 15b 12-07",telefono= "3007680923"},
                new Usuario{id=3,nombre="Juan",apellidos= "Carvajal",direccion= "cll 34N 3-02",telefono= "3139083312",}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll() //retorna todo
        {
            return Usuarios;
        }
 
        public Usuario GetWithId(int id){ //retorna una en especifico
            return Usuarios.SingleOrDefault(b => b.id == id);
        }
    }
}