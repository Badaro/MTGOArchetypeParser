using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Patxi: WURG Control (WURG)
#02 Kiwairay: Oops All Spells (WUBRG)
#03 McWinSauce: WURG Control (WURG)
#04 TwistedWombat: Omnath Saheeli (WURG, Jegantha)
#05 Sanchez5272: Eldrazi Tron (C)
#06 ArchivalRain: Gifts Storm (UR)
#07 Biednarccio: Mono White Taxes (W)
#08 _Shatun_: Obosh Aggro (R, Obosh)
#09 medvedev: Omnath Saheeli (WURG, Jegantha)
#10 Redgy819: Omnath Saheeli (WURG, Jegantha)
#11 Danker: Azorius Control (WU)
#12 RitterAG: Izzet Prowess (UR)
#13 bwheezy: Jeskai Control (WUR)
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
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Kiwairay_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",1),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck03_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_TwistedWombat_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Sanchez5272_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",4),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_ArchivalRain_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",5),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Biednarccio_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",6),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",7),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_medvedev_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Redgy819_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",9),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_Danker_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",10),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_RitterAG_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",11),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck13_bwheezy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-20",12),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }


    }
}
