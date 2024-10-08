using System.ComponentModel.DataAnnotations;

namespace Students.Core.DTO
{
    public class GroupDTO
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; } = string.Empty;
    }
}