using maui_hybrid.Models;
using Microsoft.AspNetCore.Components;

namespace maui_hybrid.Components.Pages
{
	public partial class ProductDetail
	{
		[Parameter]
		public Product Product { get; set; }
	}
}