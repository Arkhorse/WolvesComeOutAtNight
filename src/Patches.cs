using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2Cpp;
using Il2CppSystem.Reflection;
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
                if (__instance.m_AiSubTypeSpawned == AiSubType.Wolf)
                {
                    WolvesComeOutAtNight.GetSettings(__instance);
                }
            }
        }
    }
}
