using System.IO;
using System.Reflection;
using ModSettings;

namespace WolvesComeOutAtNight
{
    internal class WolvesComeOutAtNightSettings : JsonModSettings
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
            SetFieldVisible(nameof(ashCanyon),          !everywhere || !modToggle);
            SetFieldVisible(nameof(blackrock),          !everywhere || !modToggle);
            SetFieldVisible(nameof(blackrockPrison),    !everywhere || !modToggle);
            SetFieldVisible(nameof(bleakInlet),         !everywhere || !modToggle);
            SetFieldVisible(nameof(brokenRailroad),     !everywhere || !modToggle);
            SetFieldVisible(nameof(coastalHighway),     !everywhere || !modToggle);
            SetFieldVisible(nameof(crumblingHighway),   !everywhere || !modToggle);
            SetFieldVisible(nameof(desolationPoint),    !everywhere || !modToggle);
            SetFieldVisible(nameof(forlornMuskeg),      !everywhere || !modToggle);
            SetFieldVisible(nameof(hushedRiver),        !everywhere || !modToggle);
            SetFieldVisible(nameof(keepersPassNorth),   !everywhere || !modToggle);
            SetFieldVisible(nameof(keepersPassSouth),   !everywhere || !modToggle);
            SetFieldVisible(nameof(mountainTown),       !everywhere || !modToggle);
            SetFieldVisible(nameof(mysteryLake),        !everywhere || !modToggle);
            SetFieldVisible(nameof(pleasantValley),     !everywhere || !modToggle);
            SetFieldVisible(nameof(timberwolfMountain), !everywhere || !modToggle);
            SetFieldVisible(nameof(windingRiver),       !everywhere || !modToggle);

            // DLC
            SetFieldVisible(nameof(AirfieldRegion),     !everywhere || !modToggle);
        }
    }

    internal static class Settings
    {

        internal static readonly WolvesComeOutAtNightSettings settings = new();

        internal static void OnLoad()
        {
            settings.RefreshFields();
            settings.AddToModSettings("Wolves Come Out At Night");
        }
    }
}
