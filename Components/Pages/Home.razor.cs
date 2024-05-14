
using maui_hybrid.Models;
using maui_hybrid.Service;
using Microsoft.AspNetCore.Components;

namespace maui_hybrid.Components.Pages
{
    public partial class Home 
    {
        [Inject]
        public IMovieService movieService { get; set; }

        public List<MovieModel> movies = new List<MovieModel>();
		private int currentPage = 1;
		private int pageSize = 5; // Number of items per page
		private bool IsFirstPage => currentPage == 1;
		private bool IsLastPage => currentPage == TotalPages;


		protected override async Task OnParametersSetAsync()
        {
            movies = (await movieService.GetMovieList()).ToList();
			await base.OnParametersSetAsync();
		}

		

		private int TotalPages => (int)Math.Ceiling((double)movies.Count / pageSize);

		private void PreviousPage()
		{
			if (!IsFirstPage)
			{
				currentPage--;
			}
		}

		private void NextPage()
		{
			if (!IsLastPage)
			{
				currentPage++;
			}
		}



	}
}