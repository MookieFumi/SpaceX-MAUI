using SpaceXData.Services.App;
using SpaceXData.Services.Dtos;
using SpaceXData.ViewModels.Base;

namespace SpaceXData.ViewModels;

public class LaunchDetailViewModel : BaseViewModel, IQueryAttributable
{
    private readonly ICoreService _coreService;

    private string _title;
    public string Title
    {
        get { return _title; }
        set
        {
            if (_title != value)
            {
                _title = value;
                OnPropertyChanged();
            }
        }
    }

    private Launch _launch;

    public Launch Launch
    {
        get { return _launch; }
        set
        {
            if (_launch != value)
            {
                _launch = value;
                OnPropertyChanged();
            }
        }
    }

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