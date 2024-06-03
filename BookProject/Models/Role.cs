using BookProject.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookProject.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        [NotMapped]
        public ICollection<User>? Users { get; set; }
    }
}