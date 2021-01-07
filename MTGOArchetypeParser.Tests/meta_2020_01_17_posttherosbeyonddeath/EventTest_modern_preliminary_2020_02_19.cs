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
#01 swff: Bant Control (WUG)
#02 patheus_84: Ad Nauseam (WUB)
#03 __BMJ__: Ad Nauseam (WUB)
#04 medvedev: Mono Red Prowess (R)
#05 infernflo: Bant Blink (WUG)
#06 TSPJendrek: Azorius Control (WU)
#07 Madvilla1ny: Sultai Shadow (UBG)
#08 C_E.L: Heliod Combo (WBG)
#09 lSoLlAKirA: Thopter Urza (UB)
#10 _Shatun_: Mono Red Prowess (R)
#11 Tyerube1618: Gifts Storm (UR)
#12 Duggie12: Mono Red Prowess (R)
#13 tagosaku: Burn (WR)
#14 Sam_Lewin: Skelementals (BR)
#15 2radMTG: Mono Green Midrange (G)
#16 Toastxp: Thopter Urza (UB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_19 : EventTest
    {
        [Test]
        public void Deck01_swff_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BMJ_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck04_medvedev_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_infernflo_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Madvilla1ny_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_CEL_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_lSoLlAKirA_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck10_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Tyerube1618_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Duggie12_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_tagosaku_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck14_SamLewin_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BR,
                typeof(Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck15_2radMTG_MonoGreenMidrange_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(GreenDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Toastxp_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }


    }
}
