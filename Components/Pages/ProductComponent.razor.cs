using maui_hybrid.Models;
using maui_hybrid.Service;
using Microsoft.AspNetCore.Components;

namespace maui_hybrid.Components.Pages
{
	public partial class ProductComponent
	{
		[Inject]
		public IProductService productService { get; set; }

		public bool IsProductDetail { get; set; }
		public Product SelectedProduct { get; set; }

		public List<Product> products = new List<Product>();
		private int currentPage = 1;
		private int pageSize = 5; // Number of items per page
		/*private bool IsFirstPage => currentPage == 1;
		private bool IsLastPage => currentPage == TotalPages;
*/
		[Inject]
		private NavigationManager NavigationManager { get; set; }

		protected override async Task OnParametersSetAsync()
		{
			products = await productService.GetProductList();
			await base.OnParametersSetAsync();
		}

		private async Task AddToCart(int id)
		{
			App.CartList.Add(products.FirstOrDefault(x => x.id == id));
			products.Where(x=>x.id==id).FirstOrDefault().AddedToCart = true;
		}

		private async Task RemoveFromCart(int id)
		{
			App.CartList.Remove(products.FirstOrDefault(x => x.id == id));
			products.Where(x => x.id == id).FirstOrDefault().AddedToCart = false;
		}

		private async Task GoToCart()
		{
			NavigationManager.NavigateTo("/checkout");
		}

		private async Task ShowDetail(Product item)
		{
			IsProductDetail = true;
			SelectedProduct = item;

		}

		private async Task HideDetail()
		{
			IsProductDetail = false;
			SelectedProduct = null;

		}

		/*	private int TotalPages => (int)Math.Ceiling((double)movies.Count / pageSize);

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
			}*/
	}
}