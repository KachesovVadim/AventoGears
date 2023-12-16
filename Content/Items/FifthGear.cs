using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AventoGears.Content.Items
{
    public class FifthGear : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;
            Item.accessory = true;
            Item.value = Item.sellPrice(platinum: 300);
            Item.rare = ItemRarityID.Master;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 1000f;
            player.GetCritChance(DamageClass.Generic) += 1000f;
            player.GetAttackSpeed(DamageClass.Generic) += 4f;
            player.statDefense += player.statDefense * 10000;
            player.statLifeMax2 += player.statLifeMax2 * 100;
            player.inferno = true;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.FallenStar, 524)
                .AddIngredient(ItemID.TerraToilet, 3)
                .Register();
        }
    }
}