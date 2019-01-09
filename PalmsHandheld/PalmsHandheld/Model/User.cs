using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;
using System.Threading;
using System;
using Technoforte.PALMS.Entities.Views;
using Technoforte.PALMS.WebServices;
using Palms.Handheld;
using Newtonsoft.Json;

namespace PalmsHandheld.Model
{
    public class User : INotifyPropertyChanged
    {
        private string id;

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return ConfirmPassword; }
            set
            {
                confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged !=null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public static async void Register(User user)
        {
            //TO DO : code for inserting entry to the db
            //await App.MobileService.GetTable<User>().InsertAsync(user);
        }

        public static async Task<bool> Login(string email, string password)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(email);
            bool isPasswordEmpty = string.IsNullOrEmpty(password);

            if (isEmailEmpty || isPasswordEmpty)
            {
                return false;
            }
            else
            {
                try
                {
                    WebServiceAccessObject<UserAuthenticationEntity> userAuthenticationForDeviceWAO = new WebServiceAccessObject<UserAuthenticationEntity>(new UserAuthenticationConfiguration(), App.server);
                    string response = userAuthenticationForDeviceWAO.Register(1500);
                    response = App.CorrectingResponse(response);

                    Registration registration = JsonConvert.DeserializeObject<Registration>(@response);

                    if (registration.pagingClientID > 0 && registration.error.errorCategory == ErrorCategory.SUCCESS)
                    {
                        UserAuthenticationEntity searchCriteria = new UserAuthenticationEntity();

                        searchCriteria.palmsUserLoginName = email;
                        searchCriteria.password = password;
                        searchCriteria.isTimezoneComparisonRequired = false;
                        searchCriteria.timeZone = TimeZone.CurrentTimeZone.StandardName;

                        response = userAuthenticationForDeviceWAO.SearchRecords(Convert.ToInt64(registration.pagingClientID), searchCriteria, 8, "", true);

                        userAuthenticationForDeviceWAO.Deregister(registration.pagingClientID);

                        response = App.CorrectingResponse(response);

                        SearchResultPage<UserAuthenticationEntity> searchResultPage = JsonConvert.DeserializeObject<SearchResultPage<UserAuthenticationEntity>>(response);

                        if (searchResultPage.error.errorCategory == ErrorCategory.SUCCESS && searchResultPage.totalRecords > 0)
                        {
                            App.userName = searchResultPage.pageData[0].palmsUserLoginName;
                            App.userID = (int)searchResultPage.pageData[0].palmsUserID;
                            App.primaryCompanyID = (int?)searchResultPage.pageData[0].primaryCompanyID;
                            App.warehouseID = (int?)searchResultPage.pageData[0].warehouseID;
                            App.version = searchResultPage.pageData[0].version;
                            App.uiElement = new System.Collections.Hashtable();
                            /*
                            App.ClearUiElements();
                            for (int UiElementRowCount = 0; UiElementRowCount < searchResultPage.totalRecords; UiElementRowCount++)
                            {
                                if (searchResultPage.pageData[(UiElementRowCount)].isScreen == false)
                                {
                                    App.setHashTableValue(searchResultPage.pageData[(UiElementRowCount)].palmsUIElementCode.ToLower().Trim(),
                                                  searchResultPage.pageData[(UiElementRowCount)].palmsUIElementID.ToString().Trim());
                                }
                            }
                            */
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return false;
                }
                catch(Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Error",ex.Message, "Ok");
                    return false;
                }
                /*
                User user = new User() { email = "a@b.c", Password = "pass" };
                App.user = user;
                if (user.Password == password)
                    return true;
                else
                    return false;
                
                /*
                var user = (await App.MobileService.GetTable<User>().Where(u => u.Email == email).ToListAsync()).FirstOrDefault();
                if (user != null)
                {
                    App.user = user;
                    if (user.Password == password)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
                */
            }
        }
    }
}
