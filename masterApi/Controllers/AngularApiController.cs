using masterApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace masterApi.Controllers
{
    //[Route("api/[controller]/[action]")]
    public class AngularApiController : ApiController
    {
        ApiDbContext _context = new ApiDbContext();
        [HttpGet]
        public async Task<IEnumerable<User>> getData()
        {
            var data = await _context.Users.Where(a=>a.isDeleted==false).ToListAsync();

            return data;
        }
        [HttpPost]
        public IHttpActionResult AddUser(User u)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    u.isDeleted = false;
                    _context.Users.Add(u);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return Ok();
        }
        [HttpGet]
        public HttpResponseMessage GetUserbyId(int Id)
        {
            var user = _context.Users.Where(a => a.Id == Id).FirstOrDefault();
            if (user == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
        }
        [HttpGet]
        public HttpResponseMessage deleteUser(int Id)
        {
            var user = _context.Users.Where(a => a.Id == Id).FirstOrDefault();
            if(user ==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);

            }
            else
            {
                user.isDeleted = true;
                _context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "success");
            }
        }
        //[HttpGet]
        //public async Task<IEnumerable<User>> getData()
        //{
        //    var data = await _context.Users.Where(a => a.isDeleted == false).ToListAsync();

        //    return data;
        //}

    }
}
