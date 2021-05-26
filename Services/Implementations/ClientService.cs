using Domain.Models;
using Persistence.GestionDeCommandeContext;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class ClientService : IService<Client>
    {
        private readonly DataContext _db;

        public ClientService(DataContext DataContext)
        {
            _db = DataContext;
        }

        public Client Add(Client clt)
        {
            try
            {
                _db.Clients.Add(clt);

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return clt;
        }

        public List<Client> Get()
        {
            return _db.Clients.ToList();
        }

        public Client GetById(int id)
        {
            return _db.Clients.FirstOrDefault(c => c.CltId == id);
        }

        public bool Delete(int id)
        {
            var clt = GetById(id);

            try
            {
                _db.Clients.Remove(clt);
                var stat = _db.SaveChanges();
                return stat > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Client Update(Client clt)
        {
            var cltDb = _db.Clients.FirstOrDefault(c => c.CltId == clt.CltId);

            try
            {
                cltDb = clt;

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }

            return clt;

        }
    }
}
