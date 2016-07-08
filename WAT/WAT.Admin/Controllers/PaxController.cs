using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WAT.Admin.Data;
using WAT.Admin.Entities;
using WAT.Admin.ValueObjects;

namespace WAT.Admin.Controllers
{
    public class PaxController : BaseApiController
    {
        [HttpGet]
        public ResponseData<List<Pax>> GetAll()
        {
            return (Execute(delegate () {
                List<Pax> paxes = null;
                using (var context = new WATContext())
                {
                    paxes = context.Paxes.ToList();
                }
                return paxes;
            }));
        }

        [HttpPost]
        public ResponseData<bool> Register(Pax pax)
        {
            return Execute(delegate ()
            {
                using (var context = new WATContext())
                {
                    context.Paxes.Add(pax);
                    context.SaveChanges();
                }
                return true;
            });
        }
    }
}
