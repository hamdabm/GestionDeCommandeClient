
using Domain.Models;
using Persistence.GestionDeCommandeContext;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementations
{
    public class CommandeLigneService: IService<CommandeLigne>
    {
        private readonly DataContext _db;

        public CommandeLigneService(DataContext DataContext)
        {
            _db = DataContext;
        }

        public CommandeLigne Add(CommandeLigne lig)
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

        public bool Delete(int id)
        {
           var lig = GetById(id);

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

        public CommandeLigne GetById(int id)
        {
            return _db.CommandeLignes.FirstOrDefault(c => c.IdCmdLigne == id);
        }

        public List<CommandeLigne> Get()
        {
            return _db.CommandeLignes.ToList();
        }

        public CommandeLigne Update(CommandeLigne lig)
        {
           
            try
            {
                  //_db.Entry(clt).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                var cmdligDb = _db.CommandeEntetes.FirstOrDefault(c => c.IdCmdEnt == lig.IdCmdEnt);
                _db.Entry(cmdligDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _db.Entry(lig).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
