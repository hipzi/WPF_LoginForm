﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace SignUp
{
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {
        #region Private Members

        private static T mConverter = null;

        #endregion

        #region Markup Extension Methods
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return mConverter ?? (mConverter = new T());
        }

        #endregion

        #region Value Converter Methods
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion
    }
}
