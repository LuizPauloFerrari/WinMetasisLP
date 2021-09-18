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
//using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace WinMetasisLP.Util
{
    class UtilAPI
    {
        static HttpClient client = new HttpClient();

        public static void ConfigureClient()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://localhost:44380/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Uri> CreateAsync<T>(T aObjeto, String aPath)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                $"api/{aPath}", aObjeto);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        public static async Task<T> GetAsync<T>(T aObjeto, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                aObjeto = await response.Content.ReadAsAsync<T>();
            }
            return aObjeto;
        }

        public static async Task<T> UpdateAsync<T>(T aObjeto, String aPath)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/{aPath}", aObjeto);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            aObjeto = await response.Content.ReadAsAsync<T>();
            return aObjeto;
        }

        public static async Task<HttpStatusCode> DeleteAsync(int id, String aPath)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/{aPath}/{id}");
            return response.StatusCode;
        }

        public static async Task<T> GetAllAsync<T>(T aObjeto, string path)
        {
            HttpResponseMessage response = await client.GetAsync($"api/{path}/");
            if (response.IsSuccessStatusCode)
            {
                aObjeto = await response.Content.ReadAsAsync<T>();
            }
            return aObjeto;
        }
       
    }
}
