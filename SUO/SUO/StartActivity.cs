
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SUO
{
	[Activity (Label = "Расчёт поправок", MainLauncher = true, Icon = "@drawable/icon")]
	public class StartActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Start);
			Button button = FindViewById<Button> (Resource.Id.button1);			
			button.Click += delegate
			{
				Intent intent = new Intent(this, typeof(MainActivity));
				StartActivity(intent);
			};
			// Create your application here
		}
	}
}

