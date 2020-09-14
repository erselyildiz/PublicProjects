using System;
using System.ComponentModel.DataAnnotations;
using Entities.Entities;

namespace Entities.Concrete
{
    public class BaseModel : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public Guid AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public Guid? EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
        public bool isActive { get; set; } = true;
    }
}