using System.Collections.ObjectModel;
using System.Windows.Input;
using SpaceXData.Services;
using SpaceXData.Services.App;
using SpaceXData.Services.Dtos;
using SpaceXData.ViewModels.Base;
using SpaceXData.Views;

namespace SpaceXData.ViewModels;

public class LaunchesViewModel : BaseViewModel
{
    private readonly ICoreService _coreService;
    private readonly INavigationService _navigationService;
    private readonly SpaceXService _spacexService;

    public LaunchesViewModel(ICoreService coreService, INavigationService navigationService, SpaceXService spaceXService)
    {
        _coreService = coreService;
        _navigationService = navigationService;
        _spacexService = spaceXService;

        GoToDetailCommand = new Command(async (param) => await GoToDetail((Launch)param));

        LaunchesResponse = new ObservableCollection<GetLaunchesResponse>();
    }

    private ObservableCollection<GetLaunchesResponse> _launchesResponse;
    public ObservableCollection<GetLaunchesResponse> LaunchesResponse
    {
        get { return _launchesResponse; }
        set
        {
            if (_launchesResponse != value)
            {
                _launchesResponse = value;
                OnPropertyChanged();
            }
        }
    }

    public ICommand GoToDetailCommand { private set; get; }

    public override async Task Initialize()
    {
        _coreService.ShowLoading();

        var response = await _spacexService.GetLaunches();
        LaunchesResponse = new ObservableCollection<GetLaunchesResponse>(response);

        _coreService.HideLoading();
    }

    private async Task GoToDetail(Launch launch)
    {
        await _navigationService.NavigateToAsync(nameof(LaunchDetailView), launch);
    }
}