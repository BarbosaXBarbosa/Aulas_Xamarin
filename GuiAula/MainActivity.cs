using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace GuiAula
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main);
            Button BtnConverter = FindViewById<Button>(Resource.Id.btnConverter);
            EditText txtDolares = FindViewById<EditText>(Resource.Id.txtDolares);
            EditText txtReais = FindViewById<EditText>(Resource.Id.txtReais);
            double reais, dolares;

            BtnConverter.Click += delegate
            {
                try
                {
                    dolares = double.Parse(txtDolares.Text);
                    reais = dolares = 4.86;
                    txtReais.Text = reais.ToString();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                }
            };
        }
    }
}