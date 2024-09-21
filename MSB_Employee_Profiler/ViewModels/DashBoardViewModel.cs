// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using MSB_Employee_Profiler.Services;

namespace MSB_Employee_Profiler.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    [ObservableProperty] IEmployeeService employeeService;

    public DashboardViewModel(IEmployeeService employeeService)
    {
        this.employeeService = employeeService;
    }


    [ObservableProperty]
    private int _counter = 0;

    [RelayCommand]
    private void OnCounterIncrement()
    {
        Counter++;
    }
}
