using SampleMappingProject.Commons.Models.Views;
using SampleMappingProject.Persistence.Models;
using SampleMappingProject.Tests.Models.Base;
namespace SampleMappingProject.Tests.Models
{
    public class UserViewMappingTests : FrontViewMappingTestBase<UserView, UserModel>
    {
        protected override UserView GetSampleView()
        {
            return new UserView
            {
                Id = 1,
                Username = "TestUser",
                Email = "test@example.com"
            };
        }
    }
}
