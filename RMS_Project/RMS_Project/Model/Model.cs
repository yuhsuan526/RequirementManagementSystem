using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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

        public async Task<NormalAttribute[]> GetProjectPriorityType()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getProjectPriorityType/";
                string url = BASE_URL + METHOD;
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                JArray array = JArray.Parse(content);
                NormalAttribute[] priorities = new NormalAttribute[array.Count];
                for(int i = 0; i < array.Count; i++)
                {
                    JObject jObject = (JObject)array[i];
                    NormalAttribute priority = new NormalAttribute();
                    priority.ID = int.Parse(jObject["id"].ToString());
                    priority.Name = jObject["name"].ToString();
                    priorities[i] = priority;
                }
                return priorities;
            }
            catch (HttpRequestException)
            {
                throw new Exception("伺服器無回應");
            }
        }

        public async Task<string> DeleteUserFromProject(int projectId, int userId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            JObject jObject = new JObject();
            jObject["uid"] = userId;
            jObject["pid"] = projectId;
            try
            {
                const string METHOD = "project/deleteUserFromProject";
                string url = BASE_URL + METHOD;
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return "刪除成功";
                    }
                    else
                    {
                        throw new Exception("刪除失敗");
                    }
                }
                else
                {
                    throw new Exception("刪除失敗");
                }
            }
            catch (HttpRequestException)
            {
                throw new Exception("伺服器無回應");
            }
        }

        public async Task<string> EditProject(Project project)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                JObject jObject = new JObject();
                jObject["pid"] = project.ID;
                jObject["name"] = project.NAME;
                jObject["description"] = project.DESC;
                const string METHOD = "project/update";
                string url = BASE_URL + METHOD;
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return "專案修改成功";
                    }
                    else
                    {
                        return "專案修改失敗";
                    }
                }
                else
                {
                    return "專案修改失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<string> DeleteProject(int projectId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/delete/";
                string url = BASE_URL + METHOD + projectId;
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    //Console.WriteLine(json.ToString());
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return "刪除專案成功";
                    }
                    else
                    {
                        return "刪除專案失敗";
                    }
                }
                else
                {
                    return "刪除專案失敗";
                }
            }
            catch (HttpRequestException)
            {
                throw new Exception("伺服器無回應");
            }
        }

        public async Task<string> EditRequirement(Requirement requirement)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                JObject jObject = new JObject();
                jObject["id"] = requirement.ID;
                jObject["name"] = requirement.Name;
                jObject["description"] = requirement.Description;
                jObject["version"] = requirement.Version;
                jObject["memo"] = requirement.Memo;
                jObject["handler"] = requirement.Handler.ID;
                jObject["uid"] = requirement.Owner.ID;
                jObject["pid"] = requirement.ProjectID;
                jObject["requirement_type_id"] = requirement.Type.ID;
                jObject["priority_type_id"] = requirement.Priority.ID;
                jObject["status_type_id"] = requirement.Status.ID;
                const string METHOD = "requirement/update";
                string url = BASE_URL + METHOD;
                response = await httpClient.PostAsync(url, new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return "需求修改成功";
                    }
                    else
                    {
                        return "需求修改失敗";
                    }
                }
                else
                {
                    return "需求修改失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<string> DeleteRequirement(int RequirementId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/delete/";
                string url = BASE_URL + METHOD + RequirementId;
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    //Console.WriteLine(json.ToString());
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return "刪除需求成功";
                    }
                    else
                    {
                        return "刪除需求失敗";
                    }
                }
                else
                {
                    return "刪除需求失敗";
                }
            }
            catch (HttpRequestException)
            {
                throw new Exception("伺服器無回應");
            }
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

        public async Task<Project[]> GetManagedProjectListByUserId()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getManagerProjectListByUserId/";
                string url = BASE_URL + METHOD + UID.ToString();
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                JArray jsonArray = JArray.Parse(content);
                Project[] projects = new Project[jsonArray.Count];
                for (int i = 0; i < jsonArray.Count; i++)
                {
                    JObject jObject = jsonArray[i] as JObject;
                    projects[i] = new Project(int.Parse(jObject["id"].ToString()), jObject["name"].ToString(), jObject["description"].ToString());
                }

                return projects;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Project[]> GetOwnedProjectListByUserId()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getOwnerProjectListByUserId/";
                string url = BASE_URL + METHOD + UID.ToString();
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                JArray jsonArray = JArray.Parse(content);
                Project[] projects = new Project[jsonArray.Count];
                for (int i = 0; i < jsonArray.Count; i++)
                {
                    JObject jObject = jsonArray[i] as JObject;
                    projects[i] = new Project(int.Parse(jObject["id"].ToString()), jObject["name"].ToString(), jObject["description"].ToString());
                }

                return projects;
            }
            catch (Exception e)
            {
                throw e;
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

        public async Task<HttpResponseMessage> GetRequirementMethod(String method)
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
                        return "測試案例建立失敗";
                    }
                }
                else
                {
                    return "測試案例建立失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<string> EditTestCase(JObject jObject)
        {
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/update";
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
                        return "測試案例修改失敗";
                    }
                }
                else
                {
                    return "測試案例修改失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<string> DeleteTestCase(int tsetId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/delete/";
                string url = BASE_URL + METHOD + tsetId;
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    //Console.WriteLine(json.ToString());
                    string message = json["result"].ToString();
                    if (message == "success")
                    {
                        return "刪除測試成功";
                    }
                    else
                    {
                        return "刪除測試失敗";
                    }
                }
                else
                {
                    return "刪除測試失敗";
                }
            }
            catch (HttpRequestException)
            {
                throw new Exception("伺服器無回應");
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

        public async Task<HttpResponseMessage> GetTestCaseListByProjectId(int projectId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/getTestCaseListByProjectId/";
                string url = BASE_URL + METHOD + projectId.ToString();
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

        public async Task<JArray> GetRequirementToRequirementRelationByProjectId(int projectId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/getRtoRRelationByProjectId/";
                string url = BASE_URL + METHOD + projectId.ToString();
                response = await httpClient.GetAsync(url);
                 string content = await response.Content.ReadAsStringAsync();
                 if (response.StatusCode == HttpStatusCode.OK)
                 {
                     JObject json = JObject.Parse(content);
                     if (json["result"].ToString() =="success")
                     {
                         return (JArray)json["rr_relations"];
                     }
                     else
                     {
                         throw new Exception("資料取得失敗");
                     }
                 }
                 else
                 {
                     throw new Exception("資料取得失敗: " + response.ToString());
                 }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<JArray> GetRequirementToTestRelationByProjectId(int projectId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/getRtoTRelationByProjectId/";
                string url = BASE_URL + METHOD + projectId.ToString();
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    if (json["result"].ToString() == "success")
                    {
                        return (JArray)json["rt_relations"];
                    }
                    else
                    {
                        throw new Exception("資料取得失敗");
                    }
                }
                else
                {
                    throw new Exception("資料取得失敗: " + response.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<string> DeleteRequirementToRequirementRelationByProject(int projectId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/deleteRtoRRelationByProjectId/";
                string url = BASE_URL + METHOD + projectId.ToString();
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    if (json["result"].ToString() == "success")
                    {
                        return "刪除成功";
                    }
                    else
                    {
                        throw new Exception("刪除失敗");
                    }
                }
                else
                {
                    throw new Exception("刪除失敗: " + response.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<string> DeleteRequirementToTestRelationByProject(int projectId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/deleteRtoTRelationByProjectId/";
                string url = BASE_URL + METHOD + projectId.ToString();
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    if (json["result"].ToString() == "success")
                    {
                        return "刪除成功";
                    }
                    else
                    {
                        throw new Exception("刪除失敗");
                    }
                }
                else
                {
                    throw new Exception("刪除失敗: " + response.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<string> CreateRequirementToRequirementRelation(JObject jObject)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/newRtoRRelation";
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
                        throw new Exception("新增失敗");
                    }
                }
                else
                {
                    throw new Exception("新增失敗");
                }
            }
            catch
            {
                throw new Exception("伺服器無回應");
            }
        }

        public async Task<string> CreateRequirementToTestRelation(JObject jObject)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/newRtoTRelation";
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
                        throw new Exception("新增失敗");
                    }
                }
                else
                {
                    throw new Exception("新增失敗");
                }
            }
            catch (Exception)
            {
                throw new Exception("伺服器無回應");
            }
        }

        public async Task<HttpResponseMessage> GetTestCaseDetailInformationByTestCaseId(int testId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "test_case/getTestCaseByTestCaseId/";
                string url = BASE_URL + METHOD + testId.ToString();
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

        public async Task<HttpResponseMessage> GetRequirementByTestCaseId(int testId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "requirement/getRequirementListByTestCaseId/";
                string url = BASE_URL + METHOD + testId.ToString();
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

        /*********************** Comment ***************************/

        public async Task<string> AddCommentToRequirement(JObject jObject)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "comment/new";
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
                        return "評論失敗";
                    }
                }
                else
                {
                    return "評論失敗";
                }
            }
            catch (HttpRequestException)
            {
                return "伺服器無回應";
            }
        }

        public async Task<HttpResponseMessage> GetCommentByRequirement(int requirementId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "comment/getCommentListByRequirementId/";
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

        public async Task<JObject> GetPriority(int projectId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response;
            var httpClient = new HttpClient();
            try
            {
                const string METHOD = "project/getUserListByProject/";
                string url = BASE_URL + METHOD + projectId;
                response = await httpClient.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JObject json = JObject.Parse(content);
                    string message = json["result"].ToString();
                    JArray jsonArray = JArray.Parse(json["users"].ToString());
                    if (message == "success")
                    {
                        for (int i = 0; i < jsonArray.Count; i++)
                        {
                            JObject jObject = jsonArray[i] as JObject;
                            if (jObject["id"].ToString().Equals(_accountId.ToString()))
                            {
                                return jObject;
                            }
                        }
                    }
                }
                throw new Exception("未找到使用者");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
