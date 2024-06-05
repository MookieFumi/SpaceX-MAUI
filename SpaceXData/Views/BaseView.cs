using SpaceXData.ViewModels.Base;

namespace SpaceXData.Views;

public class BaseView : ContentPage
{
    protected override async void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();

        await (this.BindingContext as BaseViewModel).Initialize();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
    }
}