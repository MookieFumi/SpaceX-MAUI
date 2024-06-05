namespace SpaceXData.Services.App;

public interface ICoreService
{
    public Task ShowAlert(string title, string message, string button);
    public void ShowLoading();
    public void HideLoading();
}
