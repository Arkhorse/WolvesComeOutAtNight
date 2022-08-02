using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using MelonLoader;

namespace WolvesComeOutAtNight
{
    internal class Patches
    {
        [HarmonyPatch(typeof(SpawnRegion), "Start")]
        internal class ChangeWolfSpawns
        {
            private static void Postfix(SpawnRegion __instance)
            {
                if (__instance.m_AiSubTypeSpawned == AiSubType.Wolf) GetSettings(__instance);
            }
        }

        private static void GetSettings(SpawnRegion spawnRegion)
        {
            string activeScene = GameManager.m_ActiveScene;
            if (activeScene is null) return;
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

        }

        private static void NoneDuringDay(SpawnRegion spawnRegion)
        {
            spawnRegion.m_MaxSimultaneousSpawnsDayInterloper = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayPilgrim = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayStalker = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayVoyageur = 0;
        }
    }
}
