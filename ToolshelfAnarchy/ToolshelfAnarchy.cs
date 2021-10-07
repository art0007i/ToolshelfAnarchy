using HarmonyLib;
using NeosModLoader;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections.Generic;
using FrooxEngine;
using FrooxEngine.LogiX;

namespace ToolshelfAnarchy
{
    public class ToolshelfAnarchy : NeosMod
    {
        public override string Name => "ToolshelfAnarchy";
        public override string Author => "art0007i";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/art0007i/ToolshelfAnarchy/";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("me.art0007i.ToolshelfAnarchy");
            harmony.PatchAll();

        }
        [HarmonyPatch(typeof(CommonTool))]
        [HarmonyPatch("ItemShelfFilter")]
        class CommonTool_ItemShelfFilter_Patch
        {
            public static bool Prefix(ref bool __result)
            {
                __result = true;
                return false;
            }
        }
    }
}