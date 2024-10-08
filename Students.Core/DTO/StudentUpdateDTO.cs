using System.ComponentModel.DataAnnotations;

namespace Students.Core.DTO
{
    public class StudentUpdateDTO
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; } = string.Empty;

        public int GroupId { get; set; }
    }
}