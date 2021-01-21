using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 carlosalmeida: Gruul Midrange (RG)
#02 Daking3603: Mono Red Prowess (R)
#03 MATTHEWFOULKES: Green Tron (G)
#04 _Batutinha_: Bant Control (WUG)
#05 Lord_Beerus: Burn (WR)
#06 in5ano: Thopter Urza (WUR)
#07 Bertram: Dredge (BRG)
#08 Mateusf34: Eldrazi Tron (C)
#09 LORiWWA: Eldrazi Tron (C)
#10 cometa183: Bant Control (WUG)
#11 AlabasterWolfie: Grinding Breach (UBR)
#12 TradewindRider: Bant Control (WUG)
#13 ecobaronen: Bant Control (WUG)
#14 achillies27: Gifts Storm (URG)
#15 TheTunnelingCat: Eldrazi Tron (C)
#16 Sungjin: Scapeshift (WURG)
#17 MayoDominaria: Bushwhacker Zoo (WRG)
#18 BaronOfBacon: Mono Red Prowess (R)
#19 Graciasportanto: Uroza (URG)
#20 twinlesstwin: Reclamation (UG)
#21 Do0mSwitch: Bant Control (WUG)
#22 bstee: Dredge (BRG)
#23 NAP_DARKMAGE_MJM: Humans (WUBRG)
#24 dgreen16: Mill (UB)
#25 Gerardo94: Bant Control (WUG)
#26 medvedev: Humans (WUBRG)
#27 J000111: Dredge (BRG)
#28 FalseMufn: Amulet Titan (UG)
#29 PRGJJAR: Dredge (BRG)
#30 SCJ: Uroza (URG)
#31 Tarmofir3: Jund Midrange (BRG)
#32 jvidarte: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_players_tour_qualifier_2020_03_30 : EventTest
    {
        [Test]
        public void Deck01_carlosalmeida_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",0),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Daking3603_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",1),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_MATTHEWFOULKES_GreenTron_G()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",2),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",3),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",4),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck06_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",5),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck07_Bertram_Dredge_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",6),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",7),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_LORiWWA_EldraziTron_C()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",8),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_cometa183_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",9),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_AlabasterWolfie_GrindingBreach_UBR()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",10),
                "PostOuatBan",
                ArchetypeColor.UBR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck12_TradewindRider_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",11),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",12),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_achillies27_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",13),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck15_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",14),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck16_Sungjin_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",15),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck17_MayoDominaria_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",16),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck18_BaronOfBacon_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",17),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck19_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",18),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck20_twinlesstwin_Reclamation_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",19),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",20),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_bstee_Dredge_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",21),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck23_NAPDARKMAGEMJM_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",22),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck24_dgreen16_Mill_UB()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",23),
                "PostOuatBan",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Gerardo94_BantControl_WUG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",24),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_medvedev_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",25),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck27_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",26),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck28_FalseMufn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",27),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck29_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",28),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck30_SCJ_Uroza_URG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",29),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Tarmofir3_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",30),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck32_jvidarte_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-players-tour-qualifier-2020-03-30",31),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
