using Business.Abstracs;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student entity)
        {
            _studentDal.Add(entity);
        }

        public void Delete(Student entity)
        {
            _studentDal.Delete(entity);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();

        }

        public Student GetById(int id)
        {
            return _studentDal.GetById(id);
        }

        public void Update(Student entity)
        {
            _studentDal.Update(entity);
        }
    }
}
