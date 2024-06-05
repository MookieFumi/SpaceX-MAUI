using CommunityToolkit.Mvvm.ComponentModel;

namespace SpaceXData.ViewModels.Base;

public abstract class BaseViewModel : ObservableObject
{
    public abstract Task Initialize();
}