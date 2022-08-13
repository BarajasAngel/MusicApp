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
                    setCanciones.Link = "http://drive.google.com/uc?export=view&id=1v3qORv_ybguLu_bdy_SqtmYJreQ_TxQg";
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
        public string Actualizar(Cancione oCanciones) {
            using (MusicAppDBContext db = new MusicAppDBContext())
            {
                var setCanciones = db.Canciones.Where(x => x.IdCancion == oCanciones.IdCancion).FirstOrDefault();
                if (setCanciones != null)
                {

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
                        db.Canciones.Update(setCanciones);
                        db.SaveChanges();
                        return "Cancion actualizada con exito";

                    }
                    catch (Exception)
                    {
                        return "Hubo un erro al agregar la canción";

                    }
                }
                return "Hubo un error al agregar la cancion";
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
        public List<Cancione> Buscar(string text) {
            using (MusicAppDBContext db = new MusicAppDBContext())
            {
                var busqueda = db.Canciones.Where(x => 
                x.Titulo.ToLower() == text.ToLower() ||
                x.Grupo.ToLower() == text.ToLower() ||
                x.Año.ToLower() == text.ToLower() ||
                x.Genero.ToLower() == text.ToLower()
                ).ToList();
                return busqueda;
            }
        }
    }
}
