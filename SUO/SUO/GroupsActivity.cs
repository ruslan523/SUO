
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
	[Activity (Label = "Группы")]			
	public class GroupsActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Groups);

			string ZARYAD = Intent.GetStringExtra ("ZARYAD");
			int[] opornye_dalnosti = Intent.GetIntArrayExtra ("opornye_dalnosti");
			int angle_on = Intent.GetIntExtra ("angle_on", 0);
			int Tz = Intent.GetIntExtra ("Tz", 0);
			int V0sum = Intent.GetIntExtra ("V0sum", 0);
			int H_op = Intent.GetIntExtra ("H_op", 0);
			int[] number_of_meteo = Intent.GetIntArrayExtra ("number_of_meteo");

			TextView tv1 = FindViewById<TextView> (Resource.Id.textView1);
			TextView tv2 = FindViewById<TextView> (Resource.Id.textView2);
			TextView tv3 = FindViewById<TextView> (Resource.Id.textView3);
			EditText et1 = FindViewById<EditText> (Resource.Id.editText1);
			EditText et2 = FindViewById<EditText> (Resource.Id.editText2);
			EditText et3 = FindViewById<EditText> (Resource.Id.editText3);

			int[] groups_of_meteo = new int[3];

			bool bool1 = Int32.TryParse (et1.Text, out groups_of_meteo [0]);
			bool bool2 = Int32.TryParse (et2.Text, out groups_of_meteo [1]);
			bool bool3 = Int32.TryParse (et3.Text, out groups_of_meteo [2]);

			tv1.Text = number_of_meteo + ":";

			/*
			groups_of_meteo [0] = Convert.ToInt32 (et1.Text);
			groups_of_meteo [1] = Convert.ToInt32 (et2.Text);
			groups_of_meteo [2] = Convert.ToInt32 (et3.Text);
			*/

			Button button = FindViewById<Button> (Resource.Id.button1);			
			button.Click += (object sender, EventArgs e) => 
			{
				Intent intent = new Intent(this, typeof(AnswerActivity));
				/*
				intent.PutExtra("ZARYAD", ZARYAD);
				intent.PutExtra("opornye_dalnosti", opornye_dalnosti);
				intent.PutExtra("angle_on", angle_on);
				intent.PutExtra("Tz", Tz);
				intent.PutExtra("V0сум", V0sum);
				intent.PutExtra("H_op", H_op);
				intent.PutExtra("groups_of_meteo", groups_of_meteo);
				*/

				StartActivity(intent);
			};

			// Create your application here
		}
	}
}