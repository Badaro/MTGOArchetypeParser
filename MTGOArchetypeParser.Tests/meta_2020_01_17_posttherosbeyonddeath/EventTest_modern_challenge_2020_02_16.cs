using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 TSPJendrek: Azorius Control (WU)
#02 Genxim: Ad Nauseam (WUB)
#03 KelMasterP: Gruul Midrange (RG)
#04 phol: Amulet Titan (UG)
#05 bigjc00: Amulet Titan (UG)
#06 offline: Amulet Titan (UG)
#07 Bullwinkkle6705: UBRG Shadow (UBRG)
#08 Darkwonyx: Amulet Titan (UG)
#09 Tiemuuu: Izzet Control (UR)
#10 cloudthresher77: Eldrazi Tron (C)
#11 Yooisa: Primeval Titan (UG)
#12 VTCLA: Amulet Titan (UG)
#13 bntrusty14: Mardu Midrange (WBR)
#14 angelsjeffrey: Mono Red Prowess (R)
#15 Bayris: Jund Midrange (BRG)
#16 HannoLee: Uroza (URG)
#17 madechai: Thopter Urza (UBG)
#18 LordoftheLobsters: Uroza (UG)
#19 AlabasterWolfie: Grinding Breach (UBR)
#20 Jenara19: Amulet Titan (UG)
#21 Xeroo: Mardu Shadow (WBR)
#22 Magic4everStoreShop6: Mono Red Prowess (R)
#23 __matsugan: Neobrand (UG)
#24 Twibs: Green Tron (G)
#25 Chefen: Eldrazi Tron (G)
#26 Fugate: Neobrand (UG)
#27 cavedan: Niv To Light (WUBRG)
#28 Chris_Concarnage: Eldrazi Tron (G)
#29 instantdeath929: Amulet Titan (UG)
#30 shadow_PT: Neobrand (UG)
#31 lsv: Thopter Urza (UB)
#32 Kazuga: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_challenge_2020_02_16 : EventTest
    {
        [Test]
        public void Deck01_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Genxim_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck03_KelMasterP_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_phol_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_bigjc00_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_offline_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_Bullwinkkle6705_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Darkwonyx_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck09_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_cloudthresher77_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_Yooisa_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck12_VTCLA_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck13_bntrusty14_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_angelsjeffrey_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck15_Bayris_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_HannoLee_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck17_madechai_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck18_LordoftheLobsters_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck19_AlabasterWolfie_GrindingBreach_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Jenara19_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck21_Xeroo_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Magic4everStoreShop6_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Twibs_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck25_Chefen_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck26_Fugate_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck27_cavedan_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck28_ChrisConcarnage_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck29_instantdeath929_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck30_shadowPT_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck31_lsv_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck32_Kazuga_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",31),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
