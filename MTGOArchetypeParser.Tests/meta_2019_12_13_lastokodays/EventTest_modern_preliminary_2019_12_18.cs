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
#01 Nammersquats: Humans (WUBRG)
#02 reew2n: Mono Red Prowess (R)
#03 McWinSauce: Bant Control (WUG)
#04 JSG-MTG: Eldrazi Tron (C)
#05 Tiemuuu: Izzet Control (UR)
#06 kanister: Simic Control (UG)
#07 mmapson125: Amulet Titan (UG)
#08 lynnchalice: Izzet Control (UR)
#09 Wyern: Humans (WUBRG)
#10 nahuel10: Burn (WR)
#11 Kricha13: Eldrazi Tron (C)
#12 Bohnz: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_18 : EventTest
    {
        [Test]
        public void Deck01_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",0),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_reew2n_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",1),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",2),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_JSGMTG_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",3),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",4),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_kanister_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",5),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck07_mmapson125_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",6),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_lynnchalice_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",7),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Wyern_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",8),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",9),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Kricha13_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",10),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_Bohnz_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-18",11),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
