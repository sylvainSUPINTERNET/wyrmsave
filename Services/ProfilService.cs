using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Model;
using Models.Schema;

namespace Services.ProfilService
{
    public class ProfilService
    {
        public async Task<Profil> getProfiles (int id) {
            var ctx = new WyrmSaveContext();
            Profil profiles = await ctx.Profil.FindAsync(id);
            return profiles;
        }
    }
}