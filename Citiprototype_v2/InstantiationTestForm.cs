using System;

using Xamarin.Forms;

namespace Citiprototype_v2
{
	public class InstantiationTestForm : ContentPage
	{
		public InstantiationTestForm()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

