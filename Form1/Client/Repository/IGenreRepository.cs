using Form1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form1.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Genre genre);
    }
}
