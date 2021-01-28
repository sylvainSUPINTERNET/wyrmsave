using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Schema;
using Models.Model;

using Services.ProfilService;

namespace Controller
{

    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Route("api/[controller]")]
    public class ProfilController : ControllerBase 
    {
        private readonly ProfilService _profileService = new ProfilService(); // Injection dep

        public ProfilController() {}

        [HttpGet]
        public async Task<Profil> GetProfils(int id)
        {
             var profils = await _profileService.getProfiles(id);            
            return profils;
        }
    }
}