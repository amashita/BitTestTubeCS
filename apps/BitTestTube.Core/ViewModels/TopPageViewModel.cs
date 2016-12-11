using System;
using System.Reactive.Linq;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;

namespace BitTestTube.ViewModels
{
    public class TopPageViewModel : BindableBase
    {
        private INavigationService NavigationService { get; }

        public ReactiveProperty<string> Address { get; } = new ReactiveProperty<string>();

        public ReactiveCommand NextCommand { get; }

        public TopPageViewModel(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        // INavigationServiceを使って画面遷移を行う
        public void NavigateNextPage()
        {
            this.NavigationService.NavigateAsync("TestTube", null);
        }
        
    }
}
