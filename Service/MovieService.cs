using maui_hybrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace maui_hybrid.Service
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient httpClient;
        public MovieService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public async Task<List<MovieModel>> GetMovieList()
        {
            return await httpClient.GetFromJsonAsync<List<MovieModel>>("api/movies") ??new List<MovieModel>();
        }
    }
}

