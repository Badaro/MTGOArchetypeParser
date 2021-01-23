using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 otakkun: WURG Control (WURG)
#02 mariogomes097: Ad Nauseam (WUB)
#03 kanister: Reclamation (UBG)
#04 CrusherBotBG: Hammer Time (W, Lurrus)
#05 Arrias: Heliod Combo (WRG)
#06 ghett_smart: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_23 : EventTest
    {
        [Test]
        public void Deck01_otakkun_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-23",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_mariogomes097_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-23",1),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck03_kanister_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-23",2),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck04_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-23",3),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Arrias_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-23",4),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ghettsmart_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-23",5),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
