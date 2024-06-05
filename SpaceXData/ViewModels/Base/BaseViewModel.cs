using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SpaceXData.ViewModels.Base;

public abstract class BaseViewModel : INotifyPropertyChanged
{
    public abstract Task Initialize();

    public event PropertyChangedEventHandler PropertyChanged;    

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}