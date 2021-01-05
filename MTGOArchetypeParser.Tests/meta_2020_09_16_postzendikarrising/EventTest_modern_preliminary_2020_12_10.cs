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
#01 PRGJJAR: Dredge (BRG)
#02 Redgy: Burn (WR)
#03 darthjacen: Dredge (BRG)
#04 qbturtle15: Mono White Taxes (W)
#05 JUJUBEAN__2004: Heliod Combo (WG)
#06 LORiWWA: Eldrazi Tron (C)
#07 ht991122: Shadow Prowess (BR, Lurrus)
#08 cws: Gifts Storm (UR)
#09 bolov0: Ad Nauseam (WUB)
#10 Nammersquats: Infect (UG)
#11 SoulStrong: Rogues (UB, Lurrus)
#12 eresopacaso: Heliod Combo (WG)
#13 Toro_UY: Gifts Storm (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_10 : EventTest
    {
        [Test]
        public void Deck01_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",0),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Redgy_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",1),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_darthjacen_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",3),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck05_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",4),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_LORiWWA_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",5),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_ht991122_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",7),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck09_bolov0_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",8),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",9),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck11_SoulStrong_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",10),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_eresopacaso_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ToroUY_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-10",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }


    }
}
