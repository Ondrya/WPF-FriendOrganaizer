using System.ComponentModel.DataAnnotations;

namespace FriendOrganaizer.Model
{
    public class Friend
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }

        //public string FullName { 
        //    get => $"{LastName} {FirstName}"; 
        //}
    }
}
