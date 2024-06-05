using SpaceXData.ViewModels;

namespace SpaceXData.Views;

public partial class LaunchesView : BaseView
{
    public LaunchesView(LaunchesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}