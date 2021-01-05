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
#01 toondoslav: Infect (UG)
#02 Zar0s: WURG Control (WURG)
#03 _INF_: Gifts Storm (UR, Jegantha)
#04 SoulStrong: Reclaimer Titan (WRG)
#05 DrDree: Infect (UG)
#06 Felo: Shadow Prowess (BR, Lurrus)
#07 JustBurn420: Slivers (WUBRG)
#08 Kazuga: Reclaimer Titan (WRG)
#09 fj_rodman: Amulet Titan (URG)
#10 MiguelCaster: Mono White Taxes (W)
#11 Wizard_2002: Green Tron (G)
#12 Usama96: Jund Prowess (BRG, Lurrus)
#13 _Falcon_: Izzet Prowess (UR)
#14 __BMJ__: Shadow Prowess (WBR, Lurrus)
#15 Chefen: Gruul Midrange (RG)
#16 Eaglov: Amulet Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_07 : EventTest
    {
        [Test]
        public void Deck01_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",0),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Zar0s_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_INF_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_SoulStrong_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",3),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck05_DrDree_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",4),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Felo_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",6),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Kazuga_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",7),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck09_fjrodman_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",8),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_MiguelCaster_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",9),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Wizard2002_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",10),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck12_Usama96_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",11),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_BMJ_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",13),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Chefen_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",14),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Eaglov_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-07",15),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
