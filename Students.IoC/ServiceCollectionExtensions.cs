using Microsoft.Extensions.DependencyInjection;
using Students.Application.Mappings;
using Students.Application.Services;
using Students.Core.Services;
using Students.DataAccess.Repositories;
using Students.DataAccess.UnitsOfWork;
using Students.Domain.Repositories;
using Students.Domain.UnitsOfWork;

namespace Students.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IGroupsRepository, GroupsRepositoryMock>();
            serviceCollection.AddSingleton<IStudentsRepository, StudentsRepositoryMock>();
            serviceCollection.AddScoped<IStudentsUnitOfWork, StudentsUnitOfWork>();
            serviceCollection.AddScoped<IStudentsService, StudentsService>();
            serviceCollection.AddScoped<IStudentsService, StudentsService>();
            serviceCollection.AddScoped<IGroupsService, GroupsService>();
            serviceCollection.AddAutoMapper(typeof(StudentProfile), typeof(GroupsProfile));
        }
    }
}