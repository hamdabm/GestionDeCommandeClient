using Domain.Models;
using Persistence.GestionDeCommandeContext;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class ProduitService : IService<Produit>
    {
        private readonly DataContext _db;

        public ProduitService(DataContext DataContext)
        {
            _db = DataContext;
        }



        public Produit Add(Produit prod)
        {
            try
            {
                _db.Produits.Add(prod);

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return prod;
        }

        public bool Delete(int id)
        {
            var prd = GetById(id);

            try
            {
                _db.Produits.Remove(prd);
                var stat = _db.SaveChanges();
                return stat > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Produit GetById(int id)
        {
            try
            {
                return _db.Produits.FirstOrDefault(c => c.IdProd == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Produit> Get()
        {
            try
            {
                return _db.Produits.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Produit Update(Produit prod)
        {
            var prdDb = _db.Produits.FirstOrDefault(c => c.IdProd == prod.IdProd);

            try
            {
                prdDb = prod;

                _db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return prod;
        }
    }
}
