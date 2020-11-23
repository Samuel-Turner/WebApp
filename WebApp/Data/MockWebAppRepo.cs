using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public class MockWebAppRepo : IWebAppRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            Command c = new Command();
            c.Id = 1;
            c.HowTo = "1";
            c.Line = "1";
            c.Platform = "1";
            Command d = new Command();
            d.Id = 2;
            d.HowTo = "2";
            d.Line = "2";
            d.Platform = "2";
            Command e = new Command();
            e.Id = 3;
            e.HowTo = "3";
            e.Line = "3";
            e.Platform = "3";
            var commands = new List<Command>
            {
                c,
                d,
                e
            };
            return commands; 
        }

        public Command GetCommandById(int id)
        {
            Command c = new Command();
            c.Id = id;
            c.HowTo = "";
            c.Line = "";
            c.Platform = "";
            return c;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(int id, Command cmd)
        {
            throw new NotImplementedException();
        }
    };
}
