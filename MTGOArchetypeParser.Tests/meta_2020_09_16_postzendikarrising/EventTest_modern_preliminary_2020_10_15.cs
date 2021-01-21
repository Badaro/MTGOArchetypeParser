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
#01 Kazuga: Humans (WUBRG)
#02 RandomDrooler: Belcher (URG)
#03 MZBlazer: Omnath Saheeli (WURG, Jegantha)
#04 Xen0neb: Hardened Scales (G)
#05 abethemage: Omnath Saheeli (WURG, Jegantha)
#06 maximusdee: Heliod Combo (WG)
#07 Xwhale: Reclaimer Titan (WRG)
#08 SKK: Shadow Prowess (BR, Lurrus)
#09 kbzx: Shadow Prowess (BR, Lurrus)
#10 Redgy: Jeskai Control (WUR)
#11 sandydogmtg: Shadow Prowess (WBR, Lurrus)
#12 Mcleskey: Burn (WR)
#13 GideonRavensword: Dredge (BRG)
#14 Icteridae: Gruul Midrange (RG)
#15 Sam_Lewin: Land Destruction (WBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_15 : EventTest
    {
        [Test]
        public void Deck01_Kazuga_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",0),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck02_RandomDrooler_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",1),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck03_MZBlazer_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_Xen0neb_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",3),
                "PostZendikarRising",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck05_abethemage_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",4),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_maximusdee_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",5),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",6),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck08_SKK_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",7),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_kbzx_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",8),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Redgy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",9),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_sandydogmtg_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",10),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",11),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck13_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",12),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Icteridae_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",13),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_SamLewin_LandDestruction_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",14),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "LandDestruction",
                null,
                null
            );
        }


    }
}
