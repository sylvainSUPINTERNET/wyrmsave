using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Models;

namespace Models.Schema 
{
    [Table("Profil")]
    public class Profil: BaseEntity
    {
        public int ProfilSchemaId { get; set; }
        public string ProfilSchemaName { get; set; }

        public static implicit operator Task<object>(Profil v)
        {
            throw new NotImplementedException();
        }
    }
}