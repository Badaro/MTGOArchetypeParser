using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 abombdiggity: Gruul Midrange (RG)
#02 AllOfMe: Titan Shift (RG)
#03 sandydogmtg: Burn (R)
#04 Icteridae: Devoted (WUG)
#05 qbturtle15: Azorius Control (WU)
#06 stonepeanut: Green Tron (G)
#07 Xwhale: Primeval Titan (WG)
#08 PRGJJAR: Dredge (BRG)
#09 Cherryxman: Polymorph (WUR)
#10 vini_torres: Gifts Storm (UR)
#11 vinnyrussian123: Primeval Titan (UG)
#12 fistfullofmetal: Green Tron (G)
#13 ANBKI: Green Eldrazi (RG)
#14 _Phoenix_: Thopter Urza (UB)
#15 SoulStrong: Bant Control (WUG)
#16 i_b_TRUE: Jund Midrange (BRG)
#17 CaptainFarbosa: Thopter Urza (UB)
#18 Ak4suk1: Neobrand (UG)
#19 brueck4: Uroza (URG)
#20 wordy333: Green Tron (G)
#21 Magic4everStoreShop6: Gruul Midrange (RG)
#22 Searzist: Mono Red Prowess (R)
#23 s063: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_11 : EventTest
    {
        [Test]
        public void Deck01_abombdiggity_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_AllOfMe_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck03_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck04_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck05_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_Xwhale_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck08_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Cherryxman_Polymorph_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUR,
                "Polymorph",
                null,
                null
            );
        }

        [Test]
        public void Deck10_vinitorres_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck11_vinnyrussian123_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck12_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck13_ANBKI_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Phoenix_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck15_SoulStrong_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_ibTRUE_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_CaptainFarbosa_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck18_Ak4suk1_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck19_brueck4_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck20_wordy333_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck21_Magic4everStoreShop6_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Searzist_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_s063_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
