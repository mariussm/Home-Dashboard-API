using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Home_Dashboard_API.Controllers
{
    public class TaskController : ApiController
    {
        //public IEnumerable<Task> Post(String accessToken, String clientId, int ListId, String Title)
        public Boolean Post(String accessToken, String clientId, int ListId, String Title)
        {
            try
            {
                using (var client = new WebClient())
                {
                    // Set the header so it knows we are sending JSON.
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.Headers["X-Access-Token"] = accessToken;
                    client.Headers["X-Client-ID"] = clientId;

                    /*
                    Home_Dashboard_API.Models.Task task = new Home_Dashboard_API.Models.Task(Title, ListId);
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    String json = js.Serialize(task);*/
                    String json = "{\"list_id\":  " + ListId + ",\"title\":  \"" + Title + "\"}";
                    client.UploadString("https://a.wunderlist.com/api/v1/tasks", json);
                    return true;
                }
            } catch(Exception e) {
                    
            }
            
            return false;
        }


    }
}