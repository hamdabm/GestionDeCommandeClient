
using Domain.Models;
using Persistence.GestionDeCommandeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class CommandeEnteteService
    {
        private readonly DataContext _db;

        public CommandeEnteteService(DataContext DataContext)
        {
            _db = DataContext;
        }

        public CommandeEntete AddCommandeEntete(CommandeEntete cde)
        {
            try
            {
                _db.CommandeEntetes.Add(cde);

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return cde;
        }

        public List<CommandeEntete> GetCommandeEntetes()
        {
            return _db.CommandeEntetes.ToList();
        }

        public CommandeEntete GetCommandeEnteteById(int id)
        {
            return _db.CommandeEntetes.FirstOrDefault(c => c.IdCmdEnt == id);
        }

        public bool DeleteCommandeEntete(int id)
        {
            var cmde = GetCommandeEnteteById(id);

            try
            {
                _db.CommandeEntetes.Remove(cmde);
                var stat = _db.SaveChanges();
                return stat > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public CommandeEntete UpdateCommandeEntete(CommandeEntete cmde)
        {
            var cmdeDb = _db.CommandeEntetes.FirstOrDefault(c => c.IdCmdEnt == cmde.IdCmdEnt);

            try
            {
                cmdeDb = cmde;

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }

            return cmde;

        }
    }
}
