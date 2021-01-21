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
#01 Lavaridge: Sultai Control (UBG)
#02 sfitz: Thopter Urza (UBR)
#03 Larry11: Gruul Midrange (RG)
#04 Polikasoll: Burn (R)
#05 ZYURYO: Jund Midrange (BRG)
#06 Lord_Beerus: Burn (WR)
#07 sff_mtg: Green Tron (G)
#08 Gigy: Gruul Midrange (RG)
#09 kiko: Boros Taxes (WR)
#10 TennTyou: Niv To Light (WUBRG)
#11 Smosh: Eldrazi Tron (C)
#12 WeareVenom: Bant Control (WUG)
#13 Nekonii: Elves (BG)
#14 Mogged: Mono Red Prowess (R)
#15 PizzaTurtle: Bogles (WG, Lurrus)
#16 unicornparadise: Eldrazi Tron (C)
#17 Fabrice_K: Reclamation (UBG, Yorion)
#18 MrRaeb: Uroza (UBG, Yorion)
#19 tuckbear: Burn (WR)
#20 Lopik6: Amulet Titan (URG)
#21 MikeEgan: Gruul Midrange (RG)
#22 PvtEnormous: Mono Red Prowess (R)
#23 eXavie: Sultai Control (UBG)
#24 Ryan100495: Dredge (WBRG)
#25 destinction: Jund Midrange (BRG)
#26 JUJUBEAN__2004: Bant Control (WUG)
#27 Tiemuuu: Izzet Control (UR)
#28 Venom1: Eldrazi Tron (C)
#29 otakkun: Green Tron (G)
#30 Jack_Kashtan: Gifts Storm (UR)
#31 Skrown: Dredge (WBRG)
#32 Erik157751: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_07_13 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",0),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_sfitz_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",1),
                "PostM21",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck03_Larry11_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",2),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Polikasoll_Burn_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",3),
                "PostM21",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck05_ZYURYO_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",4),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",5),
                "PostM21",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",6),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck08_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",7),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_kiko_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",8),
                "PostM21",
                ArchetypeColor.WR,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck10_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",9),
                "PostM21",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Smosh_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",10),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",11),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nekonii_Elves_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",12),
                "PostM21",
                ArchetypeColor.BG,
                "Elves",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Mogged_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",13),
                "PostM21",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck15_PizzaTurtle_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",14),
                "PostM21",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_unicornparadise_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",15),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_FabriceK_Reclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",16),
                "PostM21",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",17),
                "PostM21",
                ArchetypeColor.UBG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_tuckbear_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",18),
                "PostM21",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck20_Lopik6_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",19),
                "PostM21",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck21_MikeEgan_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",20),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_PvtEnormous_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",21),
                "PostM21",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_eXavie_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",22),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Ryan100495_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",23),
                "PostM21",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck25_destinction_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",24),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck26_JUJUBEAN2004_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",25),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",26),
                "PostM21",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Venom1_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",27),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck29_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",28),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck30_JackKashtan_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",29),
                "PostM21",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Skrown_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",30),
                "PostM21",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Erik157751_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",31),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
