using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 SunofNothing: Uroza (URG, Yorion)
#02 FestiFan: Uroza (URG, Yorion)
#03 blackcat1922: Burn (WR, Lurrus)
#04 sokos13: UBRG Control (UBRG, Lurrus)
#05 LORiWWA: Amulet Titan (URG)
#06 Wisnia: Amulet Titan (URG)
#07 Chefen: Gruul Midrange (RG, Obosh)
#08 ZoeR: Burn (WR, Lurrus)
#09 xfile: Bant Control (WUG, Yorion)
#10 Neravius: Niv To Light (WUBRG, Jegantha)
#11 Sodeq: Amulet Titan (URG)
#12 SpiderSpace: Grinding Breach (WURG, Lurrus)
#13 falcon160: Jund Midrange (BRG, Lurrus)
#14 TSPJendrek: Dimir Control (UB, Lurrus)
#15 lovealienzzz: Delver (UBR, Lurrus)
#16 bomberboss: Humans (WUBRG)
#17 SaxManSax: Titan Shift (RG)
#18 forenmagra: Saheeli Combo (WUBRG, Yorion)
#19 exoticherman: Golgari Midrange (BG, Lurrus)
#20 ArchaeusDota: Eldrazi Tron (C)
#21 RealJoy: Infect (BG, Lurrus)
#22 musasabi: Heliod Combo (WG, Zirda)
#23 Bishark: Merfolk (WU, Lurrus)
#24 Milkk: Boros Prowess (WR, Lurrus)
#25 Aphiladon: Bant Control (WUG)
#26 aooaaooa: Gyruda Reanimator (WUG, Gyruda)
#27 Heir_of_Elendil15: Boros Prowess (WR, Lurrus)
#28 Mcleskey: Burn (WR)
#29 robb93: Golgari Midrange (BG, Lurrus)
#30 audio336: Bogles (WG, Lurrus)
#31 PRGJJAR: Dredge (BRG)
#32 _LSN_: Burn (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_04_26 : EventTest
    {
        [Test]
        public void Deck01_SunofNothing_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",0),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_FestiFan_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",1),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_blackcat1922_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",2),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_sokos13_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",3),
                "PostIkoria",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_LORiWWA_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",4),
                "PostIkoria",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_Wisnia_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",5),
                "PostIkoria",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_Chefen_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",6),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_ZoeR_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",7),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_xfile_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",8),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_Neravius_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",9),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_Sodeq_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",10),
                "PostIkoria",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_SpiderSpace_GrindingBreach_WURG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",11),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GrindingBreach",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_falcon160_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",12),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",13),
                "PostIkoria",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_lovealienzzz_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",14),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Delver",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",15),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck17_SaxManSax_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",16),
                "PostIkoria",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck18_forenmagra_SaheeliCombo_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",17),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "SaheeliCombo",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_exoticherman_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",18),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",19),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck21_RealJoy_Infect_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",20),
                "PostIkoria",
                ArchetypeColor.BG,
                "Infect",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_musasabi_HeliodCombo_WG_Zirda()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",21),
                "PostIkoria",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck23_Bishark_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",22),
                "PostIkoria",
                ArchetypeColor.WU,
                "Merfolk",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Milkk_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",23),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Aphiladon_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",24),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_aooaaooa_GyrudaReanimator_WUG_Gyruda()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",25),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GyrudaReanimator",
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck27_HeirofElendil15_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",26),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",27),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck29_robb93_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",28),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_audio336_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",29),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",30),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck32_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",31),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
