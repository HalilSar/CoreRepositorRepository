using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciProjeRepocitory.Models.Data
{
    public class OgrenciContext : DbContext
    {
        public OgrenciContext(DbContextOptions<OgrenciContext> options) : base(options)
        {

        }
        DbSet<Bolum> Bolumler { get; set; }
        DbSet<Ogrenci> Ogrenciler { get; set; }
        public class Ogrenci
        {
            [Key]
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int BolumId { get; set; }
            [ForeignKey("BolumId")]
            public Bolum Bolum { get; set; }
        }
        public class Bolum
        {
            [Key]
            public int Id { get; set; }
            public string Ad { get; set; }
            public ICollection<Ogrenci> Ogrenci { get; set; }
        }
    }
}
