using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Violent_Outburst: UBRG Shadow (UBRG)
#02 Kitchen_Finks: Thopter Urza (UB)
#03 Accelerator_GTR: Jund Midrange (BRG)
#04 Juzam-Djinn84: Gifts Storm (UR)
#05 SoulStrong: Thopter Urza (UB)
#06 maxbv: Jund Midrange (BRG)
#07 medvedev: Mono Red Prowess (R)
#08 swff: Bant Control (WUG)
#09 Chipsoss: Golgari Midrange (BG)
#10 Kadoonyec: Amulet Titan (UG)
#11 Nammersquats: Neobrand (UG)
#12 Dafne17: Gruul Midrange (RG)
#13 WuYuHsien: Bant Control (WUG)
#14 jessy_samek: Amulet Titan (UG)
#15 dejoyjoe: Amulet Titan (UG)
#16 Blinkmoth-Nexus: Rakdos Midrange (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_28 : EventTest
    {
        [Test]
        public void Deck01_ViolentOutburst_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck02_KitchenFinks_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck03_AcceleratorGTR_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_JuzamDjinn84_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck05_SoulStrong_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck06_maxbv_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_medvedev_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_swff_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Chipsoss_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Kadoonyec_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_Nammersquats_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Dafne17_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_WuYuHsien_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_jessysamek_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck15_dejoyjoe_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck16_BlinkmothNexus_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-28",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
