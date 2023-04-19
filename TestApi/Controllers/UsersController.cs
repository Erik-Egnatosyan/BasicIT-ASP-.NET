using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("222222")]
        public int GetAll()
        {
            return 111;
        }
        [HttpGet("333333")]
        public int GetAll2()
        {
            return 222;
        }





        [HttpPost("PostAllData")]
        public ResponseModel PostAll(TestModel testModel)//testmodel @ndunox parametreri model
        //ResponsModel veradardzvox parametreri model
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel.Id = testModel.Name1 + 100;
            responseModel.Name = testModel.Name2 + "testing";
            responseModel.Description = testModel.Name2 + "testing description";
            return responseModel;
        }
    }
}
