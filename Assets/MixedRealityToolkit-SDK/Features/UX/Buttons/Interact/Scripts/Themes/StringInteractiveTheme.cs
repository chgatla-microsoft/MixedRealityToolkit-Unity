﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interact.Themes
{
    public class StringInteractiveTheme : InteractiveTheme<string>
    {
        private void OnEnable()
        {
            InteractiveThemeManager.AddStringTheme(this);
        }

        private void OnDisable()
        {
            InteractiveThemeManager.RemoveStringTheme(this.Tag);
        }
    }
}