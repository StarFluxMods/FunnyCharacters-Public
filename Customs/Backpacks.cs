using FunnyCharacters.Customs.Abstract;
using FunnyCharacters.MonoBehaviours;
using FunnyCharacters.Patches;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace FunnyCharacters.Customs
{
    public class Backpack_000 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_000";
        public override GameObject Visual => new();
    }

    public class Backpack_001 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_001";
    }

    public class Backpack_002 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_002";
    }

    public class Backpack_003 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_003";
    }

    public class Backpack_004 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_004";
    }

    public class Backpack_005 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_005";
    }

    public class Backpack_006 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_006";
    }

    public class Backpack_007 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_007";
    }

    public class Backpack_008 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_008";
    }

    public class Backpack_009 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_009";
    }

    public class Backpack_010 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_010";
    }

    public class Backpack_011 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_011";
    }

    public class Backpack_012 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_012";
    }

    public class Backpack_013 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_013";
    }

    public class Backpack_014 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_014";
    }

    public class Backpack_015 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_015";
    }

    public class Backpack_016 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_016";
    }

    public class Backpack_017 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_017";
    }

    public class Backpack_018 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_018";
    }

    public class Backpack_019 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_019";
    }

    public class Backpack_020 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_020";
    }

    public class Backpack_021 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_021";
    }

    public class Backpack_022 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_022";
    }

    public class Backpack_023 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_023";

        public override void OnRegister(PlayerCosmetic playerCosmetic)
        {
            base.OnRegister(playerCosmetic);
            PlayerOutfitComponent playerOutfitComponent = playerCosmetic.Visual.GetComponent<PlayerOutfitComponent>();
            playerOutfitComponent.AttachToHeadBone = playerCosmetic.Visual.GetChild("Backpack_023_Blade");
            BetterSpinByWorldPosition spinner = playerCosmetic.Visual.GetChild("Backpack_023_Blade").AddComponent<BetterSpinByWorldPosition>();
            spinner.SpinAxis = Vector3.back;
            spinner.SpinDuringGameplay = true;
            spinner.SpinRate = 1000;
            spinner.GrowRate = 2;
            spinner.DecayRate = 0.5f;
        }
    }

    public class Backpack_024 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_024";
    }

    public class Backpack_025 : CustomBackpack
    {
        public override string UniqueNameID => "Backpack_025";
    }
}