using FunnyCharacters.Customs.Abstract;
using Kitchen;
using KitchenData;
using KitchenLib.Utils;
using UnityEngine;

namespace FunnyCharacters.Customs.FullBody
{
    public class Sushi : BaseFunnyCostume
    {
        public override string UniqueNameID => "Sushi";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;

        public override void OnRegister(PlayerCosmetic playerCosmetic)
        {
            base.OnRegister(playerCosmetic);

            PlayerOutfitComponent playerOutfitComponent = playerCosmetic.Visual.GetComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Sushi_001.001").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Sushi_001").GetComponent<SkinnedMeshRenderer>());
            playerOutfitComponent.Hats.Add(GameObjectUtils.GetChildObject(playerCosmetic.Visual, "Sushi_001").GetComponent<SkinnedMeshRenderer>());
        }
    }
}