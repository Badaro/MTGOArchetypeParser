using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 BERNASTORRES: WURG Control (WURG)
#02 FreedMania: Amulet Titan (RG)
#03 _Stream: Shadow Prowess (BRG, Lurrus)
#04 ChironTheMage: WURG Control (WURG)
#05 Chrhey: Izzet Prowess (UR)
#06 SoulStrong: Reclaimer Titan (WRG)
#07 Ennuixd: Amulet Titan (URG)
#08 oskiyaa: Scapeshift (URG)
#09 Tiemuuu: Izzet Control (UR)
#10 Darkiundsa: WURG Control (WURG)
#11 Traft: Ad Nauseam (WUB)
#12 RagingTiltMonster: Devoted (WG, Lurrus)
#13 Bedell: Reclaimer Titan (WRG)
#14 joetru: Niv To Light (WUBRG)
#15 weishengzhishabi: Sultai Control (UBG)
#16 Gobern: Reclamation (UBRG)
#17 Kaizer_Kahn: Obosh Aggro (R, Obosh)
#18 HouseOfManaMTG: Amulet Titan (RG)
#19 sendoh007: Gruul Midrange (RG)
#20 RespectTheCat: Azorius Taxes (WU, Yorion)
#21 NorrathDecay: Burn (WR)
#22 Kaies: Shadow Prowess (BR, Lurrus)
#23 JUJUBEAN__2004: UBRG Control (UBRG)
#24 Asoen: Rakdos Midrange (BR)
#25 msskinbolic: Heliod Combo (W)
#26 SickWorld: Amulet Titan (RG)
#27 Vasoi2323: Jund Shadow (BRG)
#28 stefanocanclini: Reclaimer Titan (WG)
#29 Gabriel_Sylar: Jund Midrange (BRG)
#30 Lordzedane: Jund Midrange (BRG, Lurrus)
#31 musasabi: Omnath Saheeli (WURG, Jegantha)
#32 RandomDrooler: Belcher (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_champ_qual_2020_11_02 : EventTest
    {
        [Test]
        public void Deck01_BERNASTORRES_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_FreedMania_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",1),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_Stream_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",2),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_ChironTheMage_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Chrhey_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",4),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_SoulStrong_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",5),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck07_Ennuixd_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",6),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_oskiyaa_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",7),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Darkiundsa_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",9),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",10),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_RagingTiltMonster_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",11),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Bedell_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",12),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck14_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",13),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck15_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",14),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Gobern_Reclamation_UBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",15),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck17_KaizerKahn_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",16),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_HouseOfManaMTG_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",17),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck19_sendoh007_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",18),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_RespectTheCat_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",19),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",20),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck22_Kaies_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",21),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",22),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",23),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_msskinbolic_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",24),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck26_SickWorld_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",25),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck27_Vasoi2323_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",26),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck28_stefanocanclini_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",27),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck29_GabrielSylar_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",28),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Lordzedane_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",29),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_musasabi_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",30),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck32_RandomDrooler_Belcher_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-11-02",31),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }


    }
}
