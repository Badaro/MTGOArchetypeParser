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
#01 toondoslav: MonoWhiteTaxes (W)
#02 im2g00t4ubarn: WURGControl (WURG)
#03 Kazuga: Humans (WUBRG)
#04 Paeng_Paeng: GiftsStorm (UR)
#05 mansak: ShadowProwess (BR, Lurrus)
#06 ecobaronen: SultaiControl (UBG)
#07 abethemage: SaheeliCombo (WURG, Jegantha)
#08 junghans: HeliodCombo (WG)
#09 ZYURYO: WURGControl (WURG)
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
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck02_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Kazuga_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PaengPaeng_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck05_mansak_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ecobaronen_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",5),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_abethemage_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-14",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
