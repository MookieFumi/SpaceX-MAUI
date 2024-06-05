using CommunityToolkit.Mvvm.ComponentModel;
using SpaceXData.Services.App;
using SpaceXData.Services.Dtos;
using SpaceXData.ViewModels.Base;

namespace SpaceXData.ViewModels;

public partial class LaunchDetailViewModel : BaseViewModel, IQueryAttributable
{
    private readonly ICoreService _coreService;

    [ObservableProperty]
    public string _title;

    [ObservableProperty]
    private Launch _launch;

    public LaunchDetailViewModel(ICoreService coreService)
    {
        _coreService = coreService;
    }

    public override async Task Initialize() => await Task.Delay(0);

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        _coreService.ShowLoading();

        Launch = query["param"] as Launch;
        Title = $"Details for {Launch.MissionName}";

        _coreService.HideLoading();
    }
}