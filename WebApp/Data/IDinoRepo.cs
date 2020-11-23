using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public interface IDinoRepo
    {
        bool SaveChanges();
        IEnumerable<Dino> GetAllDinos();
        Dino GetDinoById(int id);
        void CreateDino(Dino dino);
        void UpdateDino(int id,Dino dino);
        void DeleteDino(Dino dino);

    }
}
