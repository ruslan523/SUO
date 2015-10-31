
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
	[Activity (Label = "Ответы")]			
	public class AnswerActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Answer);

			string ZARYAD = Intent.GetStringExtra ("ZARYAD");
			int angle_on = Intent.GetIntExtra ("angle_on", 0);
			int Tz = Intent.GetIntExtra ("Tz", 0);
			int V0sum = Intent.GetIntExtra ("V0sum", 0);
			int H_op = Intent.GetIntExtra ("H_op", 0);
			int group_of_meteo_1 = Intent.GetIntExtra ("group_of_meteo_1", 0);
			int group_of_meteo_2 = Intent.GetIntExtra ("group_of_meteo_2", 0);
			int group_of_meteo_3 = Intent.GetIntExtra ("group_of_meteo_3", 0);

			Button button = FindViewById<Button> (Resource.Id.button1);		
			TextView tv1 = FindViewById<TextView> (Resource.Id.textView1);	
			TextView tv2 = FindViewById<TextView> (Resource.Id.textView2);	
			TextView tv3 = FindViewById<TextView> (Resource.Id.textView3);
			button.Click += (object sender, EventArgs e) => 
			{
				Intent intent = new Intent(this, typeof(StartActivity));
				StartActivity(intent);
			};

			// Create your application here
		}
	}
}

