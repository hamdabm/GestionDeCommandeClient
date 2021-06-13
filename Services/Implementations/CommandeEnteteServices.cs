
using Domain.Models;
using Persistence.GestionDeCommandeContext;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class CommandeEnteteService: IService<CommandeEntete>
    {
        private readonly DataContext _db;

        public CommandeEnteteService(DataContext DataContext)
        {
            _db = DataContext;
        }


    


        public CommandeEntete Add(CommandeEntete cde)
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

        public bool Delete(int id)
        {
           var cmde = GetById(id);

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

        public CommandeEntete GetById(int id)
        {
            return _db.CommandeEntetes.FirstOrDefault(c => c.IdCmdEnt == id);
        }

        public List<CommandeEntete> Get()
        {
               return _db.CommandeEntetes.ToList();
        }

        public CommandeEntete Update(CommandeEntete cmde)
        {
                

            try
            {
                  //_db.Entry(clt).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                var cmdeDb = _db.CommandeEntetes.FirstOrDefault(c => c.IdCmdEnt == cmde.IdCmdEnt);
                _db.Entry(cmdeDb).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                _db.Entry(cmde).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
