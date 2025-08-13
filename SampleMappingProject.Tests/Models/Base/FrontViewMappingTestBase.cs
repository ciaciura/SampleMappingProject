
using SampleMappingProject.Views;

namespace SampleMappingProject.Tests.Models.Base
{
	public abstract class FrontViewMappingTestBase<TView, TModel>
		where TView : FrontViewBase<TView, TModel>, new()
	{
		protected abstract TView GetSampleView();

	[Fact]
	public void ToModelCreate_Should_MapProperties()
		{
			var view = GetSampleView();
			var model = view.ToModelCreate().Compile().Invoke(view);
			Assert.NotNull(model);
		}

	[Fact]
	public void ToModelUpdate_Should_MapProperties()
		{
			var view = GetSampleView();
			var model = view.ToModelUpdate().Compile().Invoke(view);
			Assert.NotNull(model);
		}
	}
}
