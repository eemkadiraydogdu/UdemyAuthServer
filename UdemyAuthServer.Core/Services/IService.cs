using SharedLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.Services
{
    public interface IService<T, TDto> where T : class where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);
        Task<Response<IEnumerable<TDto>>> GetAllAsync();
        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<T, bool>> predicate);
        Task<Response<TDto>> AddAsync(T entity);
        Task<Response<NoContentDto>>  Remove(T entity);
        Task<Response<NoContentDto>> Update(T entity);
    }
}
