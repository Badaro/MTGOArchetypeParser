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
#01 Graciasportanto: Simic Control (UG)
#02 mell0n: Simic Prowess (UG)
#03 fistfullofmetal: Green Tron (RG)
#04 ecobaronen: Bant Midrange (WUG)
#05 Coly2: Mono Red Prowess (R)
#06 fradev1988: Electro Balance (UR)
#07 _Tia93_: Primeval Titan (UBG)
#08 iDaveW: Infect (UG)
#09 Malakxy: Bogles (WG)
#10 _Shatun_: Burn (R)
#11 emorton13: Spirits (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_03_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_08 : EventTest
    {
        [Test]
        public void Deck01_Graciasportanto_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",0),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_mell0n_SimicProwess_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_fistfullofmetal_GreenTron_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",2),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck04_ecobaronen_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",3),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Coly2_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",4),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",5),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck07_Tia93_PrimevalTitan_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",6),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_iDaveW_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",7),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Malakxy_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",8),
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Shatun_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",9),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_emorton13_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-08",10),
                new LastOkoDays(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }


    }
}
