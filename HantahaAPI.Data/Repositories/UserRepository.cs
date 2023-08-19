﻿using System;
using System.Linq.Expressions;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        private readonly DbSet<User> _dbSet;
        public UserRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<User>();
        }

        public async Task<User> GetByUsername(string username)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}

