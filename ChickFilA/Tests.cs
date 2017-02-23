using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace ChickFilA
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("menu_skip");
			app.Screenshot("Let's start by Tapping on the 'Menu Skip' Button");
			Thread.Sleep(8000);

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Then we Tapped on the 'Hamburger' icon");
			Thread.Sleep(8000);

			app.Tap("Menu");
			app.Screenshot("Next we Tapped on the 'Menu' Button");
			Thread.Sleep(8000);

			app.Tap("submenu_container");
			app.Screenshot("We Tapped on the 'Breakfast' menu");
			Thread.Sleep(8000);

			app.Tap("menu_item_container");
			app.Screenshot("Then we selected 'Chick-fil-A® Chicken Biscuit Meal'");
			Thread.Sleep(8000);

			app.Tap("sales_item_img");
			app.Screenshot("We Tapped on our item");
			Thread.Sleep(8000);
			
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");
			Thread.Sleep(8000);
			
			app.Back();
			app.Screenshot("Then we Tapped the 'Back' Button again");
			Thread.Sleep(8000);
			
			app.Back();
			app.Screenshot("We had to Tap the 'Back' Button one last time to return to the 'Hamburger' icon");
			Thread.Sleep(8000);
			
			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Then we Tapped on the 'Hamburger' icon");
			Thread.Sleep(8000);
			
			app.Tap("Find");
			app.Screenshot("Next we Tapped on the 'Find' Button");
			Thread.Sleep(8000);
			
			app.Tap("menu_search");
			app.Screenshot("We Tapped on the 'Search' Icon");
			Thread.Sleep(8000);
			
			app.EnterText("94111");
			app.Screenshot("Then we entered in our zip code, '94111'");
			Thread.Sleep(8000);
			
			app.PressEnter();
			app.Screenshot("We Tapped on the 'Enter' Button");
			Thread.Sleep(8000);
		}

	}
}
