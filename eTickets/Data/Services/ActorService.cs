using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _Context;

        public ActorService(AppDbContext context)
        {
            _Context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            await _Context.Actors.AddAsync(actor);
            await _Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _Context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            _Context.Actors.Remove(result);
            await _Context.SaveChangesAsync();
        }


        public async Task<Actor> UpdateAsync(int id, Actor actor)
        {
            _Context.Update(actor);
            await _Context.SaveChangesAsync();
            return actor;
        }
    }
}
