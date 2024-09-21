﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using System.Windows.Media;
using Wpf.Ui.Controls;
using MSB_Employee_Profiler.Models;

namespace MSB_Employee_Profiler.ViewModels;

public partial class DataViewModel : ObservableObject, INavigationAware
{
    private bool _isInitialized = false;


    public void OnNavigatedTo()
    {
        if (!_isInitialized)
            InitializeViewModel();
    }

    public void OnNavigatedFrom() { }

    private void InitializeViewModel()
    {
           _isInitialized = true;
    }
}
