using maui_hybrid.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace maui_hybrid.Components.Pages
{
	public partial class CheckOut
	{

		[Inject]
		IJSRuntime jSRuntime { get; set; }
		[Inject]
		private NavigationManager NavigationManager { get; set; }
		private async Task RemoveFromCart(Product item)
		{
			App.CartList.Remove(item);
			if(App.CartList.Count == 0)
			{
				await App.Current.MainPage.DisplayAlert("Confirm", "Your Shopping Cart is empty. Please Go To Product Page.","Ok");
				
					NavigationManager.NavigateTo("/products");
				
			}
		}

		private async Task ConfirmOrder()
		{
			if(App.CartList.Count>0) 
			{
				 await App.Current.MainPage.DisplayAlert("Confirm", "Your order is confirmed. Thank you.", "Ok");
				
					NavigationManager.NavigateTo("/products");
				
			}
		}

	}
}