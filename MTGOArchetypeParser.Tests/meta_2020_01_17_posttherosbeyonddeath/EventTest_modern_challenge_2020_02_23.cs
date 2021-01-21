using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Sodeq: Dredge (WBRG)
#02 musasabi: Smallpox (WB)
#03 Nikachu: Merfolk (UG)
#04 grinderA: Amulet Titan (UG)
#05 elad3127: Amulet Titan (UG)
#06 ZYURYO: Bant Control (WUG)
#07 rileydk: Amulet Titan (UG)
#08 offline: Thopter Urza (UB)
#09 elvin7: Mono Red Prowess (R)
#10 GGoggles: Eldrazi Tron (G)
#11 WeareVenom: Azorius Control (WU)
#12 Stackz: Primeval Titan (WG)
#13 Shadowz2005: UBRG Shadow (UBRG)
#14 Bosley: Amulet Titan (UG)
#15 Boland: Grixis Shadow (UBR)
#16 djbmppwns: Heliod Combo (WBG)
#17 stainerson: Jund Shadow (BRG)
#18 Papelucho10: Infect (UG)
#19 Meltiin: Smallpox (BRG)
#20 B1gDan: Heliod Combo (WBG)
#21 fling5133: Sultai Control (UBG)
#22 Blitzlion27: Mill (UB)
#23 katuo079595: Mono Red Prowess (R)
#24 Samcaster-Mage: Eldrazi Tron (G)
#25 VTCLA: Jund Shadow (BRG)
#26 palk52: Burn (WR)
#27 zecarlonxo: Mono Red Prowess (R)
#28 maxbv: Jund Midrange (BRG)
#29 Tiemuuu: Izzet Control (UR)
#30 fede1: Sultai Control (UBG)
#31 GedionRavenor: Azorius Control (WU)
#32 Rhaikou: Crabvine (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_challenge_2020_02_23 : EventTest
    {
        [Test]
        public void Deck01_Sodeq_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_musasabi_Smallpox_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.WB,
                "Smallpox",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck04_grinderA_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_elad3127_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_rileydk_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_offline_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck09_elvin7_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_GGoggles_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_WeareVenom_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Stackz_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Shadowz2005_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Bosley_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck15_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck16_djbmppwns_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck17_stainerson_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Meltiin_Smallpox_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Smallpox",
                null,
                null
            );
        }

        [Test]
        public void Deck20_B1gDan_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck21_fling5133_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Blitzlion27_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck23_katuo079595_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck24_SamcasterMage_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck25_VTCLA_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck26_palk52_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck27_zecarlonxo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_maxbv_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_fede1_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_GedionRavenor_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Rhaikou_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-23",31),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }


    }
}
