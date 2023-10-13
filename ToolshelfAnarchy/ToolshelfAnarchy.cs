using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;

namespace ToolshelfAnarchy
{
    public class ToolshelfAnarchy : ResoniteMod
    {
        public override string Name => "ToolshelfAnarchy";
        public override string Author => "art0007i";
        public override string Version => "2.0.0";
        public override string Link => "https://github.com/art0007i/ToolshelfAnarchy/";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("me.art0007i.ToolshelfAnarchy");
            harmony.PatchAll();

        }
        [HarmonyPatch(typeof(InteractionHandler))]
        [HarmonyPatch("ItemShelfFilter")]
        class InteractionHandler_ItemShelfFilter_Patch
        {
            public static bool Prefix(ref bool __result)
            {
                __result = true;
                return false;
            }
        }
    }
}