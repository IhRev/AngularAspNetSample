using System.ComponentModel.DataAnnotations;

namespace Students.Core.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; } = string.Empty;

        public DateTimeOffset DateOfBirth { get; set; }

        public int GroupId { get; set; }
    }
}