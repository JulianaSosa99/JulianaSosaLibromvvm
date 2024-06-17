using JulianaSosaLibromvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulianaSosaLibromvvm.Services
{
    public  interface ILibroService
    //el objetivo es desacoplar el codigo
    {
        List<Libro> ObtenerLibro();
        


    }
}
