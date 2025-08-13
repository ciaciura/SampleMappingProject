using System;
using System.Linq.Expressions;

namespace SampleMappingProject.Views
{
	public abstract class FrontViewBase<TView, TModel>
		where TView : FrontViewBase<TView, TModel>, new()
	{
		public abstract Expression<Func<TView, TModel>> ToModelCreate();
		public abstract Expression<Func<TView, TModel>> ToModelUpdate();
		public abstract TView FromModel(TModel model);

		// Static helpers for single-object conversion
		public static TModel CreateFunc(TView view) =>
			ToModelCreateStatic(view).Compile().Invoke(view);

		public static TModel UpdateFunc(TView view) =>
			ToModelUpdateStatic(view).Compile().Invoke(view);

		// Private helpers for static conversions
		private static Expression<Func<TView, TModel>> ToModelCreateStatic(TView view) =>
			view.ToModelCreate();

		private static Expression<Func<TView, TModel>> ToModelUpdateStatic(TView view) =>
			view.ToModelUpdate();
	}
}
