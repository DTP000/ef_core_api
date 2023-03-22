using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ef_ktr_api.Data
{
    public class AppDb : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product_Image> Product_Images { get; set; }
        public AppDb(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(k => k.IdCategory);

            modelBuilder.Entity<Product_Image>()
                 .HasKey(pi => new { pi.IdProduct, pi.IdImage });

            modelBuilder.Entity<Product_Image>()
                 .HasOne(p => p.Product)
                 .WithMany(i => i.Product_Images)
                 .HasForeignKey(k => k.IdProduct);

            modelBuilder.Entity<Product_Image>()
                .HasOne(p => p.Image)
                .WithMany(i => i.Product_Images)
                .HasForeignKey(k => k.IdImage);

        }


    }

    // entity define

    //base entity
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; } = DateTime.Now;
    }

    public class Category : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class Product : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Code { get; set; }
        public double Price { get; set; }
        public bool Continue { get; set; }
        public ICollection<Product_Image> Product_Images { get; set; }
        public int IdCategory { get; set; }
        public virtual Category Category { get; set; }
    }

    public class Image : BaseEntity
    {
        [Required]
        [StringLength(1000)] // để 1000 vì đường dẫn file ảnh có thể dài hơn 255 kí tự, ví dụ như link ảnh trên fb có kèm token nên link rất dài
        public string FileName { get; set; }
        public ICollection<Product_Image> Product_Images { get; set; }
    }

    public class Product_Image
    {
        public int IdProduct { get; set; }
        public int IdImage { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdate { get; set; } = DateTime.Now;

        public virtual Product Product { get; set; }
        public virtual Image Image { get; set; }
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
