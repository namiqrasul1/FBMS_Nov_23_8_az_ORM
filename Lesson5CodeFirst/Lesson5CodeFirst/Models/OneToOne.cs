using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson5CodeFirst.Models
{
    #region Default Convension
    //public class Role
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public User User { get; set; }
    //}

    //public class User
    //{
    //    //public int Id { get; set; }
    //    //public int ID { get; set; }
    //    //public int UserId { get; set; }
    //    //public int UserID { get; set; }

    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string? Password { get; set; }
    //    public bool? IsEmailConfirmed { get; set; }
    //    public int RoleId { get; set; }
    //    public Role Role { get; set; } // navigation property
    //}
    #endregion

    #region DataAnnotation

    //public class Role
    //{
    //    [Key, ForeignKey(nameof(Models.User))]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public User User { get; set; }
    //}

    //public class User
    //{
    //    //public int Id { get; set; }
    //    //public int ID { get; set; }
    //    //public int UserId { get; set; }
    //    //public int UserID { get; set; }
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public string? Password { get; set; }
    //    public bool? IsEmailConfirmed { get; set; }
    //    public Role Role { get; set; } // navigation property
    //}

    #endregion

    #region Fluent Api

    public class Role
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public Role Role { get; set; } // navigation property
    }
    #endregion

}
