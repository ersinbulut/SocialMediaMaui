﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaMaui.Controls
{
    public class Spacer:ContentView
    {
        public BoxView Box { get; set; }

        public Spacer()
        {
            Box = new BoxView
            {
                BackgroundColor = Colors.Transparent,
                HeightRequest = 20
            };
            Content = Box;
        }

        public static readonly BindableProperty SpaceProperty = BindableProperty.Create(nameof(Space), typeof(int), typeof(Spacer), defaultValue: 20,propertyChanged:OnSpaceProperyChanged);

        public int Space 
        {
            get => (int)GetValue(SpaceProperty);
            set => SetValue(SpaceProperty,value);
        }

        private static void OnSpaceProperyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is Spacer spacer)
            {
                spacer.Box.HeightRequest = spacer.Space;
            }
        }

    }
}
