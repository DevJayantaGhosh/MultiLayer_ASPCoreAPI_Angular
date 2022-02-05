using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RAWUserController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public RAWUserController(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        [HttpGet]
        [Route("/rawuser")]
        public async Task<IActionResult> GetAllRawUser()
        {
            List<RAWUser> list =_appDbContext.RawUsers.ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("/rawuser")]
        public async Task<IActionResult> AddRawUser(RAWUser user)
        {
           var res = await _appDbContext.RawUsers.AddAsync(user);
           return Ok(res);
        }
    }
}
