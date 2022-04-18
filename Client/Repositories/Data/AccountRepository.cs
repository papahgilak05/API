using API.Models;
using API.Models.ViewModels;
using Client.Base;
using Client.ViewModel;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client.Repositories.Data
{
    public class AccountRepository : GeneralRepository<Account, string>
    {
        /*private readonly Address address;
        private readonly HttpClient httpClient;
        private readonly string request;
        private readonly IHttpContextAccessor _contextAccessor;*/

        public AccountRepository(Address address, string request = "Accounts/") : base(address, request)
        {
            /*this.address = address;
            this.request = request;
            _contextAccessor = new HttpContextAccessor();
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(address.link)
            };*/
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", _contextAccessor.HttpContext.Session.GetString("JWToken"));
        }

        /*public async Task<List<RegisterVM>> GetAllProfile()
        {
            /// isi codingan kalian disini
        }*/

        public ResponseLoginVM Login(LoginVM loginVM)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");
            ResponseLoginVM result;
            using (var response = httpClient.PostAsync(request + "LoginJWT", content).Result)
            {
                string apiResponse = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<ResponseLoginVM>(apiResponse);
            }
            return result;
        }

        public async Task<IEnumerable<MasterDataVM>> GetMasterData()
        {
            List<MasterDataVM> entities = new List<MasterDataVM>();

            using (var response = await httpClient.GetAsync(request + "MasterDataJWT"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entities = JsonConvert.DeserializeObject<List<MasterDataVM>>(apiResponse);
            }
            return entities;
        }

        public Object Register(RegisterVM registerVM)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(registerVM), Encoding.UTF8, "application/json");
            object entities = new object();
            using (var response = httpClient.PostAsync(request + "Register", content).Result)
            {
                string apiResponse = response.Content.ReadAsStringAsync().Result;
                entities = JsonConvert.DeserializeObject(apiResponse);
            }
            return entities;
        }

        public async Task<JWTokenVM> Auth(LoginVM loginVM)
        {
            JWTokenVM token = null;

            StringContent content = new StringContent(JsonConvert.SerializeObject(loginVM), Encoding.UTF8, "application/json");
            var result = await httpClient.PostAsync(request + "Auth", content);

            string apiResponse = await result.Content.ReadAsStringAsync();
            token = JsonConvert.DeserializeObject<JWTokenVM>(apiResponse);

            return token;
        }

        /*public Object DeleteData()
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(), Encoding.UTF8, "application/json");
            object entities = new object();
            using (var response = httpClient.DeleteAsync(request + "Delete", content).Result)
            {
                string apiResponse = response.Content.ReadAsStringAsync();
                entities = JsonConvert.DeserializeObject<List<Account>>(apiResponse);
            }
            return entities;
        }*/

        /*public Object Update(MasterDataVM masterdataVM)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(masterdataVM), Encoding.UTF8, "application/json");
            object entities = new object();
            using (var response = httpClient.PostAsync(request + "Update/ " + masterdataVM.NIK, content).Result)
            {
                string apiResponse = response.Content.ReadAsStringAsync().Result;
                entities = JsonConvert.DeserializeObject<Object>(apiResponse);
            }
            return entities;
        }*/



    }
}
