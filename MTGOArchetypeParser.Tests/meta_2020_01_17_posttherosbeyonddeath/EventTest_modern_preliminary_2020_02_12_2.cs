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
#01 Searzist: Mono Red Prowess (R)
#02 Gul_Dukat: Devoted (WBG)
#03 sandydogmtg: Burn (R)
#04 MischasBauble: Goryo Reanimator (BRG)
#05 Xuxa: Dredge (BRG)
#06 RandomOctopus: Thopter Urza (UB)
#07 Sharkcaster_Mage: Gifts Storm (URG)
#08 sacca93: Uroza (UG)
#09 Treno: Mono Red Prowess (R)
#10 WhiteFaces: Bant Control (WUG)
#11 joker10289: Mono Red Prowess (R)
#12 qbturtle15: Azorius Control (WU)
#13 coert: Burn (R)
#14 Tiemuuu: Izzet Control (UR)
#15 yanmaster: Heliod Combo (WBG)
#16 Cherryxman: Polymorph (WUR)
#17 Fnoop: Eldrazi Tron (G)
#18 Antarctica: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_12_2 : EventTest
    {
        [Test]
        public void Deck01_Searzist_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_GulDukat_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck03_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_MischasBauble_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Xuxa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_RandomOctopus_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck07_SharkcasterMage_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck08_sacca93_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Treno_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_WhiteFaces_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_joker10289_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck12_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_coert_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_yanmaster_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Cherryxman_Polymorph_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Fnoop_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_Antarctica_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12-2",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}