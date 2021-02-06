using Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Movie : BaseModel
    {
        [Required(ErrorMessage ="gir")]
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        [NotMapped]
        public Genre Genre => (Genre)GenreId;
    }
}