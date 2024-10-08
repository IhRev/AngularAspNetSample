using System.ComponentModel.DataAnnotations;

namespace Students.Domain.Entities
{
    public class StudentEntity
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; } = string.Empty;

        public int Age { get; set; }

        public int GroupId { get; set; }

        public GroupEntity Group { get; set; } = null!;
    }
}