using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public class MockDinoRepo : IDinoRepo
    {
        public void CreateDino(Dino dino)
        {
            throw new NotImplementedException();
        }

        public void DeleteDino(Dino dino)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dino> GetAllDinos()
        {
            Dino c = new Dino();
            Dino d = new Dino();
            Dino e = new Dino();

            c.Id = 1;
            c.Name = "Velociraptor";
            c.Period = "Cretaceous";
            c.Diet = "Carnivore";
            d.Id = 2;
            d.Name = "Utahraptor";
            d.Period = "Cretaceous";
            d.Diet = "Carnivore";
            e.Id = 3;
            e.Name = "Pyroraptor";
            e.Period = "Cretaceous";
            e.Diet = "Carnivore";
            var dinos = new List<Dino>
            {
                c,
                d,
                e
            };
            return dinos; 
        }

        public Dino GetDinoById(int id)
        {
            Dino d = new Dino();
            d.Id = id;
            d.Name = "";
            d.Period = "";
            d.Diet = "";
            return d;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateDino(int id, Dino dino)
        {
            throw new NotImplementedException();
        }
    };
}
