using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmmyUIExmaple.Converters
{
    public static class EntryCategoryToColorConverter
    {
        public static Color Convert(EntryCategory value)
        {
            return (Color)App.Current.Resources["EntryCategoryColor" + value];
        }
    }
}
