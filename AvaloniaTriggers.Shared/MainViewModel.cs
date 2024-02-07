using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaTriggers.Shared;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    bool flag;

    [RelayCommand]
    public void ToggleFlag()
    {
        Flag = !Flag;
    }
}
