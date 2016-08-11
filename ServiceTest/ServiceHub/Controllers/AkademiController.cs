using Model;
using Repo;
using System;
using System.Web.Http;

namespace ServiceHub.Controllers
{
    [RoutePrefix("api/aakademi")]
    public class AkademiController : ApiController
    {
        UnitOfWork work = new UnitOfWork();
        [Route("getall")]
        public MobileResult GetStudents()
        {
            MobileResult result = new MobileResult();
            result.Result = true;
            try
            {
                var students = work.StudentRepository.Get();
                
                result.Data = students;
                result.Message = "Success";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("getbyid")]
        public MobileResult GetStudents(StudentModel model)
        {
            MobileResult result = new MobileResult();
            result.Result = true;
            try
            {
                var student = work.StudentRepository.GetByID(model.StudentID);
                
                result.Data = student;
                result.Message = "Success";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("insert")]
        public MobileResult InsertStudent(StudentModel model)
        {
            MobileResult result = new MobileResult();
            result.Result = true;
            try
            {
                work.StudentRepository.Insert(model);
                work.Save();
                result.Message = "New Student has been added";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("delete")]
        public MobileResult DeleteStudent(StudentModel model)
        {
            MobileResult result = new MobileResult();
            result.Result = true;
            try
            {
                //Logging
                work.StudentRepository.Delete(model.StudentID);
                work.Save();
                result.Message = "Selected Student has been deleted";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("update")]
        public MobileResult UpdateStudent(StudentModel model)
        {
            MobileResult result = new MobileResult();
            result.Result = true;
            try
            {
                var stud = GetStudents(model);
                var studModel = (StudentModel)stud.Data;
                studModel.Name = model.Name;
                studModel.Surname = model.Surname;
                studModel.isDeleted = model.isDeleted;
                studModel.BirthDate = model.BirthDate;
                studModel.RegistrationDate = model.RegistrationDate;
                work.StudentRepository.Update(studModel);
                work.Save();
                result.Message = "Selected Student has been updated";
            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}