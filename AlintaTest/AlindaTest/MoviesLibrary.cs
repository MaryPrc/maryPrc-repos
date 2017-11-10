using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlintaTest
{
    public class MoviesLibrary
    {
        public List<Movie> Movies { get; set; }

        public MoviesLibrary()
        {
            Movies = new List<Movie>();
        }


        //GET request for getting the movies information from the API
        public async Task GetMoviesAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                Movies = await response.Content.ReadAsAsync<List<Movie>>();
            }
            
        }
    }
}
