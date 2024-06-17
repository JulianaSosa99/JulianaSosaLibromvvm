using JulianaSosaLibromvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianaSosaLibromvvm.Services
{
    public class LibroService : ILibroService
    {
        public List<Libro> ObtenerLibro()

        {
            return new List<Libro>
            {


            new Libro { Titulo = "La La Land", Autor = "Shonda Rimes" },
            new Libro { Titulo = "El rey Leon", Autor = "Dani Mora" },
            new Libro { Titulo = "Hunger Games", Autor = "Pri Zuñiga" },
            new Libro { Titulo = "Bridgenton", Autor = "Pepe Velez" },
            new Libro { Titulo = "Game of thrones", Autor = "Kamy Cardenas" }

            };


        }
    }
}
