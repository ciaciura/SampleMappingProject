using ConsoleUserView = SampleMappingProject.Console.Models.Views.UserView;
using ConsoleUserModel = SampleMappingProject.Console.Models.Persistance.UserModel;
using CommonsTestBase = SampleMappingProject.Views.FrontViewMappingTestBase<SampleMappingProject.Console.Models.Views.UserView, SampleMappingProject.Console.Models.Persistance.UserModel>;

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
