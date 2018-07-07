using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BorkMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class BorkHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded helmet.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 35;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("BorkBreastplate") && legs.type == mod.ItemType("BorkLeggings");
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.15f;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Ultimate Supreme Power!";
			player.meleeDamage *= 10.0f;
			player.thrownDamage *= 10.0f;
			player.rangedDamage *= 10.0f;
			player.magicDamage *= 10.0f;
			player.minionDamage *= 10.0f;
			player.moveSpeed += 0.45f;
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