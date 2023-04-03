using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelerAPI.Data;

namespace TravelerAPI.Models.Repositories
{
    public class TravelRepository : IServiceRepository<Travel>
    {

        private readonly AppDbContext context;
        public TravelRepository(AppDbContext _context)
        {
            context = _context;
        }

        public Travel Add(Travel entity)
        {
            var travel = context.Travels.Add(entity);
            context.SaveChanges();
            return travel.Entity;
        }

        public Travel DeleteById(int Id)
        {
            var travel = context.Travels.Find(Id);
            if (travel != null)
            {
                context.Travels.Remove(travel);
                return travel;
            }
            return null;
        }

        public Travel GetById(int Id)
        {
            var travel = context.Travels.Find(Id);
            return travel;
        }

        public IList<Travel> List()
        {
            var travels = context.Travels.ToList();
            return travels;
        }

        public Travel Update(int Id, Travel entity)
        {
            var travel = context.Travels.Find(Id);
            if (travel != null)
            {
                travel.TravelName = entity.TravelName;
                travel.TravelNo = entity.TravelNo;
                travel.TravelDesc = entity.TravelDesc;
                travel.From = entity.From;
                travel.To = entity.To;
                travel.Price = entity.Price;
                travel.IsActive = true;
                travel.IsDeleted = false;
                travel.CreationDate = DateTime.Now;
                travel.ModifacationDate = DateTime.Now;

                context.Travels.Update(travel);
                context.SaveChanges();

                return travel;

            }

            return null;
        }
    }
}
