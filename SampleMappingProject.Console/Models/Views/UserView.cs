using System;
using System.Linq.Expressions;
using SampleMappingProject.Views;
using SampleMappingProject.Console.Models.Persistance;

namespace SampleMappingProject.Console.Models.Views
{
    public class UserView : FrontViewBase<UserView, UserModel>
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public override Expression<Func<UserView, UserModel>> ToModelCreate() =>
            v => new UserModel
            {
                Username = v.Username,
                Email = v.Email
            };

        public override Expression<Func<UserView, UserModel>> ToModelUpdate() =>
            v => new UserModel
            {
                Id = v.Id,
                Username = v.Username,
                Email = v.Email
            };

        public override UserView FromModel(UserModel model) => new UserView
        {
            Id = model.Id,
            Username = model.Username,
            Email = model.Email
        };
    }
}
