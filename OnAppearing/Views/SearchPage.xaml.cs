using OnAppearing.ViewModels;
using System.Collections.ObjectModel;

namespace OnAppearing
{
    public partial class SearchPage : ContentPage
    {
        


        public SearchPage()
        {
            InitializeComponent();
            this.BindingContext = new SearchViewModel();

            
        }

        
    }
}
