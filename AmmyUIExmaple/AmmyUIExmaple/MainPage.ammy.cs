using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmmyUIExmaple
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new
            {
                ListItems = new List<ListItem>
                {
                    new ListItem
                    {
                        Title = "Fix Page constructor on iOS",
                        Icon = "ic_bug_report_white_24dp.png",
                        Category = EntryCategory.Bug
                    },
                    new ListItem
                    {
                        Title = "Add option to remove entries",
                        Icon = "ic_build_white_24dp.png",
                        Category = EntryCategory.Feature
                    },
                    new ListItem
                    {
                        Title = "Create marketing plan",
                        Icon = "ic_assessment_white_24dp.png",
                        Category = EntryCategory.Analytic
                    },
                    new ListItem
                    {
                        Title = "Change font of entry's description",
                        Icon = "ic_face_white_24dp.png",
                        Category = EntryCategory.Cosmetic
                    },
                }
            };
        }
    }
}
