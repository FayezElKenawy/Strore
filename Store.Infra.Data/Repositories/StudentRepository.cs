using Store.Domain.Interfaces;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infra.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private StoreDbContext _contxt;
        public StudentRepository(StoreDbContext context)
        {
            _contxt = context;
        }
        public IEnumerable<Student> Students()
        {
            return _contxt.Students;
        }
    }
}
