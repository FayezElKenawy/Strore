using Store.Application.Interfaces;
using Store.Application.ViewModels;
using Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Application.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _Repo;
        public StudentService(IStudentRepository Repo)
        {
            _Repo = Repo;
        }
        public StudentViewModel GetStudents()
        {
            return new StudentViewModel()
            {
                Students = _Repo.Students()
            };
        }
    }
}
