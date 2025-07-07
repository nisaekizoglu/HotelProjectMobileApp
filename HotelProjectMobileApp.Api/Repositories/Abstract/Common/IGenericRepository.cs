﻿using System.Linq.Expressions;
using HotelProjectMobileApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelProjectMobileApp.Api.Repositories.Abstract;

    public interface IGenericRepository<TSource> where TSource : BaseModel
    {
        DbSet<TSource> Table {  get; }
        Task<int> SaveAsync();
        int Save();

        Task<List<TSource>?> GetAllAsync();
        Task<List<TSource>> GetAllAsync(Expression<Func<TSource, bool>> filter);
        Task<TSource?> GetSingleAsync(Expression<Func<TSource, bool>> filter);
        Task<int> GetCountAsync();
        Task<int> GetCountAsync(Expression<Func<TSource, bool>> filter);
        Task<bool> InsertAsync(TSource item);
        Task<bool> UpdateAsync(TSource item);
        Task<bool> RemoveAsync(int id);
        Task<bool> RemoveRangeAsync(List<int> ids);
    }

