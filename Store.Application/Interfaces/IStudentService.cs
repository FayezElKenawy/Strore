using Store.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Application.Interfaces
{
     public interface IStudentService
    {
        StudentViewModel GetStudents();
    }
}
