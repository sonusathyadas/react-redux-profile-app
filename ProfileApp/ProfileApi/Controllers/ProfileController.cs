using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProfileApi.Infrastructure;
using ProfileApi.Models;

namespace ProfileApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ILogger<ProfileController> _logger;
        private ProfileDbContext _dbContext;

        public ProfileController(ILogger<ProfileController> logger, ProfileDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IEnumerable<Profile>> GetProfiles()
        {           
            return await _dbContext.Profiles.ToListAsync();
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult<Profile>> AddProfile(Profile profile)
        {
            TryValidateModel(profile);
            if (ModelState.IsValid)
            {
                profile.CreatedTs = DateTime.Now;
                profile.Favorite = false;
                profile.UpdatedTs = DateTime.Now;
                profile.Id = _dbContext.Profiles.Max(s => s.Id) + 1;
                await _dbContext.Profiles.AddAsync(profile);
                await _dbContext.SaveChangesAsync();
                return Created("",profile);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
