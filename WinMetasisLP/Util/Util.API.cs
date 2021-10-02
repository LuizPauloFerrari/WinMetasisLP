using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WinMetasisLP.Entities.Base;

namespace WinMetasisLP.Util
{
    class UtilAPI
    {
        static readonly HttpClient client = new HttpClient();

        public static void ConfigureClient(string aURL)
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri(aURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Uri> CreateAsync<T>(T aObjeto) where T : IEntity
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                $"api/{aObjeto.GetType().Name}", aObjeto);
            response.EnsureSuccessStatusCode();

            aObjeto.Options.Status = StatusRecord.Updating;

            // return URI of the created resource.
            return response.Headers.Location;
        }
        
        public static async Task<T> CreateAndGetAsync<T>(T aObjeto) where T : IEntity
        {
            var url = await CreateAsync<T>(aObjeto);
            return await GetAsync<T>(aObjeto, url.PathAndQuery);
        }

        public static async Task<T> GetAsync<T>(T aObjeto, string path) where T : IEntity
        {
            if (!path.StartsWith("/api"))
            {
                path = $"/api/{aObjeto.GetType().Name}/{path}";
            }
            
            HttpResponseMessage response = await client.GetAsync(path);
            
            if (response.IsSuccessStatusCode)
            {
                aObjeto = await response.Content.ReadAsAsync<T>();
                aObjeto.Options.Found = true;
                aObjeto.Options.Status = StatusRecord.Updating;
            }
            else
            {
                aObjeto.Options.Found = false;
                aObjeto.Options.Status = StatusRecord.Inserting;
            }
            return aObjeto;
        }
       
        public static async Task<T> UpdateAsync<T>(T aObjeto, String path) where T : IEntity
        {
            if (!path.StartsWith("/api"))
            {
                path = $"/api/{aObjeto.GetType().Name}/{path}";
            }

            HttpResponseMessage response = await client.PutAsJsonAsync(
                path, aObjeto);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            aObjeto = await response.Content.ReadAsAsync<T>();
            return aObjeto;
        }

        public static async Task<HttpStatusCode> DeleteAsync<T>(T aObjeto, String path) where T : IEntity
        {
            if (!path.StartsWith("/api"))
            {
                path = $"/api/{aObjeto.GetType().Name}/{path}";
            }
            HttpResponseMessage response = await client.DeleteAsync(path);
            return response.StatusCode;
        }

        public static async Task<T> GetAllAsync<T>(string path)
        {
            HttpResponseMessage response = await client.GetAsync($"api/{path}/");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                return default;
            }
        }
        
        public static async Task<T> PostFilterAsync<T, T2>(T2 aObjeto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                $"api/{aObjeto}/Filter", aObjeto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                return default;
            }
        }
        
        public static async Task<EntityPage<T>> PostFilterAsyncPage<T, T2>(T2 aObjeto, decimal? aPage, decimal? aSize) 
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                $"api/{aObjeto}/FilterPage/?size={aSize}&page={aPage}", aObjeto);
            if (response.IsSuccessStatusCode)
            {
                var r = await response.Content.ReadAsAsync<EntityPage<T>>();
                if (r.PageNumber > r.PageCount)
                {
                    r.PageNumber = r.PageCount;
                    r = await PostFilterAsyncPage<T, T2>(aObjeto, 1, aSize);
                }
                return r;
            }
            else
            {
                return default;
            }
        }
        
        public static async Task<T> GetAllAsync<T>(Object aObjeto)
        {
            return await GetAllAsync<T>(aObjeto.GetType().Name);
        }
       
    }
}
