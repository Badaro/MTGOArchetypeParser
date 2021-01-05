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
#01 SourceOdin: Reclaimer Titan (WG)
#02 CaptainFarbosa: Azorius Control (WU)
#03 cftsoc3: Bant Blink (WUG)
#04 HouseOfManaMTG: Reclaimer Titan (WRG)
#05 bmac668: Shadow Prowess (WBR, Lurrus)
#06 pokerswizard: Rakdos Midrange (BR)
#07 Nammersquats: Infect (UG)
#08 MZBlazer: Heliod Combo (WG)
#09 Leviathan102: Reclaimer Titan (WRG)
#10 Redgy819: KGC Tron (G)
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
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck02_CaptainFarbosa_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",2),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck04_HouseOfManaMTG_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",3),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck05_bmac668_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",4),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_pokerswizard_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",6),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck08_MZBlazer_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Leviathan102_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",8),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck10_Redgy819_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",9),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_ATGerwaz_Mill_UBG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_MaLiam_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-17",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
