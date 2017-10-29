using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmyUIExmaple
{
    public enum EntryCategory { Bug, Feature, Cosmetic, Analytic }
    public class ListItem
    {
        public EntryCategory Category { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
