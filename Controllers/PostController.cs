﻿using ByteClubSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteClubSite.Controllers
{
    [Route("api/BlogPost")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PostController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.BlogPost.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var postFromDb = await _db.BlogPost.FirstOrDefaultAsync(u => u.Id == id);
            if (postFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.BlogPost.Remove(postFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete Successful" });
        }
    }
}
