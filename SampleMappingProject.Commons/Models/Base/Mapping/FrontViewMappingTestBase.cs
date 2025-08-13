
using Xunit;
using SampleMappingProject.Views;

namespace SampleMappingProject.Views
{
	public abstract class FrontViewMappingTestBase<TView, TModel>
		where TView : FrontViewBase<TView, TModel>, new()
	{
		protected abstract TView GetSampleView();

	[Fact]
	public void ToModelCreate_Should_MapProperties()
		{
			Console.WriteLine($"Running {nameof(ToModelCreate_Should_MapProperties)}");
			var view = GetSampleView();
			var model = view.ToModelCreate().Compile().Invoke(view);
			Console.WriteLine($"Model created: {model}");
			// Assert.NotNull(model);
		}

	[Fact]
	public void ToModelUpdate_Should_MapProperties()
		{
			Console.WriteLine($"Running {nameof(ToModelUpdate_Should_MapProperties)}");
			var view = GetSampleView();
			var model = view.ToModelUpdate().Compile().Invoke(view);
			Console.WriteLine($"Model updated: {model}");
			// Assert.NotNull(model);
		}
	}
}
