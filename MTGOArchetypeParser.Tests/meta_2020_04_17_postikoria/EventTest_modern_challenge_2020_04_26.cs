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
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_FestiFan_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",1),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_blackcat1922_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",2),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_sokos13_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",3),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_LORiWWA_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",4),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_Wisnia_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",5),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_Chefen_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",6),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_ZoeR_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_xfile_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",8),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_Neravius_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",9),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_Sodeq_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",10),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_SpiderSpace_GrindingBreach_WURG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",11),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GrindingBreach),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_falcon160_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",12),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",13),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_lovealienzzz_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",14),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",15),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SaxManSax_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",16),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck18_forenmagra_SaheeliCombo_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",17),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_exoticherman_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",18),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",19),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck21_RealJoy_Infect_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",20),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_musasabi_HeliodCombo_WG_Zirda()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",21),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck23_Bishark_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",22),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Milkk_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",23),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Aphiladon_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",24),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_aooaaooa_GyrudaReanimator_WUG_Gyruda()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",25),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GyrudaReanimator),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck27_HeirofElendil15_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",26),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",27),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck29_robb93_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",28),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_audio336_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",29),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",30),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck32_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-26",31),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
