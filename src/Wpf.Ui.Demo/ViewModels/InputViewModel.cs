﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using System.Collections.Generic;
using Wpf.Ui.Common.Interfaces;

namespace Wpf.Ui.Demo.ViewModels;

public class InputViewModel : Wpf.Ui.Mvvm.ViewModelBase, INavigationAware
{
    private bool _dataInitialized = false;

    public IEnumerable<string> AutoSuggestCollection
    {
        get => GetValue<IEnumerable<string>>();
        set => SetValue(value);
    }

    public IEnumerable<string> ComboCollection
    {
        get => GetValue<IEnumerable<string>>();
        set => SetValue(value);
    }

    public void OnNavigatedTo()
    {
        if (!_dataInitialized)
            InitializeData();
    }

    public void OnNavigatedFrom()
    {
    }

    private void InitializeData()
    {
        AutoSuggestCollection = new[]
        {
            "Blossoms",
            "Bloodmoss",
            "Blowbill",
            "Bryonia",
            "Buckthorn",
            "Celandine",
            "Cortinarius",
            "Crow's Eye",
            "Fools Parsley Leaves",
            "Ginatia Petals",
            "Han",
            "Hellebore Petals",
            "Honeysuckle",
            "Hop Umbels",
            "Hornwart",
            "Longrube",
            "Mandrake Root",
            "Moleyarrow",
            "Nostrix",
            "Pigskin Puffball",
            "Pringrape",
            "Ranogrin",
            "Ribleaf",
            "Sewant Mushrooms",
            "Verbena",
            "White Myrtle",
            "Wolfsbane"
        };

        ComboCollection = new[]
        {
            "Blossoms",
            "Bloodmoss",
            "Blowbill",
            "Bryonia",
            "Buckthorn",
            "Celandine",
            "Cortinarius",
            "Crow's Eye",
            "Fools Parsley Leaves",
            "Ginatia Petals",
            "Han",
        };

        _dataInitialized = true;
    }
}
