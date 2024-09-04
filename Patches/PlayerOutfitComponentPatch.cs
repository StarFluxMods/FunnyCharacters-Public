using HarmonyLib;
using Kitchen;
using UnityEngine;

namespace FunnyCharacters.Patches
{
    [HarmonyPatch(typeof(PlayerOutfitComponent), "SetupBones")]
    public class PlayerOutfitComponentPatch
    {
        static void Postfix(PlayerOutfitComponent __instance, SkinnedMeshRenderer source)
        {
            if (__instance.AttachToHeadBone != null && __instance.AttachToHeadBone.name == "Backpack_023_Blade")
            {
                foreach (Transform transform in source.bones)
                {
                    if (transform.name == "UpperSpine" && __instance.AttachToHeadBone != null)
                    {
                        __instance.AttachToHeadBone.transform.parent = transform.transform;
                        __instance.AttachToHeadBone.transform.Reset();
                        __instance.AttachToHeadBone.transform.localPosition += new Vector3(0, 0.0295f, 0);
                    }
                }
            }
        }
    }
}