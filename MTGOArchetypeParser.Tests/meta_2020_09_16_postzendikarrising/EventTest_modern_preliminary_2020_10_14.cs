using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 toondoslav: Mono White Taxes (W)
#02 im2g00t4ubarn: WURG Control (WURG)
#03 Kazuga: Humans (WUBRG)
#04 Paeng_Paeng: Gifts Storm (UR)
#05 mansak: Shadow Prowess (BR, Lurrus)
#06 ecobaronen: Sultai Control (UBG)
#07 abethemage: Omnath Saheeli (WURG, Jegantha)
#08 junghans: Heliod Combo (WG)
#09 ZYURYO: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_14 : EventTest
    {
        [Test]
        public void Deck01_toondoslav_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",0),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck02_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Kazuga_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",2),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck04_PaengPaeng_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",3),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck05_mansak_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ecobaronen_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",5),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_abethemage_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",7),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck09_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
