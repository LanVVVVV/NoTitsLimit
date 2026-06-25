using HarmonyLib;
using MBMScripts;

namespace NoTitsLimit.Patches;

[HarmonyPatch(typeof(Character))]
public static class CharacterPatch
{
    [HarmonyPatch(nameof(Character.TitsType), MethodType.Getter)]
    [HarmonyPrefix]
    public static bool TitsTypePrefix(Character __instance, ref int __result)
    {
        SeqDataBinding.Instance.RegisterFlag(__instance, "TitsType");
        if (__instance.TraitContains(ETrait.Trait105))
        {
            __result = GameManager.ConfigData.MaxMilkArray.Length - 1;
        }
        else
        {
            __result = __instance.RawTitsType;
        }
        return false;
    }

    [HarmonyPatch(nameof(Character.MaxMilk), MethodType.Getter)]
    [HarmonyPostfix]
    [HarmonyPriority(Priority.Low)]
    public static void MaxMilkPostfix(Character __instance, ref float __result)
    {
        if(__instance.IsChild && __instance.TitsType != 0)
            __result *= 0.5f;
    }
}