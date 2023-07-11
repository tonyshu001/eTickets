﻿using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor actor); 
        Task DeleteAsync(int id);
    }
}
