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
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_MoxSquirrel_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",1),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_nekonekoneko_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",3),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Patxi_DimirControl_UB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",4),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_OderusUrungus_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",5),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_Mulldrifter_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",6),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_kogamo_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",8),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Borjillamtg10_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",9),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Amplumnox_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",10),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck12_PoyodelMal_Belcher_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",11),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck13_ColdPier_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",12),
                "PostZendikarRising",
                ArchetypeColor.WUBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck14_azax_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",13),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck15_Damgar_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",14),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck16_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",15),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_katuo079595_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",16),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_FreedMania_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",17),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck19_sendoh007_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",18),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_BradPitKeeper_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",19),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_billsive_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",20),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",21),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Moniz0801_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",22),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck24_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",23),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck25_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",24),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck26_BReal2_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",25),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",26),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck28_ShowTime_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",27),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck29_fingers1991_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",28),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_mechint_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",29),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_MadMaxErnst_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",30),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_exoticherman_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-16",31),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
