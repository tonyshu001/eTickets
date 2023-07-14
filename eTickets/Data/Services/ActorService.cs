using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorService
    {
        private readonly AppDbContext _Context;

        public ActorService(AppDbContext context) : base(context)
        {
            _Context = context;
        }
       
    }
}
