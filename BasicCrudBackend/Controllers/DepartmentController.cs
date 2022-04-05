using BasicCrudBackend.Model;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BasicCrudBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IMongoCollection<Department> _departments;
        public DepartmentController(IConfiguration configuration)
        {
            var dbClient = new MongoClient(configuration.GetConnectionString("EmployeeAppCon"));
            var database = dbClient.GetDatabase("BasicCrud");
            _departments = database.GetCollection<Department>("Department");
        }
        [HttpGet]
        public JsonResult GetAllData()
        {
        
            var data = _departments.AsQueryable();
            return new JsonResult(data);
        }
    }
}
