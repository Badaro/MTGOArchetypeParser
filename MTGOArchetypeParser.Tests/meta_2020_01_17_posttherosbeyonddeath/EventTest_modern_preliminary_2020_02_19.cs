using FluentAssertions;
using MTGOArchetypeParser.Model;
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
#07 Madvilla1ny: UBRG Shadow (UBRG)
#08 C_E.L: Heliod Combo (WBG)
#09 lSoLlAKirA: Thopter Urza (UB)
#10 _Shatun_: Mono Red Prowess (R)
#11 Tyerube1618: Gifts Storm (UR)
#12 Duggie12: Mono Red Prowess (R)
#13 tagosaku: Burn (WR)
#14 Sam_Lewin: Skelementals (BR)
#15 2radMTG: Green Devotion (RG)
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
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck03_BMJ_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck04_medvedev_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_infernflo_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck06_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Madvilla1ny_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_CEL_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck09_lSoLlAKirA_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck10_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_Tyerube1618_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Duggie12_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck13_tagosaku_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck14_SamLewin_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.BR,
                "Skelementals",
                null,
                null
            );
        }

        [Test]
        public void Deck15_2radMTG_GreenDevotion_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GreenDevotion",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Toastxp_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-19",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }


    }
}
