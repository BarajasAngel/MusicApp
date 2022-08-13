using System;
using MusicApp.Models;
namespace MusicApp.Clases
{
    public class CrudCLS
    {
        public string Agregar(Cancione oCanciones) {
            using (MusicAppDBContext db = new MusicAppDBContext())
            {
                Cancione setCanciones = new Cancione();

                if (oCanciones.Link == null)
                {
                    setCanciones.Link = "http://drive.google.com/uc?export=view&id=1ShG0RG7yN7pYCuIzMC8GgE-cIjhul9PO";
                }
                else
                {
                    setCanciones.Link = oCanciones.Link;
                }
                setCanciones.Titulo = oCanciones.Titulo;
                setCanciones.Grupo = oCanciones.Grupo;
                setCanciones.Año = oCanciones.Año;
                setCanciones.Genero = oCanciones.Genero;

                try
                {
                    db.Canciones.Add(setCanciones);
                    db.SaveChanges();
                    return "Cancion agregada con exito";
                    
                }
                catch (Exception)
                {
                    return "Hubo un erro al agregar la canción";
                    
                }
            }            
        }
        public List<Cancione> Mostrar() {
            using (MusicAppDBContext db = new MusicAppDBContext())
            {
                var lst = db.Canciones.ToList();
                return lst;
            }            
        }
        public string Eliminar(int id) {
            using (MusicAppDBContext db = new MusicAppDBContext())
            {
                var delCancion = db.Canciones.Where(x => x.IdCancion == id).FirstOrDefault();
                if (delCancion != null)
                {                    
                    try
                    {
                        db.Remove(delCancion);
                        db.SaveChanges();                        
                    }
                    catch (Exception)
                    {
                        return "No se pudo eliminar la canción.";
                    }
                }                
            }
            return "Canción removida con exito.";
        }
    }
}
