using _DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DAL._Repositories._GenericRepository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly AirplaneSystemContext _context;

        public GenericRepo(DbSet<T> dbSet, AirplaneSystemContext context)
        {
            _dbSet = dbSet;
            _context = context;
        }

        #region GET 
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByID(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        #endregion

        #region ADD UPDATE 
        public async Task<T> AddElement(T item)
        {
            try
            {
                var result = await _dbSet.AddAsync(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        public async Task<T> UpdateElement(T item)
        {
            try
            {
                var result = _dbSet.Update(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        #endregion

        #region Delete
        public async Task<T> Delete(T item)
        {
            try
            {

                var result = _dbSet.Remove(item);
                _context.SaveChanges();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Task<T> DeleteById(int id)
        {
            try
            {
                var result = GetByID(id);
                _dbSet.Remove(result.Result);
                _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }
        #endregion
    }
}
