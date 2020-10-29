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
#03 MZBlazer: SaheeliCombo (WURG, Jegantha)
#04 Xen0neb: HardenedScales (G)
#05 abethemage: SaheeliCombo (WURG, Jegantha)
#06 maximusdee: HeliodCombo (WG)
#07 Xwhale: PrimevalTitan (WRG)
#08 SKK: ShadowProwess (BR, Lurrus)
#09 kbzx: ShadowProwess (BR, Lurrus)
#10 Redgy: JeskaiControl (WUR)
#11 sandydogmtg: ShadowProwess (WBR, Lurrus)
#12 Mcleskey: Burn (WR)
#13 GideonRavensword: Dredge (BRG)
#14 Icteridae: GruulMidrange (RG)
#15 Sam_Lewin: BorosLandDestruction (WBR)
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
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_RandomDrooler_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",1),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck03_MZBlazer_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_Xen0neb_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",3),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck05_abethemage_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_maximusdee_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Xwhale_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",6),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck08_SKK_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_kbzx_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",8),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Redgy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",9),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_sandydogmtg_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",10),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",11),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",12),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Icteridae_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",13),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_SamLewin_BorosLandDestruction_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-15",14),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }


    }
}
