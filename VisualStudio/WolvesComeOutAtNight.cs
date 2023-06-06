namespace WolvesComeOutAtNight
{
    public class WolvesComeOutAtNight : MelonMod
    {
        internal static string activeScene = GameManager.m_ActiveScene;
        public override void OnInitializeMelon()
        {
            Logger.Log($"Mod Loaded with version {BuildInfo.Version}");
            Settings.OnLoad();
        }

        internal static void NoneDuringDay(SpawnRegion spawnRegion)
        {
            spawnRegion.m_MaxSimultaneousSpawnsDayInterloper    = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayPilgrim       = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayStalker       = 0;
            spawnRegion.m_MaxSimultaneousSpawnsDayVoyageur      = 0;
        }
        internal static void GetSettings(SpawnRegion spawnRegion)
        {
            // if the current scene is null then dont run the code
            if (activeScene is null) return;

            // The mod must be enabled to work
            if (Settings.Instance.modToggle)
            {
                switch (activeScene)
                {
                    case ("AshCanyonRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.AshCanyonRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("BlackrockRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.BlackrockRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("BlackrockPrisonSurvivalZone"):
                        if (Settings.Instance.everywhere || Settings.Instance.BlackrockPrisonSurvivalZone)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("CanneryRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.CanneryRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("TracksRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.TracksRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("CoastalRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.CoastalRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("HighwayTransitionZone"):
                        if (Settings.Instance.everywhere || Settings.Instance.HighwayTransitionZone)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("WhalingStationRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.WhalingStationRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("MarshRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.MarshRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("RiverValleyRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.RiverValleyRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("BlackrockTransitionZone"):
                        if (Settings.Instance.everywhere || Settings.Instance.BlackrockTransitionZone)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("CanyonRoadTransitionZone"):
                        if (Settings.Instance.everywhere || Settings.Instance.CanyonRoadTransitionZone)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("MountainTownRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.MountainTownRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("LakeRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.LakeRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("RuralRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.RuralRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("CrashMountainRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.CrashMountainRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("DamRiverTransitionZoneB"):
                        if (Settings.Instance.everywhere || Settings.Instance.DamRiverTransitionZoneB)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("AirfieldRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.AirfieldRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("LongRailTransitionZone"):
                        if (Settings.Instance.everywhere || Settings.Instance.LongRailTransitionZone)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    case ("HubRegion"):
                        if (Settings.Instance.everywhere || Settings.Instance.HubRegion)
                        {
                            NoneDuringDay(spawnRegion);
                        }
                        break;
                    // handle instances where the scene is not already handle
                    default:
                        Logger.Log($"The called region \"{activeScene}\" is not currently handled. This could be due to the region not having wolves");
                        break;
                }
            }
        }
    }
}