using SpaceXData.ViewModels;

namespace SpaceXData.Views;

public partial class LaunchDetailView : BaseView
{
    public LaunchDetailView(LaunchDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}