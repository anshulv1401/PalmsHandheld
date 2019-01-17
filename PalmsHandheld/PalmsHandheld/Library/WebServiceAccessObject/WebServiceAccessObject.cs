using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Technoforte.PALMS.Entities;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace Palms.Handheld
{
     

   public class WebServiceAccessObject<E> where E : Entity
    {       
        private   String registerMethod = "Register";
        protected WebServiceAccessConfiguration<E> configuration = null;
        protected String qualifiedWebServiceName = "";
        private  String searchRecordsMethod = "SearchRecords";
        public  String server = ""; 
        private String deregisterMethod = "Deregister";
        private  String performActionMethod = "PerformAction";
	    private  String performActionWithDataMethod = "PerformActionWithData";

        public WebServiceAccessObject(WebServiceAccessConfiguration<E> configuration,String server)
        {
            this.configuration = configuration;
            this.qualifiedWebServiceName =  configuration.GetWebServicePath() + "/"+configuration.GetWebServiceName() + "/";
            this.server = server;
        }

        public string Register(int pageSize)
        {
            String service = GetRegisterMethod();

            String jsonParameters = "";
    		jsonParameters += "{" + "\"pageSize\":" + pageSize + "}";

            return CallService(service, jsonParameters);
        }

        public void Deregister(long pagingClientID)
        {
            string service = GetDeregisterMethod();
            string jsonParameters = "{";
            jsonParameters += "\"pagingClientID\":" + pagingClientID;
            jsonParameters += "}";

            CallService(service, jsonParameters);
        }
        
        public String GetRegisterMethod()
        {
            return server + qualifiedWebServiceName + registerMethod;
        }

        public String GetDeregisterMethod()
        {
            return server + qualifiedWebServiceName + deregisterMethod;
        }

        public String GetSearchRecordsMethod()
        {
            return server + qualifiedWebServiceName + searchRecordsMethod;
        }

        public String SearchRecords(long pagingClientID, E SearchCriterion, long offset, String sortKey, Boolean isSortAscending)
        {
            String service = GetSearchRecordsMethod();
            String jsonParameters = "{";
            jsonParameters += "\"pagingClientID\":" + pagingClientID;
            jsonParameters += "," + "\"searchCriteria\":" + JsonConvert.SerializeObject(SearchCriterion); 
            jsonParameters += "," + "\"offset\":" + offset;
            jsonParameters += "," + "\"sortKey\":\"" + (sortKey == null ? "" : sortKey) + "\"";
            jsonParameters += "," + "\"isSortAscending\":" + (isSortAscending ? "true" : "false");
            jsonParameters += "," + "\"aggregates\": null";
            jsonParameters += "}";

            string response = CallService(service, jsonParameters);
            return response;
        }

        public string PerformAction(List<E> data, string action)
        {

            string service = GetPerformActionWithDataMethod();
            string jsonParameters = "{";
            jsonParameters += "\"data\":" + JsonConvert.SerializeObject(data);
            jsonParameters += "," + "\"action\":\"" + action + "\"";
            jsonParameters += "}";

            string response = CallService(service, jsonParameters);
            return response;

        }

        public string GetPerformActionMethod()
        {
            return server +  qualifiedWebServiceName + performActionMethod;
        }

        public string GetPerformActionWithDataMethod()
        {
            return server + qualifiedWebServiceName + performActionWithDataMethod;
        }

        public String CallService(String service, String jsonParameters)
        {          
                WebRequest request = WebRequest.Create(service);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "POST";

                string postData = jsonParameters.Replace("\\\\/", "\\/");

                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                request.ContentType = "application/json; charset=utf-8";
                request.ContentLength = byteArray.Length;

                if (Cookies.cookie != string.Empty)
                {
                    request.Headers.Add("Cookie", Cookies.cookie);
                }
                
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                request.Timeout = Timeout.Infinite;
                WebResponse response = request.GetResponse();

                if (Cookies.cookie == string.Empty && response.Headers["Set-Cookie"] != null)
                {
                    Cookies.cookie = response.Headers["Set-Cookie"];
                }
              
                dataStream = response.GetResponseStream();  

                StreamReader reader = new StreamReader(dataStream);

                String responseFromServer = reader.ReadToEnd();

                reader.Close();
                dataStream.Close();
                response.Close();

                return responseFromServer;
                 
        }
    }    

   public static class Cookies
   {
       public static string cookie = string.Empty;  
   }
}
