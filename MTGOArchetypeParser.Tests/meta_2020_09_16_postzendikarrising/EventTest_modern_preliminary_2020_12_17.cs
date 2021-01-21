using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 SourceOdin: Reclaimer Titan (WG)
#02 CaptainFarbosa: Azorius Control (WU)
#03 cftsoc3: Bant Blink (WUG)
#04 HouseOfManaMTG: Reclaimer Titan (WRG)
#05 bmac668: Shadow Prowess (WBR, Lurrus)
#06 pokerswizard: Rakdos Midrange (BR)
#07 Nammersquats: Infect (UG)
#08 MZBlazer: Heliod Combo (WG)
#09 Leviathan102: Reclaimer Titan (WRG)
#10 Redgy819: Green Tron (G)
#11 ATGerwaz: Mill (UBG, Lurrus)
#12 MaLiam: Rakdos Midrange (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_17 : EventTest
    {
        [Test]
        public void Deck01_SourceOdin_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",0),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck02_CaptainFarbosa_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",1),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",2),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck04_HouseOfManaMTG_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",3),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck05_bmac668_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",4),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_pokerswizard_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",6),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck08_MZBlazer_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",7),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Leviathan102_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",8),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck10_Redgy819_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",9),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck11_ATGerwaz_Mill_UBG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",10),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_MaLiam_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",11),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
