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
#19 brueck4: Uroza (UG)
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
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_AllOfMe_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck03_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck05_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck07_Xwhale_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Cherryxman_Polymorph_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck10_vinitorres_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck11_vinnyrussian123_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck12_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck13_ANBKI_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Phoenix_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck15_SoulStrong_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ibTRUE_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_CaptainFarbosa_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck18_Ak4suk1_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck19_brueck4_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_wordy333_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck21_Magic4everStoreShop6_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Searzist_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_s063_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-11",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
