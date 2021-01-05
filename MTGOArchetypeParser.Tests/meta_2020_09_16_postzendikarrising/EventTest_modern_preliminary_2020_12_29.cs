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
#01 bomberboss: Rakdos Midrange (BR)
#02 D00mwake: Boros Prowess (WR, Lurrus)
#03 Draconic1: Reclaimer Titan (WG)
#04 Boland: Dredge (BRG)
#05 fingers1991: Izzet Prowess (UR)
#06 JUJUBEAN__2004: UBRG Control (UBRG)
#07 naddyeffintabs: Burn (WR)
#08 Stompy45: Obosh Aggro (R, Obosh)
#09 pokerswizard: Shadow Prowess (BR, Lurrus)
#10 Parrotlet: Uroza (UBG)
#11 wambocombo2020: Hammer Time (WB, Lurrus)
#12 Chris_Concarnage: Obosh Aggro (R, Obosh)
#13 penips: Mono White Taxes (W)
#14 Zar0s: Amulet Titan (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_29 : EventTest
    {
        [Test]
        public void Deck01_bomberboss_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_D00mwake_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",1),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Draconic1_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",2),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck04_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",3),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck05_fingers1991_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",5),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_naddyeffintabs_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",6),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Stompy45_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",7),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",8),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Parrotlet_Uroza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",9),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_wambocombo2020_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",10),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_ChrisConcarnage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",11),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",12),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Zar0s_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-29",13),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
