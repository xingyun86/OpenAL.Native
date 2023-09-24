﻿//
// GetEnumerateAllContextString.cs
//
// Copyright (C) 2023 OPENAL.PPSYQM
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OPENAL.PPSYQM
{
    /// <summary>
    /// Defines available parameters for <see cref="ALC.EnumerateAll.GetString(ALDevice, GetEnumerateAllContextString)" />.
    /// </summary>
    public enum GetEnumerateAllContextString
    {
        /// <summary>
        /// Gets the specifier for the default device.
        /// </summary>
        DefaultAllDevicesSpecifier = 0x1012,

        /// <summary>
        /// Gets the specifier of the first available device.
        /// </summary>
        AllDevicesSpecifier = 0x1013,
    }
}
