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
#01 Patxi: WURGControl (WURG)
#02 Kiwairay: OopsAllSpells (WUBRG)
#03 McWinSauce: WURGControl (WURG)
#04 TwistedWombat: OmnathSaheeli (WURG, Jegantha)
#05 Sanchez5272: ETron (C)
#06 ArchivalRain: GiftsStorm (UR)
#07 Biednarccio: MonoWhiteTaxes (W)
#08 _Shatun_: OboshAggro (R, Obosh)
#09 medvedev: OmnathSaheeli (WURG, Jegantha)
#10 Redgy819: OmnathSaheeli (WURG, Jegantha)
#11 Danker: AzoriusControl (WU)
#12 RitterAG: IzzetProwess (UR)
#13 bwheezy: JeskaiControl (WUR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_20 : EventTest
    {
        [Test]
        public void Deck01_Patxi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Kiwairay_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck03_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TwistedWombat_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Sanchez5272_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",4),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ArchivalRain_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",5),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Biednarccio_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",6),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",7),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_medvedev_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Redgy819_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_Danker_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",10),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_RitterAG_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",11),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_bwheezy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",12),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
