using Acr.UserDialogs;

namespace SpaceXData.Services.App;

public class CoreService : ICoreService
{
    public async Task ShowAlert(string message, string title, string button)
    {
        await UserDialogs.Instance.AlertAsync(message, title, button);
    }

    public void ShowLoading()
    {
        UserDialogs.Instance.ShowLoading("Loading");
    }

    public void HideLoading()
    {
        UserDialogs.Instance.HideLoading();
    }
}