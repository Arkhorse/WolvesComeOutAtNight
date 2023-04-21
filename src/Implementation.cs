using System.Reflection;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace WolvesComeOutAtNight
{
    public class WolvesComeOutAtNight : MelonMod
    {
        #region Mod Variables
        internal enum PredatorRegions
        {
            AshCanyonRegion,
            BlackrockPrisonSurvivalZone,
            BlackrockRegion,
            BlackrockTransitionZone,
            CanyonRoadTransitionZone,
            CanneryRegion,
            CoastalRegion,
            CrashMountainRegion,
            DamRiverTransitionZoneB,
            HighwayTransitionZone,
            LakeRegion,
            MarshRegion,
            MountainTownRegion,
            RiverValleyRegion,
            RuralRegion,
            TracksRegion,
            WhalingStationRegion,
            AirfieldRegion
        }

        internal static string activeScene = GameManager.m_ActiveScene;
        #endregion
        internal static void NoneDuringDay(SpawnRegion spawnRegion)
        {
            spawnRegion.m_MaxSimultaneousSpawnsDayInterloper = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayPilgrim = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayStalker = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayVoyageur = 0;
        }
        internal static void GetSettings(SpawnRegion spawnRegion)
        {
            // if the current scene is null then dont run the code
            if (activeScene is null) return;

            // The mod must be enabled to work
            if (Settings.settings.modToggle)
            {
                if (activeScene == "AshCanyonRegion" && (Settings.settings.everywhere || Settings.settings.ashCanyon)) NoneDuringDay(spawnRegion);
                else if (activeScene == "BlackrockPrisonSurvivalZone" && (Settings.settings.everywhere || Settings.settings.blackrockPrison)) NoneDuringDay(spawnRegion);
                else if (activeScene == "BlackrockRegion" && (Settings.settings.everywhere || Settings.settings.blackrock)) NoneDuringDay(spawnRegion);
                else if (activeScene == "BlackrockTransitionZone" && (Settings.settings.everywhere || Settings.settings.keepersPassNorth)) NoneDuringDay(spawnRegion);
                else if (activeScene == "CanyonRoadTransitionZone" && (Settings.settings.everywhere || Settings.settings.keepersPassSouth)) NoneDuringDay(spawnRegion);
                else if (activeScene == "CanneryRegion" && (Settings.settings.everywhere || Settings.settings.bleakInlet)) NoneDuringDay(spawnRegion);
                else if (activeScene == "CoastalRegion" && (Settings.settings.everywhere || Settings.settings.coastalHighway)) NoneDuringDay(spawnRegion);
                else if (activeScene == "CrashMountainRegion" && (Settings.settings.everywhere || Settings.settings.timberwolfMountain)) NoneDuringDay(spawnRegion);
                else if (activeScene == "DamRiverTransitionZoneB" && (Settings.settings.everywhere || Settings.settings.windingRiver)) NoneDuringDay(spawnRegion);
                else if (activeScene == "HighwayTransitionZone" && (Settings.settings.everywhere || Settings.settings.crumblingHighway)) NoneDuringDay(spawnRegion);
                else if (activeScene == "LakeRegion" && (Settings.settings.everywhere || Settings.settings.mysteryLake)) NoneDuringDay(spawnRegion);
                else if (activeScene == "MarshRegion" && (Settings.settings.everywhere || Settings.settings.forlornMuskeg)) NoneDuringDay(spawnRegion);
                else if (activeScene == "MountainTownRegion" && (Settings.settings.everywhere || Settings.settings.mountainTown)) NoneDuringDay(spawnRegion);
                else if (activeScene == "RiverValleyRegion" && (Settings.settings.everywhere || Settings.settings.hushedRiver)) NoneDuringDay(spawnRegion);
                else if (activeScene == "RuralRegion" && (Settings.settings.everywhere || Settings.settings.pleasantValley)) NoneDuringDay(spawnRegion);
                else if (activeScene == "TracksRegion" && (Settings.settings.everywhere || Settings.settings.brokenRailroad)) NoneDuringDay(spawnRegion);
                else if (activeScene == "WhalingStationRegion" && (Settings.settings.everywhere || Settings.settings.desolationPoint)) NoneDuringDay(spawnRegion);

                // DLC
                else if (activeScene == "AirfieldRegion" && (Settings.settings.everywhere || Settings.settings.AirfieldRegion)) NoneDuringDay(spawnRegion);

                // handle instances where the scene is not already handle
                else
                {
                    MelonLogger.Msg($"[{Assembly.GetExecutingAssembly().GetName().Name}] The called region \"{activeScene}\" is not currently handled. This could be due to the region not having wolves");
                }
            }
        }
    }
    public class Implementation : MelonMod
    {
        public string? ModName = Assembly.GetExecutingAssembly().GetName().Name;
        public Version? ModVersion = Assembly.GetExecutingAssembly().GetName().Version;
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg($"[{ModName}] Version {ModVersion} loaded!");
            Settings.OnLoad();
        }
    }
}