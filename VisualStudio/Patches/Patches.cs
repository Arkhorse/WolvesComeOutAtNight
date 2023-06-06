namespace WolvesComeOutAtNight
{
    internal class Patches
    {
        [HarmonyPatch(typeof(SpawnRegion), "Start")]
        internal class ChangeWolfSpawns
        {
            private static void Postfix(SpawnRegion __instance)
            {
                if (__instance.m_AiSubTypeSpawned == AiSubType.Wolf && Settings.Instance.HandleWolves)
                {
                    WolvesComeOutAtNight.GetSettings(__instance);
                }
                if (__instance.m_AiSubTypeSpawned == AiSubType.Bear && Settings.Instance.HandleBears)
                {
                    WolvesComeOutAtNight.GetSettings(__instance);
                }
            }
        }
    }
}
