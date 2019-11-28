using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Interfaces
{
    public interface IStudentRepository
    {
         IEnumerable<Student> Students();
    }
}
