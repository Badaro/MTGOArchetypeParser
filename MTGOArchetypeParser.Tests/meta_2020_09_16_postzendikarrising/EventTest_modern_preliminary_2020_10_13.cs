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
#01 Capiplaf95: Burn (WR)
#02 _Falcon_: MonoWhiteTaxes (W)
#03 Zar0s: OmnathSaheeli (WURG, Jegantha)
#04 JakeHelms: OmnathSaheeli (WURG, Jegantha)
#05 im2g00t4ubarn: WURGControl (WURG)
#06 Matti: MonoWhiteTaxes (W)
#07 Do0mSwitch: WURGControl (WURG)
#08 matiaskm: Devoted (WG, Lurrus)
#09 Lordzedane: Bogles (WG, Lurrus)
#10 McWinSauce: OmnathSaheeli (WURG, Jegantha)
#11 junghans: HeliodCombo (WG)
#12 Lukas261997: ShadowProwess (UBR, Lurrus)
#13 Biednarccio: MonoWhiteTaxes (W, Lurrus)
#14 gyyby297: OopsAllSpells (WUBRG)
#15 Sodeq: OopsAllSpells (WUBRG)
#16 Wolfie98: ShadowProwess (BRG)
#17 pepeteam: AmuletTitan (URG)
#18 Toastxp: Uroza (WURG, Yorion)
#19 Boland: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_13 : EventTest
    {
        [Test]
        public void Deck01_Capiplaf95_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",0),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Falcon_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Zar0s_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_JakeHelms_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Matti_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",5),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Lordzedane_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_McWinSauce_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",10),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Lukas261997_ShadowProwess_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",11),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Biednarccio_MonoWhiteTaxes_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",12),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",13),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Sodeq_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Wolfie98_ShadowProwess_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",15),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_pepeteam_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",16),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_Toastxp_Uroza_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",17),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",18),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }


    }
}
