﻿using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;
        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
               return _appDbContext.Pies.Include(x => x.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDbContext.Pies.Include(x => x.Category).Where(x => x.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById (int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(x => x.PieId == pieId);
        }
    }
}
