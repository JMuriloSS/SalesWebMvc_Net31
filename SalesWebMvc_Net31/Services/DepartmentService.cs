using Microsoft.EntityFrameworkCore;
using SalesWebMvc_Net31.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc_Net31.Services
{
    public class DepartmentService
    {
        // Dependecy injection - Course
        private readonly SalesWebMvc_Net31Context _context;

        public DepartmentService(SalesWebMvc_Net31Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
