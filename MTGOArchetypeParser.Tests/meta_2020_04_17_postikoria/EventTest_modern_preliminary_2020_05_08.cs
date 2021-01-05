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
#01 DreamsOfAshiok: Eldrazi Tron (C)
#02 kthanakit26: Jund Prowess (BRG, Lurrus)
#03 MarcoBelacca95: Burn (WR, Lurrus)
#04 HarlanMTG: Grixis Control (UBR, Lurrus)
#05 SnapKeepGaming: Green Tron (G)
#06 Toastxp: Uroza (URG, Yorion)
#07 TennTyou: Niv To Light (WUBRG)
#08 Albimtg: Dimir Control (UB, Lurrus)
#09 Niedzwiedz: Boros Prowess (WR, Lurrus)
#10 lSoLlAKirA: Kiki Chord (WURG, Yorion)
#11 bigmasticore: Grixis Shadow (UBR, Lurrus)
#12 Amigobriell: WURG Control (WURG, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_08 : EventTest
    {
        [Test]
        public void Deck01_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",0),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_kthanakit26_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",1),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_MarcoBelacca95_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",2),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_HarlanMTG_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",3),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_SnapKeepGaming_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",4),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck06_Toastxp_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",5),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",6),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Albimtg_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",7),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Niedzwiedz_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",8),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_lSoLlAKirA_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",9),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_bigmasticore_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",10),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Amigobriell_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-08",11),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
