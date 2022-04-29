using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnAppearing.ViewModels
{
    public class LoginViewModel
    {
		public Command LoginButton { get; }

		public LoginViewModel()
		{
			LoginButton = new Command(Login_Clicked);
			
		}


		private async void Login_Clicked(object obj)
		{
			await Shell.Current.GoToAsync("//suche");
		}

	}
}
