using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IJokeService
    {
        Task<JokeDTO> GetRandomJokeAsync();

        // Una vez que consigas obtener un chiste aleatorio intenta agregar otras firmas de métodos para poder consumir otros endpoints que ofrezca el cliente de chistes.
    }
}
