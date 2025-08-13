using System;
using System.Collections.Generic;
using SampleMappingProject.Commons.Models.Views;

namespace SampleMappingProject.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var userViews = new List<UserView>
			{
				new() { Username = "Alice", Email = "alice@example.com" },
				new() { Username = "Bob", Email = "bob@example.com" }
			};

			// Create models
			var newModels = userViews.ConvertAll(UserView.CreateFunc);
			foreach (var m in newModels)
				System.Console.WriteLine($"Created: {m.Username} - {m.Email}");

			// Update example
			userViews[0].Username = userViews[0].Username.Replace("Alice", "Alicia");
			var updatedModels = userViews.ConvertAll(UserView.UpdateFunc);
			foreach (var m in updatedModels)
				System.Console.WriteLine($"Updated: {m.Id} - {m.Username}");
		}
	}
}
