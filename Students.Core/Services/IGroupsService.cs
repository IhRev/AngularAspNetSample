using OneOf;
using OneOf.Types;
using Students.Core.DTO;

namespace Students.Core.Services
{
    public interface IGroupsService
    {
        Task<IEnumerable<GroupDTO>> GetAllAsync();

        Task<OneOf<Success>> AddAsync(GroupDTO entity);

        Task<OneOf<Success>> UpdateAsync(GroupDTO entity);
    }
}