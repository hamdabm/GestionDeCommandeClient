
using Domain.Models;
using Persistence.GestionDeCommandeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class CommandeLigneService
    {
        private readonly DataContext _db;

        public CommandeLigneService(DataContext DataContext)
        {
            _db = DataContext;
        }

        public CommandeLigne AddCommandeLigne(CommandeLigne lig)
        {
            try
            {
                _db.CommandeLignes.Add(lig);

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return lig;
        }

        public List<CommandeLigne> GetCommandeLignes()
        {
            return _db.CommandeLignes.ToList();
        }

        public CommandeLigne GetCommandeLigneById(int id)
        {
            return _db.CommandeLignes.FirstOrDefault(c => c.IdCmdLigne == id);
        }

        public bool DeleteCommandeLigne(int id)
        {
            var lig = GetCommandeLigneById(id);

            try
            {
                _db.CommandeLignes.Remove(lig);
                var stat = _db.SaveChanges();
                return stat > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public CommandeLigne UpdateCommandeLigne(CommandeLigne lig)
        {
            var ligDb = _db.CommandeLignes.FirstOrDefault(c => c.IdCmdLigne == lig.IdCmdLigne);

            try
            {
                ligDb = lig;

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }

            return lig;

        }
    }
}
