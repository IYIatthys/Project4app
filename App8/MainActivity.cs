using Android.App;
using Android.Widget;
using Android.OS;

namespace App8
{
    [Activity(Label = "App8", MainLauncher = true)]
    public class MainActivity : Activity
    {

        DrawerLayout drawerLayout;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            mToolbar.Title = "Home";

            //Toolbar will now take on default Action Bar characteristics
            SetActionBar(mToolbar);
            //You can now use and reference the ActionBar
            ActionBar.Title = "Home";

            //Set hamburger menu
            ActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu_white_24dp);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
        }


        public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.actionmenu, menu);
            return base.OnCreateOptionsMenu(menu);
        }
    }
}

