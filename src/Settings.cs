using System.IO;
using System.Reflection;
using ModSettings;

namespace WolvesComeOutAtNight
{
    class WolvesComeOutAtNightSettings : JsonModSettings
    {
        [Section("Quick Settings")]

        [Name("Mod Toggle")]
        [Description("If you happen to need to disable the mod entirely, set this to false")]
        public bool modToggle = false;

        [Name("Everywhere")]
        [Description("If you select this option, wolves will only come out at night in all regions")]
        public bool everywhere = false;

        [Section("Regions")]

        [Name("Ash Canyon")]
        //[Description("Wolves only come out at night")]
        public bool ashCanyon = false;

        [Name("Blackrock")]
        //[Description("Wolves only come out at night")]
        public bool blackrock = false;

        [Name("Blackrock Prison")]
        //[Description("Wolves only come out at night")]
        public bool blackrockPrison = false;

        [Name("Bleak Inlet")]
        //[Description("Wolves only come out at night")]
        public bool bleakInlet = false;

        [Name("Broken Railroad")]
        //[Description("Wolves only come out at night")]
        public bool brokenRailroad = false;

        [Name("Coastal Highway")]
        //[Description("Wolves only come out at night")]
        public bool coastalHighway = false;

        [Name("Crumbling Highway")]
        //[Description("Wolves only come out at night")]
        public bool crumblingHighway = false;

        [Name("Desolation Point")]
        //[Description("Wolves only come out at night")]
        public bool desolationPoint = false;

        [Name("Forlorn Muskeg")]
        //[Description("Wolves only come out at night")]
        public bool forlornMuskeg = false;

        [Name("Hushed River Valley")]
        //[Description("Wolves only come out at night")]
        public bool hushedRiver = false;

        [Name("Keeper's Pass North")]
        //[Description("Wolves only come out at night")]
        public bool keepersPassNorth = false;

        [Name("Keeper's Pass South")]
        //[Description("Wolves only come out at night")]
        public bool keepersPassSouth = false;

        [Name("Mountain Town")]
        //[Description("Wolves only come out at night")]
        public bool mountainTown = false;

        [Name("Mystery Lake")]
        //[Description("Wolves only come out at night")]
        public bool mysteryLake = false;

        [Name("Pleasant Valley")]
        //[Description("Wolves only come out at night")]
        public bool pleasantValley = false;

        [Name("Timberwolf Mountain")]
        //[Description("Wolves only come out at night")]
        public bool timberwolfMountain = false;

        [Name("Winding River")]
        //[Description("Wolves only come out at night")]
        public bool windingRiver = false;

        [Section("DLC")]
        [Description("Regions added by DLC")]

        [Name("Forsaken Airfields")]
        //[Description("Wolves only come out at night")]
        public bool AirfieldRegion = false;

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        {
            if (field.Name == nameof(everywhere)) RefreshFields();
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(ashCanyon), !everywhere);
            SetFieldVisible(nameof(blackrock), !everywhere);
            SetFieldVisible(nameof(blackrockPrison), !everywhere);
            SetFieldVisible(nameof(bleakInlet), !everywhere);
            SetFieldVisible(nameof(brokenRailroad), !everywhere);
            SetFieldVisible(nameof(coastalHighway), !everywhere);
            SetFieldVisible(nameof(crumblingHighway), !everywhere);
            SetFieldVisible(nameof(desolationPoint), !everywhere);
            SetFieldVisible(nameof(forlornMuskeg), !everywhere);
            SetFieldVisible(nameof(hushedRiver), !everywhere);
            SetFieldVisible(nameof(keepersPassNorth), !everywhere);
            SetFieldVisible(nameof(keepersPassSouth), !everywhere);
            SetFieldVisible(nameof(mountainTown), !everywhere);
            SetFieldVisible(nameof(mysteryLake), !everywhere);
            SetFieldVisible(nameof(pleasantValley), !everywhere);
            SetFieldVisible(nameof(timberwolfMountain), !everywhere);
            SetFieldVisible(nameof(windingRiver), !everywhere);

            // DLC
            SetFieldVisible(nameof(AirfieldRegion), !everywhere);
        }
    }

    internal static class Settings
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        internal static WolvesComeOutAtNightSettings settings;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        internal static void OnLoad()
        {
            settings = new WolvesComeOutAtNightSettings();
            settings.RefreshFields();
            settings.AddToModSettings("Wolves Come Out At Night");
        }
    }
}
