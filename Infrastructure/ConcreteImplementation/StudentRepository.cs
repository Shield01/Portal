using Core.Models;
using Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.ConcreteImplementation
{
    class StudentRepository : BaseEntityRepository<Student>, IStudentRepository
    {
        public StudentRepository()
        {

        }
    }
}
