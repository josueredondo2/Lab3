using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Login
    {
        public int Id { get; set; }
        public string Pass { get; set; }




        public async Task<Login> Authenticate(string user, string pass)
        {
            using (HttpClient client = new HttpClient())
            {
                var uri = "";

                var json = JsonConvert.SerializeObject(new
                {
                    Id = user,
                    Pass = pass

                });

                var content = new StringContent(json, Encoding.UTF8, "aplication/json");
                HttpResponseMessage response = await client.PostAsync(uri, content).ConfigureAwait(false);
                string ans = await response.Content.ReadAsStringAsync();

                Login loginUser = JsonConvert.DeserializeObject<Login>(ans);
                return loginUser;
                    
        }
        }
    }
}
