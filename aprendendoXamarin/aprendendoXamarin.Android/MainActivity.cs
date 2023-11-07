using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android;

namespace ListViewDemo
{
    [Activity(Label = "ListViewDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            EmployeeList employeeList = new EmployeeList();
            var employees = employeeList.GetEmployees(20);

            ListView lvEmployees = FindViewById<ListView>(id: Resource.Id.lvEmployee);
            EmployeeAdapter adapter = new EmployeeAdapter(employees);
            lvEmployees.Adapter = adapter;
        }

    }
}