using FunnyCharacters.Customs.Abstract;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace FunnyCharacters.Customs.FullBody
{
    public class PalmTree : BaseFunnyCostume
    {
        public override string UniqueNameID => "PalmTree";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;

        public override void OnRegister(PlayerCosmetic playerCosmetic)
        {
            base.OnRegister(playerCosmetic);

            PlayerOutfitComponent playerOutfitComponent = playerCosmetic.Visual.GetComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Palm_001").GetComponent<SkinnedMeshRenderer>());
        }
    }
}