using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ApplicationContext context):base(context)
        {

        }
        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return Find(x => x.Followers >= count);
        }
    }
}
