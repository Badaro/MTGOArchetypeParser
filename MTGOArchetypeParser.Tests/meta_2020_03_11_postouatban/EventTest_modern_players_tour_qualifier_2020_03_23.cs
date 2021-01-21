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
#01 Mistakenn: Amulet Titan (UG)
#02 tangrams: Uroza (URG)
#03 msskinbolic: Dredge (UBRG)
#04 __BMJ__: Titan Shift (RG)
#05 MentalMisstep: WUBG Control (WUBG)
#06 alithinar: Jund Midrange (BRG)
#07 Bayesta_93: Green Tron (G)
#08 Linsanity96: Uroza (URG)
#09 mikeleee: Humans (WUBRG)
#10 cws: Gifts Storm (URG)
#11 Dia83: Amulet Titan (G)
#12 BlueLips: Bant Control (WUG)
#13 DFrank: Uroza (URG)
#14 ScreenwriterNY: Bushwhacker Zoo (WRG)
#15 qbturtle15: Gruul Midrange (RG)
#16 603Leb: Amulet Titan (UG)
#17 Rav104: Primeval Titan (UG)
#18 bigjc00: Eldrazi Tron (C)
#19 mdvayu2: Saheeli Combo (WURG)
#20 Gerardo94: Humans (WUBRG)
#21 LalauWBA: Gruul Midrange (RG)
#22 katoriarch123: Bant Control (WUG)
#23 johnyvolta: Kiki Chord (WURG)
#24 il_matagatto: Burn (WR)
#25 remf: Gruul Midrange (RG)
#26 medvedev: Bant Control (WUG)
#27 Hayseed: Thopter Urza (WU)
#28 Antarctica: Green Tron (G)
#29 AshesAshes: Mono Red Prowess (R)
#30 idutra: Gruul Midrange (RG)
#31 TombSimon: Green Tron (G)
#32 joetru: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_players_tour_qualifier_2020_03_23 : EventTest
    {
        [Test]
        public void Deck01_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",0),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_tangrams_Uroza_URG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",1),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck03_msskinbolic_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",2),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_BMJ_TitanShift_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",3),
                "PostOuatBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck05_MentalMisstep_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",4),
                "PostOuatBan",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_alithinar_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",5),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Bayesta93_GreenTron_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",6),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck08_Linsanity96_Uroza_URG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",7),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck09_mikeleee_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",8),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck10_cws_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",9),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Dia83_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",10),
                "PostOuatBan",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_BlueLips_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",11),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_DFrank_Uroza_URG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",12),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck14_ScreenwriterNY_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",13),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck15_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",14),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_603Leb_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",15),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck17_Rav104_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",16),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck18_bigjc00_EldraziTron_C()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",17),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck19_mdvayu2_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",18),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Gerardo94_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",19),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck21_LalauWBA_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",20),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",21),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_johnyvolta_KikiChord_WURG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",22),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "KikiChord",
                null,
                null
            );
        }

        [Test]
        public void Deck24_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",23),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck25_remf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",24),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck26_medvedev_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",25),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Hayseed_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",26),
                "PostOuatBan",
                ArchetypeColor.WU,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck28_Antarctica_GreenTron_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",27),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck29_AshesAshes_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",28),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck30_idutra_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",29),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_TombSimon_GreenTron_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",30),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck32_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",31),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
