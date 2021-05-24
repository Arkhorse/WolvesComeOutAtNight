using System.IO;
using System.Reflection;
using ModSettings;

namespace WolvesComeOutAtNight
{
    class WolvesComeOutAtNightSettings : JsonModSettings
    {
        [Section("Wolves Only Come Out At Night")]
        [Name("Everywhere")]
        [Description("If you select this option, wolves will only come out at night in all regions")]
        public bool everywhere = false;

        [Name("Ash Canyon")]
        [Description("Wolves only come out at night")]
        public bool ashCanyon = false;

        [Name("Bleak Inlet")]
        [Description("Wolves only come out at night")]
        public bool bleakInlet = false;

        [Name("Broken Railroad")]
        [Description("Wolves only come out at night")]
        public bool brokenRailroad = false;

        [Name("Coastal Highway")]
        [Description("Wolves only come out at night")]
        public bool coastalHighway = false;

        [Name("Crumbling Highway")]
        [Description("Wolves only come out at night")]
        public bool crumblingHighway = false;

        [Name("Desolation Point")]
        [Description("Wolves only come out at night")]
        public bool desolationPoint = false;

        [Name("Forlorn Muskeg")]
        [Description("Wolves only come out at night")]
        public bool forlornMuskeg = false;

        [Name("Hushed River Valley")]
        [Description("Wolves only come out at night")]
        public bool hushedRiver = false;

        [Name("Mountain Town")]
        [Description("Wolves only come out at night")]
        public bool mountainTown = false;

        [Name("Mystery Lake")]
        [Description("Wolves only come out at night")]
        public bool mysteryLake = false;

        [Name("Pleasant Valley")]
        [Description("Wolves only come out at night")]
        public bool pleasantValley = false;

        [Name("Timberwolf Mountain")]
        [Description("Wolves only come out at night")]
        public bool timberwolfMountain = false;

        [Name("Winding River")]
        [Description("Wolves only come out at night")]
        public bool windingRiver = false;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(everywhere)) RefreshFields();
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(ashCanyon), !everywhere);
            SetFieldVisible(nameof(bleakInlet), !everywhere);
            SetFieldVisible(nameof(brokenRailroad), !everywhere);
            SetFieldVisible(nameof(coastalHighway), !everywhere);
            SetFieldVisible(nameof(crumblingHighway), !everywhere);
            SetFieldVisible(nameof(desolationPoint), !everywhere);
            SetFieldVisible(nameof(forlornMuskeg), !everywhere);
            SetFieldVisible(nameof(hushedRiver), !everywhere);
            SetFieldVisible(nameof(mountainTown), !everywhere);
            SetFieldVisible(nameof(mysteryLake), !everywhere);
            SetFieldVisible(nameof(pleasantValley), !everywhere);
            SetFieldVisible(nameof(timberwolfMountain), !everywhere);
            SetFieldVisible(nameof(windingRiver), !everywhere);
        }
    }

internal static class Settings
    {
        internal static WolvesComeOutAtNightSettings settings;
        internal static void OnLoad()
        {
            settings = new WolvesComeOutAtNightSettings();
            settings.RefreshFields();
            settings.AddToModSettings("Wolves Come Out At Night");
        }
    }
}
