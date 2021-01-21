using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Tweedel: Obosh Aggro (R, Obosh)
#02 Rulleboren: Mill (UB, Lurrus)
#03 daibloXSC: Erayo Prison (WUB)
#04 LordAbyss: Eldrazi Tron (C)
#05 RespectTheCat: Rakdos Midrange (BR)
#06 Tiemuuu: Izzet Control (UR)
#07 rodeo: Oops All Spells (WUBG)
#08 mechint: Amulet Titan (G)
#09 starfall: Shadow Prowess (BR, Lurrus)
#10 SoulStrong: Bant Blink (WUG)
#11 _Batutinha_: Reclaimer Titan (WRG)
#12 Nytrox: Heliod Combo (WG)
#13 mariogomes097: Hammer Time (W, Lurrus)
#14 WhiteOleander: Green Tron (G)
#15 billster47: Hammer Time (W, Lurrus)
#16 Binolino: Reclaimer Titan (WRG)
#17 patheus_84: Ad Nauseam (WUB)
#18 Parrit: Mono White Taxes (W)
#19 Javipv: Reclaimer Titan (WRG)
#20 pokerswizard: Shadow Prowess (BR, Lurrus)
#21 Raptor_Nachos: Burn (WR)
#22 ACG88: Green Tron (G)
#23 Metcalf23: Mono White Taxes (W)
#24 killersuv: Green Tron (G)
#25 Amplumnox: Hammer Time (W, Lurrus)
#26 nahuel10: Izzet Prowess (UR)
#27 Poyo_del_Mal: Heliod Combo (WG)
#28 mala_grinja: Shadow Prowess (BRG, Lurrus)
#29 MaxCapone: Oops All Spells (WUBG)
#30 Better_than_Average: Obosh Aggro (R, Obosh)
#31 random_deck: Selesnya Midrange (WG)
#32 musasabi: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_30 : EventTest
    {
        [Test]
        public void Deck01_Tweedel_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",0),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Rulleboren_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",1),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_daibloXSC_ErayoPrison_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",2),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "ErayoPrison",
                null,
                null
            );
        }

        [Test]
        public void Deck04_LordAbyss_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",3),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_RespectTheCat_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",5),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_rodeo_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",6),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck08_mechint_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",7),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck09_starfall_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",8),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_SoulStrong_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",9),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Batutinha_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",10),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck12_Nytrox_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",11),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck13_mariogomes097_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",12),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_WhiteOleander_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",13),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck15_billster47_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",14),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Binolino_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",15),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck17_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",16),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",17),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Javipv_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",18),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck20_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",19),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_RaptorNachos_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",20),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck22_ACG88_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",21),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck23_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",22),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck24_killersuv_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",23),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck25_Amplumnox_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",24),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",25),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck27_PoyodelMal_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",26),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck28_malagrinja_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",27),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",28),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck30_BetterthanAverage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",29),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck31_randomdeck_SelesnyaMidrange_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",30),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck32_musasabi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-30",31),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
