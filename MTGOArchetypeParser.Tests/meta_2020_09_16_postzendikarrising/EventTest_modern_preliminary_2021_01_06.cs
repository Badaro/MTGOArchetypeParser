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
#01 Gerardo94: WURG Control (WURG)
#02 SIMONEFIERRO: Burn (WR)
#03 gyyby297: Oops All Spells (WUBRG)
#04 otakkun: Pyro Prison (R)
#05 aManatease: Izzet Prowess (UR)
#06 Rinko: Enduring Ideal (WR)
#07 kingfroik: Shadow Prowess (BR, Lurrus)
#08 Scabs: Sultai Control (UBG)
#09 TSPJendrek: Bant Control (WUG)
#10 2radMTG: Burn (WR)
#11 mashmalovsky: Ad Nauseam (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_06 : EventTest
    {
        [Test]
        public void Deck01_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SIMONEFIERRO_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",1),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck04_otakkun_PyroPrison_R()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",3),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(PyroPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck05_aManatease_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",5),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck07_kingfroik_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Scabs_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",7),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_TSPJendrek_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",8),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_2radMTG_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",9),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-06",10),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }


    }
}