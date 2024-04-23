using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pracCRUDapi.Model;

namespace pracCRUDapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public JsonResult Edit(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return new JsonResult(Ok(emp.Id));
        }

        [HttpGet]
        public JsonResult Get(int id)
        {
            var res = context.Employees.Find(id);
            if (res == null)
                return new JsonResult(NotFound());
            else
                return new JsonResult(Ok(res));
        }

        [HttpGet("/GetAll")]
        public JsonResult GetAll()
        {
            return new JsonResult(Ok(context.Employees.ToList()));
        }

        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var res = context.Employees.Find(id);
            if (res != null)
            {
                context.Employees.Remove(res);
                context.SaveChanges();
                return new JsonResult(Ok());
            }
            else
                return new JsonResult(NotFound());
        }

        [HttpPut]
        public JsonResult Put(int id , Employee emp)
        {
            var empDb = context.Employees.Find(id);
            if (empDb!=null)
            {
                empDb.Name = emp.Name;
                empDb.Project = emp.Project;
                empDb.Location = emp.Location;
                context.SaveChanges();
                return new JsonResult(Ok(emp.Id));
            }
            else
            {
                context.Employees.Add(emp);
                context.SaveChanges();
                return new JsonResult(Ok(id));
            }
        }
    }
}
