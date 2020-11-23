using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;

namespace WebApp.Controllers
{
    [Route("api/pigs")]
    [ApiController]
    public class DinoControllerOld : Controller
    {
        private readonly DinoDbContext _db;

        public DinoControllerOld(DinoDbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new {data =await _db.Dino.ToListAsync()});
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var D = await _db.Dino.FirstOrDefaultAsync(u => u.Id == id);
            if (D != null)
            {
                _db.Dino.Remove(D);
                await _db.SaveChangesAsync();
                return Json(new { success = true, message = "Delete successful" });
            }
            return Json(new { success = false, message = "Error while Deleting" });
        }
         
    }
}
