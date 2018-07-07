using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BorkMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GodSlayerHelmet : ModItem
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
			item.defense = 150;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GodSlayerBreastplate") && legs.type == mod.ItemType("GodSlayerLeggings");
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statLifeMax2 += 500;
			player.statLife += 500;
			player.statManaMax2 += 200;
			player.statMana += 200;
			player.meleeDamage *= 1.25f;
			player.thrownDamage *= 1.25f;
			player.rangedDamage *= 1.25f;
			player.magicDamage *= 1.25f;
		}

		public override bool ConsumeAmmo(Player player)
		{
			// 50% chance to not consume ammo
			return Main.rand.NextFloat() >= .50f;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Ultimate Supreme Power!";
			player.meleeDamage *= 10.0f;
			player.thrownDamage *= 10.0f;
			player.rangedDamage *= 10.0f;
			player.magicDamage *= 10.0f;
			player.minionDamage *= 10.0f;
			player.maxRunSpeed += 10.95f;
			player.runAcceleration += 0.10f;
			player.endurance += 0.60f;
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