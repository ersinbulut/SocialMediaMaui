using System;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace SocialMediaMaui.Controls
{
    public class NoBorderEntry:Entry
    {
        protected override void OnHandlerChanged()
        {
            base.OnHandlerChanged();
            setBorderlessBackground();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
#if ANDROID
        if(propertyName == nameof(BackgroundColor))
                    setBorderlessBackground();
#endif
        }

        private void setBorderlessBackground()
        {
#if ANDROID
            if (Handler is IEntryHandler entryHandler)
	    {
            if (BackgroundColor == null)
	        {
                entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
	        }
            else
            {
                   entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(BackgroundColor.ToPlatform());
            }
	    }
#endif
        }
    }
}
