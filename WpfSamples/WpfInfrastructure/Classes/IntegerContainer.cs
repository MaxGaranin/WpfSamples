﻿using System.Windows;

namespace WpfSamples.WpfInfrastructure.Classes
{
    public class IntegerContainer : FrameworkElement
    {
        public int Value
        {
            get { return (int) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof (int), typeof (IntegerContainer), 
                new PropertyMetadata(0, (s, e) =>
                {
                    
                }));
    }
}