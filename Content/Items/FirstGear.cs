using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AventoGears.Content.Items
{
    public class FirstGear : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;
            Item.accessory = true;
            Item.value = Item.sellPrice(gold: 90);
            Item.rare = ItemRarityID.LightRed;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += .5f;
            player.GetCritChance(DamageClass.Generic) += .5f;
            player.GetAttackSpeed(DamageClass.Generic) += .5f;
            player.statDefense += player.statDefense * .5f;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldOre, 70)
                .AddIngredient(ItemID.PlatinumOre, 30)
                .Register();
        }
    }
}