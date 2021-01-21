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
#02 _Falcon_: Mono White Taxes (W)
#03 Zar0s: Omnath Saheeli (WURG, Jegantha)
#04 JakeHelms: Omnath Saheeli (WURG, Jegantha)
#05 im2g00t4ubarn: WURG Control (WURG)
#06 Matti: Mono White Taxes (W)
#07 Do0mSwitch: WURG Control (WURG)
#08 matiaskm: Devoted (WG, Lurrus)
#09 Lordzedane: Bogles (WG, Lurrus)
#10 McWinSauce: Omnath Saheeli (WURG, Jegantha)
#11 junghans: Heliod Combo (WG)
#12 Lukas261997: Shadow Prowess (UBR, Lurrus)
#13 Biednarccio: Mono White Taxes (W, Lurrus)
#14 gyyby297: Oops All Spells (WUBRG)
#15 Sodeq: Oops All Spells (WUBRG)
#16 Wolfie98: Shadow Prowess (BRG)
#17 pepeteam: Amulet Titan (UG)
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
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck02_Falcon_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",1),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Zar0s_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_JakeHelms_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",4),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Matti_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",5),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",7),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Lordzedane_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",8),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_McWinSauce_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",9),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",10),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Lukas261997_ShadowProwess_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",11),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Biednarccio_MonoWhiteTaxes_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",12),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",13),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Sodeq_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",14),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Wolfie98_ShadowProwess_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",15),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                null
            );
        }

        [Test]
        public void Deck17_pepeteam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",16),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck18_Toastxp_Uroza_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",17),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-13",18),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }


    }
}
