using Android.App;
using Android.Widget;
using Android.OS;

namespace Hello
{
    [Activity(Label = "Hello", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Text tx = FindViewById<Text>("constTxt");
            //tx.text = "new value";

        }
    }
}

