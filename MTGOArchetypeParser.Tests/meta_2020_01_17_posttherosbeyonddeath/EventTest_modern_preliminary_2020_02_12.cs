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
#01 SlyDaniel7787: Eldrazi Tron (G)
#02 WuYuHsien: Bant Control (WUG)
#03 Violent_Outburst: Amulet Titan (UG)
#04 tagosaku: Burn (WR)
#05 Janh: Saheeli Combo (WUR)
#06 albert62: Jund Midrange (BRG)
#07 joker10289: Mono Red Prowess (R)
#08 McWinSauce: Sultai Control (UBG)
#09 tanisong1221: Orzhov Midrange (WB)
#10 MATTHEWFOULKES: Thopter Urza (UB)
#11 ZYURYO: Azorius Control (WU)
#12 KIMCHIMAN: Mono Red Prowess (R)
#13 Accelerator_GTR: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_12 : EventTest
    {
        [Test]
        public void Deck01_SlyDaniel7787_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_WuYuHsien_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ViolentOutburst_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_tagosaku_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_joker10289_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_McWinSauce_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_tanisong1221_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MATTHEWFOULKES_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck11_ZYURYO_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_KIMCHIMAN_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_AcceleratorGTR_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-12",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
