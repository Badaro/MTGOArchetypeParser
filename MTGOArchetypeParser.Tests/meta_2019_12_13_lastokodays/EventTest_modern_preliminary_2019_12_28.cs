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
#01 McWinSauce: Saheeli Combo (WURG)
#02 yamakiller: Eldrazi Tron (C)
#03 exoticherman: Infect (UG)
#04 SourceOdin: Urza Oko (WUG)
#05 SoulStrong: UBRG Shadow (UBRG)
#06 nahuel10: Burn (WR)
#07 GutsMTG: Primeval Titan (UG)
#08 Gallatin: Green Tron (G)
#09 abethemage: Urza Oko (UBG)
#10 JustBurn420: Burn (WR)
#11 Finalnub: Eldrazi Tron (G)
#12 d_peliser: Grixis Shadow (UBR)
#13 Tyerube1618: Green Tron (G)
#14 RicardoMSLan: Eldrazi Tron (C)
#15 PRGJJAR: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_28 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",0),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck02_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",1),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",2),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SourceOdin_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",3),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",4),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",5),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_GutsMTG_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",6),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Gallatin_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",7),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck09_abethemage_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",8),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck10_JustBurn420_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",9),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Finalnub_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",10),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_dpeliser_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",11),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Tyerube1618_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",12),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck14_RicardoMSLan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",13),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-28",14),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }


    }
}
