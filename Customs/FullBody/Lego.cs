using FunnyCharacters.Customs.Abstract;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace FunnyCharacters.Customs.FullBody
{
    public class Lego : BaseFunnyCostume
    {
        public override string UniqueNameID => "Lego";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;

        public override void OnRegister(PlayerCosmetic playerCosmetic)
        {
            base.OnRegister(playerCosmetic);

            PlayerOutfitComponent playerOutfitComponent = playerCosmetic.Visual.GetComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Lego_001").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Lego_001.001").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Hats.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Lego_001.001").GetComponent<SkinnedMeshRenderer>());
        }
    }
}