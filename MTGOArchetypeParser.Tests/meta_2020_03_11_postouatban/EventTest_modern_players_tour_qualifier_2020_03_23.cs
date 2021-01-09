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
#01 Mistakenn: Amulet Titan (G)
#02 tangrams: Uroza (UG)
#03 msskinbolic: Dredge (BRG)
#04 __BMJ__: Titan Shift (RG)
#05 MentalMisstep: WUBG Control (WUBG)
#06 alithinar: Jund Midrange (BRG)
#07 Bayesta_93: Green Tron (G)
#08 Linsanity96: Uroza (UG)
#09 mikeleee: Humans (WUBRG)
#10 cws: Gifts Storm (URG)
#11 Dia83: Amulet Titan (G)
#12 BlueLips: Bant Control (WUG)
#13 DFrank: Uroza (UG)
#14 ScreenwriterNY: Bushwhacker Zoo (WRG)
#15 qbturtle15: Gruul Midrange (RG)
#16 603Leb: Amulet Titan (G)
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
        public void Deck01_Mistakenn_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",0),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_tangrams_Uroza_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",1),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_msskinbolic_Dredge_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",2),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_BMJ_TitanShift_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",3),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck05_MentalMisstep_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",4),
                new PostOuatBan(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_alithinar_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",5),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Bayesta93_GreenTron_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",6),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck08_Linsanity96_Uroza_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",7),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_mikeleee_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",8),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_cws_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",9),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Dia83_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",10),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_BlueLips_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",11),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_DFrank_Uroza_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",12),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ScreenwriterNY_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",13),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck15_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",14),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_603Leb_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",15),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck17_Rav104_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",16),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck18_bigjc00_EldraziTron_C()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",17),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_mdvayu2_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",18),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Gerardo94_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",19),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck21_LalauWBA_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",20),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",21),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_johnyvolta_KikiChord_WURG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",22),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                null
            );
        }

        [Test]
        public void Deck24_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",23),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_remf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",24),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_medvedev_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",25),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Hayseed_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",26),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck28_Antarctica_GreenTron_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",27),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck29_AshesAshes_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",28),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck30_idutra_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",29),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_TombSimon_GreenTron_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",30),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck32_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-23",31),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
