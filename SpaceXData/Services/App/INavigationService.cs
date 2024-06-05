using SpaceXData.Services.Dtos;

namespace SpaceXData.Services.App;

public interface INavigationService
{
    public Task NavigateToAsync(string to, object parameter = null);
}
