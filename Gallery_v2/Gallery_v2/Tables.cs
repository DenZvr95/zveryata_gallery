using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Gallery_v2
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public Positions Position { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }
    }

    [Table("Positions")]
    public class Positions
    {
        [Key]
        [StringLength(50)]
        public string Position { get; set; }

        public override string ToString()
        {
            return Position;
        }
    }



    [Table("Pictures")]
    public class Pictures
    {
        [Key]
        public int PicId { get; set; }

        [StringLength(50)]
        public string InventoryNumber { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Authors Authors { get; set; }
        [Column(TypeName = "date")]
        public DateTime Year { get; set; }

        public int? GenreId { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genres PictureGenre { get; set; }

        public decimal Cost { get; set; }

        public Statuses Status { get; set; }

        public override string ToString()
        {
            return Name + " (" + Year.Year + ") " + " - " + Authors.Name + ".";
        }
    }

    [Table("Authors")]
    public class Authors
    {
        [Key]
        public int AuthorId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime Born { get; set; }
        [Column(TypeName = "date")]
        public DateTime Died { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [Table("Genres")]
    public class Genres
    {
        [Key]
        public int GenreId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [Table("Statuses")]
    public class Statuses
    {
        [Key]
        [StringLength(50)]
        public string Status { get; set; }

        public override string ToString()
        {
            return Status;
        }
    }



    [Table("Expositions")]
    public class Expositions
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime BeginData { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndData { get; set; }

        public override string ToString()
        {
            return Name + " - " + Address + " (" + BeginData.ToShortDateString() + " - " + EndData.ToShortDateString() + ").";
        }
    }

    [Table("ExpToPic")]
    public class ExpToPic
    {
        [Key, ForeignKey("Exposition")]
        [Column("ExpId", Order = 0)]
        public int IdExp { get; set; }
        public virtual Expositions Exposition { get; set; }

        [Key, ForeignKey("Picture")]
        [Column(Order = 1)]
        public int IdPic { get; set; }
        public virtual Pictures Picture { get; set; }

        public static explicit operator int(ExpToPic v)
        {
            if (v == null)
                return 0;
            return v.IdPic;
        }
    }

}
