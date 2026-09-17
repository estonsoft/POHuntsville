namespace POHuntsville.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public String User { get; set; }
        public String Password { get; set; }
        public bool RememberMe { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);

            try
            {
                RememberMe = App.g_Customer.RememberMe;
            }
            catch
            {
                RememberMe = false;
            }
        }

        private async void OnLoginClicked(object obj)
        {
            await App.ResetProgressAsync();
            App.g_LoginPage.ShowAnimation();
            App.UpdateServerLinks();

            App.g_IsLoggedIn = true;
            App.g_UserName = User;

            App.g_Customer.User = User;
            App.g_Customer.RememberMe = RememberMe;


            await App.g_db.SaveCustomer(App.g_Customer);
            await App.CommManager.ValidateLogin(User, Password, App.g_Customer.UniqueId);
        }
    }
}
