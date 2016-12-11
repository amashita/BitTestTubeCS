using System;
using System.Reactive.Linq;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;

namespace BitTestTube.ViewModels
{
    public class TestTubePageViewModel : BindableBase
    {
        public ReactiveProperty<string> Address { get; } = new ReactiveProperty<string>();

        public ReactiveCommand NextCommand { get; }

        public TestTubePageViewModel(INavigationService navigationService)
        {
        }
    }
}
