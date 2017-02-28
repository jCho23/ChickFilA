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
			app.Device.SetLocation(37.773972, -122.431297);
			app.Screenshot("App Launched");
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

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Then we Tapped on the 'Hamburger' icon");

			app.Tap("Menu");
			app.Screenshot("Next we Tapped on the 'Menu' Button");

			app.Tap("submenu_container");
			app.Screenshot("We Tapped on the 'Breakfast' menu");

			app.Tap("menu_item_container");
			app.Screenshot("Then we selected 'Chick-fil-A® Chicken Biscuit Meal'");

			app.Tap("sales_item_img");
			app.Screenshot("We Tapped on our item");
			
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Back();
			app.Screenshot("Then we Tapped the 'Back' Button again");
			
			app.Back();
			app.Screenshot("We had to Tap the 'Back' Button one last time to return to the 'Hamburger' icon");
			
			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Then we Tapped on the 'Hamburger' icon");

			app.Tap("Find");
			app.Screenshot("Next we Tapped on the 'Find' Button");

			app.Tap("menu_search");
			app.Screenshot("We Tapped on the 'Search' Icon");

			//app.EnterText("94111");
			//app.Screenshot("Then we entered in our zip code, '94111'");

			//app.PressEnter();
			//app.Screenshot("We Tapped on the 'Enter' Button");

		}

	}
}
