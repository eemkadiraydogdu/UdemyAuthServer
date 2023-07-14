using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAuthServer.Core.UnitOfWork;

namespace UdemyAuthServer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        void IUnitOfWork.Commit()
        {
            _context.SaveChanges();
        }

        async Task IUnitOfWork.CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
