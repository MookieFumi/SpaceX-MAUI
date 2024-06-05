﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SpaceXData.Services;
using SpaceXData.Services.App;
using SpaceXData.Services.Dtos;
using SpaceXData.ViewModels.Base;
using SpaceXData.Views;

namespace SpaceXData.ViewModels;

public partial class LaunchesViewModel : BaseViewModel
{
    private readonly ICoreService _coreService;
    private readonly INavigationService _navigationService;
    private readonly SpaceXService _spacexService;

    public LaunchesViewModel(ICoreService coreService, INavigationService navigationService, SpaceXService spaceXService)
    {
        _coreService = coreService;
        _navigationService = navigationService;
        _spacexService = spaceXService;

        GoToDetailCommand = new AsyncRelayCommand<Launch>((param) => GoToDetail(param));

        LaunchesResponse = new ObservableCollection<GetLaunchesResponse>();
    }

    [ObservableProperty]
    private ObservableCollection<GetLaunchesResponse> _launchesResponse;

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