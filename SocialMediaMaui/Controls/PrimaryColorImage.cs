using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Behaviors;

namespace SocialMediaMaui.Controls
{
    public class PrimaryColorImage : Image
    {
        public PrimaryColorImage()
        {
            if (App.Current.Resources.TryGetValue("Primary", out object color) && color is Color primaryColor)
            {
                var tintColorBehavior = Behaviors.FirstOrDefault(b => b is IconTintColorBehavior);
                if (tintColorBehavior == null)
                {
                    tintColorBehavior = new IconTintColorBehavior
                    {
                        TintColor = primaryColor
                    };
                    Behaviors.Add(tintColorBehavior);
                }
            }
        }
    }
}
