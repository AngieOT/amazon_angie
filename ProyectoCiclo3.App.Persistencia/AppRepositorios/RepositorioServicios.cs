using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    {
        List<Servicio> Servicios;
 
    public RepositorioServicios()
        {
            Servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen="Cali",destino= "Medellin",fecha= "2022-09-12",hora= "14 23",encomienda= "Ropa"},
                new Servicio{id=2,origen="Panama",destino= "Bogota",fecha= "2022-08-29",hora= "21 07",encomienda= "Electronico"},
                new Servicio{id=3,origen="Bogota",destino= "Manizales",fecha= "2022-07-12",hora= "08 12",encomienda= "Comida",}
 
            };
        }
 
        public IEnumerable<Servicio> GetAll() //retorna todo
        {
            return Servicios;
        }
 
        public Servicio GetWithId(int id){ //retorna una en especifico
            return Servicios.SingleOrDefault(b => b.id == id);
        }
    }
}