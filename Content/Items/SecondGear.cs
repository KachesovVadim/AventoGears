using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AventoGears.Content.Items
{
    public class SecondGear : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;
            Item.accessory = true;
            Item.value = Item.sellPrice(gold: 220);
            Item.rare = ItemRarityID.Pink;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 1f;
            player.GetCritChance(DamageClass.Generic) += .7f;
            player.GetAttackSpeed(DamageClass.Generic) += 1f;
            player.statDefense += player.statDefense;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldOre, 170)
                .AddIngredient(ItemID.PlatinumOre, 110)
                .Register();
        }
    }
}