using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project
{
    public class Model
    {
        private int _accountId;
        private string _username;
        private string BASE_URL = "http://140.124.183.32:3000/";

        public int UID
        {
            get
            {
                return _accountId;
            }
        }

        public string UserName
        {
            get
            {
                return _username;
            }
        }

        public async Task<string> Registry(JObject jObject)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                response = await httpClient.PostAsync("http://140.124.183.32:3000/user/register", new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return message;
                    }
                    else
                    {
                        return "註冊失敗";
                    }
                }
                else
                {
                    return "註冊失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<string> SignIn(JObject jObject)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                response = await httpClient.PostAsync("http://140.124.183.32:3000/user/login", new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        _accountId = Int32.Parse(json["uid"].ToString());
                        _username = json["name"].ToString();
                        return message;
                    }
                    else
                    {
                        return "帳號或密碼錯誤";
                    }
                }
                else
                {
                    return "登入失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }

        }
        public void SignOut()
        {
            _accountId = -1;
            _username = "";
        }

        public async Task<string> EditProject(Project project)
        {
            return null;
        }

        public async Task<string> DeleteProject(int projectId)
        {
            return null;
        }

        public async Task<string> EditRequirement(Requirement requirement)
        {
            return null;
        }

        public async Task<string> DeleteRequirement(int RequirementId)
        {
            return null;
        }

        public async Task<string> AddProject(JObject jObject)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/new";
                string url = BASE_URL + METHOD;
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return message;
                    }
                    else
                    {
                        return "專案建立失敗";
                    }
                }
                else
                {
                    return "專案建立失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<HttpResponseMessage> GetProjectList()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getProjectListByUser/";
                string url = BASE_URL + METHOD + UID.ToString();
                response = await httpClient.GetAsync(url);
                return response;
            }
            catch (HttpRequestException)
            {
                response = new HttpResponseMessage();
                response.StatusCode = HttpStatusCode.RequestTimeout;
                return response;
            }
        }

        public async Task<HttpResponseMessage> GetUserListByProject(string projectId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getUserListByProject/";
                string url = BASE_URL + METHOD + projectId;
                response = await httpClient.GetAsync(url);
                return response;
            }
            catch (HttpRequestException)
            {
                response = new HttpResponseMessage();
                response.StatusCode = HttpStatusCode.RequestTimeout;
                return response;
            }
        }

        public async Task<HttpResponseMessage> AddUserToProject(JObject jObject)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/addUserToProject";
                string url = BASE_URL + METHOD;
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                return response;
            }
            catch (HttpRequestException)
            {
                response = new HttpResponseMessage();
                response.StatusCode = HttpStatusCode.RequestTimeout;
                return response;
            }
        }

        public async Task<HttpResponseMessage> GetRequirementByProject(string projectId)
        {
            
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/getRequirementByProject/";
                string url = BASE_URL + METHOD + projectId;
                return await httpClient.GetAsync(url);
            }
            catch (HttpRequestException)
            {
                response = new HttpResponseMessage();
                response.StatusCode = HttpStatusCode.RequestTimeout;
                return response;
            }
        }

        public async Task<string> AddRequirement(JObject jObject)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/new";
                string url = BASE_URL + METHOD;
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return message;
                    }
                    else
                    {
                        return "需求建立失敗";
                    }
                }
                else
                {
                    return "需求建立失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<HttpResponseMessage> GetMethod(String method)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/";
                string url = BASE_URL + METHOD + method;
                return await httpClient.GetAsync(url);
            }
            catch (HttpRequestException)
            {
                response = new HttpResponseMessage();
                response.StatusCode = HttpStatusCode.RequestTimeout;
                return response;
            }
        }

        public async Task<string> AddTestCase(JObject jObject)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/new";
                string url = BASE_URL + METHOD;
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return message;
                    }
                    else
                    {
                        return "需求建立失敗";
                    }
                }
                else
                {
                    return "需求建立失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<HttpResponseMessage> GetTestCaseListByRequirementId(int requirementId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/getTestCaseListByRequirementId/";
                string url = BASE_URL + METHOD + requirementId.ToString();
                response = await httpClient.GetAsync(url);
                return response;
            }
            catch (HttpRequestException)
            {
                response = new HttpResponseMessage();
                response.StatusCode = HttpStatusCode.RequestTimeout;
                return response;
            }
        }
    }
}
