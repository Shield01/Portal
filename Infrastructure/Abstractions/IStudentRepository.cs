using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Abstractions
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();

        Student Get(int id);

        Student Create(Student newStudent);

        Student Update(int id, Student newStudent);

        void Delete(int Id);

        Student EnableOrDisable(int id, bool isActive);

    }
}
