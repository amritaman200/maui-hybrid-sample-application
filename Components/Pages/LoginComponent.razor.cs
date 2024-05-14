
using maui_hybrid.Models;
using Microsoft.AspNetCore.Components;

namespace maui_hybrid.Components.Pages
{

    public partial class LoginComponent
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        private LoginModel loginModel = new LoginModel();

        private void Login()
        {
            if(loginModel != null)
            {
                if(loginModel.Username=="admin"&& loginModel.Password == "admin")
                {
                    try
                    {
                    NavigationManager.NavigateTo("/products");
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }
        }
    }
}