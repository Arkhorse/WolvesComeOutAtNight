using ModSettings;

namespace WolvesComeOutAtNight
{
    internal class Settings : JsonModSettings
    {
        internal static Settings Instance { get; } = new();

        [Section("Quick Settings")]

        [Name("Mod Toggle")]
        [Description("If you happen to need to disable the mod entirely, set this to false")]
        public bool modToggle = false;

        [Name("Everywhere")]
        [Description("If you select this option, wolves will only come out at night in all regions")]
        public bool everywhere = false;

        [Section("AI Types")]

        [Name("Handle Wolves")]
        [Description("Will prevent Wolves in the enabled regions")]
        public bool HandleWolves = true;

        [Name("Handle Bears")]
        [Description("Will prevent Bears in the enabled regions")]
        public bool HandleBears = false;

        [Section("Regions")]

        [Name("Ash Canyon")]
        //[Description("Wolves only come out at night")]
        public bool AshCanyonRegion = false;

        [Name("Blackrock")]
        //[Description("Wolves only come out at night")]
        public bool BlackrockRegion = false;

        [Name("Blackrock Prison")]
        //[Description("Wolves only come out at night")]
        public bool BlackrockPrisonSurvivalZone = false;

        [Name("Bleak Inlet")]
        //[Description("Wolves only come out at night")]
        public bool CanneryRegion = false;

        [Name("Broken Railroad")]
        //[Description("Wolves only come out at night")]
        public bool TracksRegion = false;

        [Name("Coastal Highway")]
        //[Description("Wolves only come out at night")]
        public bool CoastalRegion = false;

        [Name("Crumbling Highway")]
        //[Description("Wolves only come out at night")]
        public bool HighwayTransitionZone = false;

        [Name("Desolation Point")]
        //[Description("Wolves only come out at night")]
        public bool WhalingStationRegion = false;

        [Name("Forlorn Muskeg")]
        //[Description("Wolves only come out at night")]
        public bool MarshRegion = false;

        [Name("Hushed River Valley")]
        //[Description("Wolves only come out at night")]
        public bool RiverValleyRegion = false;

        [Name("Keeper's Pass North")]
        //[Description("Wolves only come out at night")]
        public bool BlackrockTransitionZone = false;

        [Name("Keeper's Pass South")]
        //[Description("Wolves only come out at night")]
        public bool CanyonRoadTransitionZone = false;

        [Name("Mountain Town")]
        //[Description("Wolves only come out at night")]
        public bool MountainTownRegion = false;

        [Name("Mystery Lake")]
        //[Description("Wolves only come out at night")]
        public bool LakeRegion = false;

        [Name("Pleasant Valley")]
        //[Description("Wolves only come out at night")]
        public bool RuralRegion = false;

        [Name("Timberwolf Mountain")]
        //[Description("Wolves only come out at night")]
        public bool CrashMountainRegion = false;

        [Name("Winding River")]
        //[Description("Wolves only come out at night")]
        public bool DamRiverTransitionZoneB = false;

        [Section("DLC")]
        [Description("Regions added by DLC")]

        [Name("Forsaken Airfields")]
        //[Description("Wolves only come out at night")]
        public bool AirfieldRegion = false;

        [Name("Far Range Branch Line")]
        public bool LongRailTransitionZone = false;

        [Name("Transfer Pass")]
        public bool HubRegion = false;

        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue)
        {
            if (field.Name == nameof(everywhere) || field.Name == nameof(HandleWolves) || field.Name == nameof(HandleBears)) RefreshFields();
            base.OnChange(field, oldValue, newValue);
        }

        internal void RefreshFields()
        {
            // AI TYPES
            SetFieldVisible(nameof(HandleWolves),                       !modToggle);
            SetFieldVisible(nameof(HandleBears),                        !modToggle);

            // Base game zones
            SetFieldVisible(nameof(AshCanyonRegion),                    !everywhere || !modToggle);
            SetFieldVisible(nameof(BlackrockRegion),                    !everywhere || !modToggle);
            SetFieldVisible(nameof(BlackrockPrisonSurvivalZone),        !everywhere || !modToggle);
            SetFieldVisible(nameof(CanneryRegion),                      !everywhere || !modToggle);
            SetFieldVisible(nameof(TracksRegion),                       !everywhere || !modToggle);
            SetFieldVisible(nameof(CoastalRegion),                      !everywhere || !modToggle);
            SetFieldVisible(nameof(HighwayTransitionZone),              !everywhere || !modToggle);
            SetFieldVisible(nameof(WhalingStationRegion),               !everywhere || !modToggle);
            SetFieldVisible(nameof(MarshRegion),                        !everywhere || !modToggle);
            SetFieldVisible(nameof(RiverValleyRegion),                  !everywhere || !modToggle);
            SetFieldVisible(nameof(BlackrockTransitionZone),            !everywhere || !modToggle);
            SetFieldVisible(nameof(CanyonRoadTransitionZone),           !everywhere || !modToggle);
            SetFieldVisible(nameof(MountainTownRegion),                 !everywhere || !modToggle);
            SetFieldVisible(nameof(LakeRegion),                         !everywhere || !modToggle);
            SetFieldVisible(nameof(RuralRegion),                        !everywhere || !modToggle);
            SetFieldVisible(nameof(CrashMountainRegion),                !everywhere || !modToggle);
            SetFieldVisible(nameof(DamRiverTransitionZoneB),            !everywhere || !modToggle);

            // DLC
            SetFieldVisible(nameof(AirfieldRegion),                     !everywhere || !modToggle);
            SetFieldVisible(nameof(LongRailTransitionZone),             !everywhere || !modToggle);
            SetFieldVisible(nameof(HubRegion),                          !everywhere || !modToggle);
        }

        internal static void OnLoad()
        {
            Instance.AddToModSettings(BuildInfo.Name);
            Instance.RefreshFields();
        }
    }
}
