using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models;

namespace Models.Schema 
{
    [Table("Profil")]
    public class Profil: BaseEntity
    {
        public int ProfilSchemaId { get; set; }
        public string ProfilSchemaName { get; set; }
    }
}