using Microsoft.AspNetCore.Mvc;
using COMSPECSBUSINESS;

namespace COMSPECAPI.Controllers
{
    [ApiController]
    [Route("api/Userid")]
    public class COMSPECController : ControllerBase
    {
        ModelGetServices Comp;
        ModelTransactionServices comps;
        public COMSPECController()
        {
            Comp = new ModelGetServices();
            comps = new ModelTransactionServices();

        }
        [HttpGet]
        public IEnumerable<COMSPECAPI.User> GetUser()
        {
            var user = Comp.GetAllUsers();
            List<COMSPECAPI.User> usser = new List<COMSPECAPI.User>();

            foreach (var model in user)
            {
                usser.Add(new COMSPECAPI.User { Userid = model.Userid, password = model.password });
            }
            return usser;
        }
        [HttpPost]
        public JsonResult AddModel(User request) {
            var result = comps.CreateUser(request.Userid, request.password);
            return new JsonResult(result);
        
        }
        [HttpPatch]
        public JsonResult UpdateModel(User request)
        {
            var result = comps.UpdateModel(request.Userid, request.password);
            return new JsonResult(result);

        }
        [HttpDelete]
        public JsonResult DeleteCOmp(COMSPECAPI.User request)
        {

            var Compdelete = new COMSPECSMODEL.User
            {
                Userid = request.Userid

            };

            var result = comps.DeleteModel(Compdelete);

            return new JsonResult(result);
        }
    }
}