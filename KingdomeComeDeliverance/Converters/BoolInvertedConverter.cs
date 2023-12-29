//-----------------------------------------------------------------------------------------------------------------
// <copyright file="BoolInvertedConverter.cs" company="PEAKnx">
// The copyright to the computer program(s) herein is the property of PEAKnx.
//
// All information and materials contained herein are owned by PEAKnx and 
// protected by German and international copyright laws.
// The program(s) may be used and/or copied only with the written permission
// of PEAKnx or in accordance with the terms and conditions
// stipulated in the agreement/contract under which the program(s)
// have been supplied.
//
// Copyright (c) 2017 PEAKnx.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------------------------------------------

using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace KingdomeComeDeliverance.Converters
{
    public sealed class BoolInvertedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool boolValue && !boolValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool boolValue && !boolValue;
        }
    }
}
