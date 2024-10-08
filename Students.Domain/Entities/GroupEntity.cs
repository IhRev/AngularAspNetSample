using System.ComponentModel.DataAnnotations;

namespace Students.Domain.Entities
{
    public class GroupEntity
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<StudentEntity> Stuedents { get; set; } = null!;
    }
}