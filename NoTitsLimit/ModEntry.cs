using MBM.ModLoader.Core;
//using NoTitsLimit.Properties;
using UnityEngine;

namespace NoTitsLimit;

public static class ModEntry
{
    internal const string ModName = "NoTitsLimit";

    public static void Load()
    {
        //Localization.OnLanguageChanged += OnLanguageChanged;
        Log($"{ModName} Mod loaded!");
    }

    internal static void Log(string msg) => Debug.Log($"[NTL] {msg}");

    internal static void LogWarning(string msg) => Debug.LogWarning($"[NTL] {msg}");

    internal static void LogError(string msg) => Debug.LogError($"[NTL] {msg}");

    //private static void OnLanguageChanged(string langCode)
    //{
    //    Strings.Culture = Localization.CurrentCulture;

    //    Log($"language changed: {langCode}");
    //}
}