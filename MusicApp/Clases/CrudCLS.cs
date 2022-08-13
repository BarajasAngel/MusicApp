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

                setCanciones.Link = "http://drive.google.com/uc?export=view&id=1ShG0RG7yN7pYCuIzMC8GgE-cIjhul9PO";
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
    }
}
