﻿// Copyright © Joerg Battermann 2014, Matt Hunt 2017

using System;
using System.Collections.Generic;

namespace GeoJSON.Text
{
    /// <summary>
    ///     Compares doubles for equality.
    /// </summary>
    /// <remarks>
    ///     10 decimal places equates to accuracy to 11.1 μm.
    /// </remarks>
    public class DecimalTenDecimalPlaceComparer : IEqualityComparer<decimal>
    {
        public bool Equals(decimal x, decimal y)
        {
            return Math.Abs(x - y) < 0.0000000001m;
        }

        public int GetHashCode(decimal obj)
        {
            return obj.GetHashCode();
        }
    }
}