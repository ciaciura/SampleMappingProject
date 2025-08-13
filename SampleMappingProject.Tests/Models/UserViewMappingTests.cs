using ConsoleUserView = SampleMappingProject.Commons.Models.Views.UserView;
using ConsoleUserModel = SampleMappingProject.Infrastructure.Models.Persistence.UserModel;
using CommonsTestBase = SampleMappingProject.Views.FrontViewMappingTestBase<SampleMappingProject.Commons.Models.Views.UserView, SampleMappingProject.Infrastructure.Models.Persistence.UserModel>;

namespace SampleMappingProject.Tests.Models
{
    public class UserViewMappingTests : CommonsTestBase
    {
        protected override ConsoleUserView GetSampleView()
        {
            return new ConsoleUserView
            {
                Id = 1,
                Username = "TestUser",
                Email = "test@example.com"
            };
        }
    }
}
