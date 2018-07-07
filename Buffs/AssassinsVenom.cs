using System;
using Terraria;
using Terraria.ModLoader;

namespace BorkMod.Buffs
{
	public class AssassinsVenom : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("You've been poisoned badly!");
			Description.SetDefault("Time to lose some HP bucko.");
			canBeCleared = false;
			longerExpertDebuff = true;
			Main.debuff[Type] = true;
		}

        public override void Update(NPC npc, ref int buffIndex)
		{
			// npc.lifeMax -= 10;
			// npc.lifeRegen = -50;
			// npc.lifeRegen = -(npc.lifeMax / 10);
			npc.lifeRegen = -(npc.lifeMax / 2 );
		}
		
		public override void Update(Player player, ref int buffIndex)
		{
			player.statLife -= 10;
		}
	}
}