namespace SpaceXData.Services.App;

public class NavigationService : INavigationService
{
    public async Task NavigateToAsync(string to, object parameter = null)
    {
        var parameters = new Dictionary<string, object>
            {
                { "param", parameter }
            };

        await Shell.Current.GoToAsync(to, parameters);
    }
}