using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BorkMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class GodSlayerLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded leg armor."
				+ "\n5% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 120;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.95f;
			player.statLifeMax2 += 500;
			player.statLife += 500;
			player.meleeDamage *= 1.25f;
			player.thrownDamage *= 1.25f;
			player.rangedDamage *= 1.25f;
			player.magicDamage *= 1.25f;
			player.meleeCrit += 15;
			player.doubleJumpCloud = true;
			player.doubleJumpUnicorn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}