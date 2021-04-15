
using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace BrandingSample.Droid
{
    [Activity(Icon = "@mipmap/icon", Theme = "@style/MainTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            System.Threading.Thread.Sleep(2000); //Let's wait awhile...
            StartActivity(typeof(MainActivity));
        }
    }
}