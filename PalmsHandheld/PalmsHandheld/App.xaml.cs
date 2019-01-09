using PalmsHandheld.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using Technoforte.PALMS.Entities.CustomSearchViews;
using Technoforte.PALMS.Entities.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace PalmsHandheld
{
	public partial class App : Application
	{

        public static NameValueCollection settings = null;
        public static bool isOnline = true;
        public static CultureInfo cultureInfo = CultureInfo.InvariantCulture;
        public static string messageBoxTitle = "Palms-WMS";
        public static string displayLabelTextForMovableLocation = "Moveable Location #";
        public static string language = "English";
        public static string userName = "";
        public static string version = "";
        public static int userID = 0;
        public static int? primaryCompanyID = 0;
        public static string primaryCompanyName = "";
        public static int? costBucketID = 0;
        public static string costBucketName = "";
        public static string wareHouseCode = "";
        public static int? warehouseID = 0;
        public static int? wareHousePrimaryCompanyID = 0;
        public static string iMU = "";
        public static bool isIMUScanInEveryScreen = false;
        public static LocationForHandheldCustomSearchViewEntity movableLocationEntityFromWareHouseLoad;
        public static Hashtable uiElement = new Hashtable();
        private static List<EnumerationEntity> lstEnumeration;
        private static decimal? cachedConversionFactor;
        private static string primaryCompanySeperatorValue;
        private static string primaryCompanySequenceValue;
        public static String[] menuList = new String[] { };

        public static string DatabaseLocation = string.Empty;

        public static string server = "http://192.168.43.251/PALMS/WebServices/";

        /*
        public static MobileServiceClient MobileService =
            new MobileServiceClient(
            "https://travelrecordappanshul.azurewebsites.net"
        );
        */
        public static User user = new User();

        public static string CorrectingResponse(string input)
        {
            input = input.Remove(0, 5);
            return input = input.Remove(input.Length - 1, 1);
        }

        public App ()
		{
			InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
