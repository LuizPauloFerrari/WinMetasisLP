using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WinMetasisLP.Entities.Base;

namespace WinMetasisLP.Util
{
    class UtilAPI
    {
        static HttpClient client = new HttpClient();

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

            (aObjeto as IEntity).Options.Status = StatusRecord.Updating;

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
                (aObjeto as IEntity).Options.Found = true;
                (aObjeto as IEntity).Options.Status = StatusRecord.Updating;
            }
            else
            {
                (aObjeto as IEntity).Options.Found = false;
                (aObjeto as IEntity).Options.Status = StatusRecord.Inserting;
            }
            return aObjeto;
        }
        
        //public static T GetSync<T>(T aObjeto, string path) where T : IEntity
        //{
            
        //}

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
                return default(T);
            }
        }
        
        public static async Task<T> PostFilterAsync<T, T2>(T2 aObjeto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                $"api/{aObjeto.ToString()}/Filter", aObjeto);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                return default(T);
            }
        }
        
        public static async Task<T> GetAllAsync<T>(Object aObjeto)
        {
            return await GetAllAsync<T>(aObjeto.GetType().Name);
        }
       
    }
}
