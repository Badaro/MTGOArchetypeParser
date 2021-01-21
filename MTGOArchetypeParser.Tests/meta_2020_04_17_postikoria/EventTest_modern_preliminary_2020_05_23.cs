using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 KOVU211: Devoted (WG, Lurrus)
#02 Searzist: Mardu Prowess (WBR, Lurrus)
#03 in5ano: Scapeshift (URG, Yorion)
#04 otakkun: Eldrazi Tron (C)
#05 TennTyou: Niv To Light (WUBRG, Jegantha)
#06 GideonRavensword: Bogles (WUG, Lurrus)
#07 TSPJendrek: Azorius Control (WU, Yorion)
#08 Toastxp: Mardu Prowess (WBR, Lurrus)
#09 joker10289: Mardu Prowess (WBR, Lurrus)
#10 zecarlonxo: Hardened Scales (BG, Lurrus)
#11 Laplasjan: Devoted (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_23 : EventTest
    {
        [Test]
        public void Deck01_KOVU211_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",0),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Searzist_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",1),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",2),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",3),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_TennTyou_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",4),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_GideonRavensword_Bogles_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",5),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_TSPJendrek_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",6),
                "PostIkoria",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",7),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_joker10289_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",8),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_zecarlonxo_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",9),
                "PostIkoria",
                ArchetypeColor.BG,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-23",10),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
