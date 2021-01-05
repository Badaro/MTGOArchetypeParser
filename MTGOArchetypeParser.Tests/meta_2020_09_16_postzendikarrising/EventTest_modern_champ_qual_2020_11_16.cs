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
#01 bigjc00: Amulet Titan (RG)
#02 MoxSquirrel: Heliod Combo (WR)
#03 Gerardo94: WURG Control (WURG)
#04 nekonekoneko: Shadow Prowess (WBR, Lurrus)
#05 Patxi: Dimir Control (UB)
#06 Oderus Urungus: Obosh Aggro (R, Obosh)
#07 Mulldrifter: Shadow Prowess (WBR, Lurrus)
#08 kogamo: WURG Control (WURG)
#09 MaxCapone: Oops All Spells (WUBG)
#10 Borjillamtg10: Rakdos Midrange (BR)
#11 Amplumnox: Heliod Combo (WG)
#12 Poyo_del_Mal: Belcher (URG)
#13 ColdPier: Thopter Urza (WUBR)
#14 azax: Reclaimer Titan (WG)
#15 Damgar: Green Tron (G)
#16 jvidarte: Burn (WR, Lurrus)
#17 katuo079595: Shadow Prowess (BR, Lurrus)
#18 FreedMania: Amulet Titan (RG)
#19 sendoh007: Jund Midrange (BRG)
#20 BradPitKeeper: WURG Control (WURG)
#21 billsive: Sultai Control (UBG)
#22 Violent_Outburst: Scapeshift (URG)
#23 Moniz0801: Amulet Titan (G)
#24 Mateusf34: Eldrazi Tron (C)
#25 yamakiller: Obosh Aggro (R, Obosh)
#26 BReal2: Shadow Prowess (BR, Lurrus)
#27 nazart: Heliod Combo (WG)
#28 ShowTime_: Jund Midrange (BRG)
#29 fingers1991: WURG Control (WURG)
#30 mechint: Temur Control (URG)
#31 MadMaxErnst: Jund Shadow (BRG, Lurrus)
#32 exoticherman: Shadow Prowess (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_champ_qual_2020_11_16 : EventTest
    {
        [Test]
        public void Deck01_bigjc00_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",0),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_MoxSquirrel_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",1),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_nekonekoneko_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",3),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Patxi_DimirControl_UB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",4),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_OderusUrungus_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",5),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_Mulldrifter_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",6),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_kogamo_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Borjillamtg10_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Amplumnox_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",10),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck12_PoyodelMal_Belcher_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",11),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ColdPier_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",12),
                new PostZendikarRising(),
                ArchetypeColor.WUBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck14_azax_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",13),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck15_Damgar_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",14),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck16_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",15),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_katuo079595_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_FreedMania_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",17),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_sendoh007_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",18),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_BradPitKeeper_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",19),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_billsive_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",20),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",21),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Moniz0801_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",22),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",23),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck25_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",24),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck26_BReal2_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",25),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",26),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ShowTime_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",27),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_fingers1991_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",28),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_mechint_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",29),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_MadMaxErnst_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",30),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_exoticherman_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",31),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
