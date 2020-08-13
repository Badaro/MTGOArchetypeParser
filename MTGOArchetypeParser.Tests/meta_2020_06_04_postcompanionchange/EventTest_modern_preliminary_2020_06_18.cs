using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_18 : EventTest
    {
        [Test]
        public void Deck01_Icteridae_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck01_Icteridae_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_DreamsOfAshiok_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck02_DreamsOfAshiok_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_yamakiller_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck03_yamakiller_Humans_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Hiru_RakdosMidrange_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck04_Hiru_RakdosMidrange_BR(),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PTarts2win_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck05_PTarts2win_Dredge_BRG(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_flatnose_Merfolk_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck06_flatnose_Merfolk_UG(),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ilsecco14_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck07_ilsecco14_Prowess_R(),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_wambocombo2020_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck08_wambocombo2020_Uroza_UBG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_MadCowChicken_SelesnyaEldrazi_WG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck09_MadCowChicken_SelesnyaEldrazi_WG_Jegantha(),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(SelesnyaEldrazi),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Stompy45_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck10_Stompy45_Ponza_RG(),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_LSN_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck11_LSN_Burn_WR(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Traft_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck12_Traft_AdNauseam_WUB(),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck13_WebZone_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18.Deck13_WebZone_Humans_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
