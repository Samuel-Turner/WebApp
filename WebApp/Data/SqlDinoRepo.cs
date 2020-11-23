using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public class SqlDinoRepo : IDinoRepo
    {
        private readonly DinoDbContext _context;
        

        public SqlDinoRepo(DinoDbContext context)
        {
            _context = context;
        }

        public void CreateDino(Dino dino)
        {
            if(dino == null)
            {
                throw new ArgumentNullException(nameof(dino));
            }
            _context.Dino.Add(dino);
        }

        public void DeleteDino(Dino dino)
        {
            if (dino == null)
            {
                throw new ArgumentNullException(nameof(dino));
            }
            _context.Dino.Remove(dino);
        }

        public IEnumerable<Dino> GetAllDinos()
        {
            return _context.Dino.ToList();
        }

        public Dino GetDinoById(int id)
        {
            return _context.Dino.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

        public void UpdateDino(int id, Dino dino)
        {
           
        }
    }
}
