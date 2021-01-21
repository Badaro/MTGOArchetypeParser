using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 pootisgodsamongus: Obosh Aggro (R, Obosh)
#02 Reynad: Jund Midrange (BRG)
#03 RearrangedAS: Spirits (WU)
#04 Phill_Hellmuth: Gruul Midrange (RG)
#05 TebbeBear: Ad Nauseam (WUB)
#06 mathguy31415: Green Tron (G)
#07 Chuckles1248: Ad Nauseam (WUB)
#08 slow_brz: Mardu Shadow (WBR)
#09 SKK: Belcher (RG)
#10 D00mwake: Mill (UB, Lurrus)
#11 oshea: Humans (WUBRG)
#12 bmwracer0: Green Tron (G)
#13 Alucart: Jund Midrange (BRG)
#14 SebastianStueckl: Gruul Midrange (RG)
#15 Xwhale: Humans (WUBRG)
#16 ThekingFor1000years: Infect (WUG)
#17 Kricha13: WURG Control (WURG)
#18 Oderus Urungus: Humans (WUBRG)
#19 ghostx02: Gruul Midrange (RG)
#20 beastista: Azorius Control (WU)
#21 Toastxp: Gruul Midrange (RG)
#22 ThePurplecow777: Bogles (WG)
#23 Diatomic: Gruul Midrange (RG)
#24 TubbyBatman: Delver (UR)
#25 Slinker80: Burn (WR, Lurrus)
#26 SuperCow12653: Jund Midrange (BRG)
#27 MagicCardsFunFunFun: Gruul Midrange (RG)
#28 nsroller: Rakdos Prowess (BR, Lurrus)
#29 Strox: Jund Midrange (BRG)
#30 Databyss: Mill (UB)
#31 Patxi: Humans (WUBRG)
#32 ScorpionDeathDrop: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_champs_2020_09_21 : EventTest
    {
        [Test]
        public void Deck01_pootisgodsamongus_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",0),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Reynad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",1),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_RearrangedAS_Spirits_WU()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",2),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck04_PhillHellmuth_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",3),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_TebbeBear_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",4),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck06_mathguy31415_GreenTron_G()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",5),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_Chuckles1248_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",6),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck08_slowbrz_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",7),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck09_SKK_Belcher_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",8),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck10_D00mwake_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",9),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_oshea_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",10),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck12_bmwracer0_GreenTron_G()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",11),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck13_Alucart_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",12),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",13),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Xwhale_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",14),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck16_ThekingFor1000years_Infect_WUG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",15),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Kricha13_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",16),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_OderusUrungus_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",17),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck19_ghostx02_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",18),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_beastista_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",19),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Toastxp_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",20),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_ThePurplecow777_Bogles_WG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",21),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Diatomic_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",22),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck24_TubbyBatman_Delver_UR()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",23),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "Delver",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Slinker80_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",24),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_SuperCow12653_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",25),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck27_MagicCardsFunFunFun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",26),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck28_nsroller_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",27),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Strox_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",28),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Databyss_Mill_UB()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",29),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Patxi_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",30),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck32_ScorpionDeathDrop_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",31),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
