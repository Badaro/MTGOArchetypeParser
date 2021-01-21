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
#01 Ivc: Azorius Control (WU)
#02 RadioactiveTortoise: Gifts Storm (UR, Jegantha)
#03 otakkun: Eldrazi Tron (C)
#04 TSPJendrek: Azorius Control (WU, Yorion)
#05 UrbanPope: Boros Prowess (WR, Lurrus)
#06 Yamada: Devoted (WG, Lurrus)
#07 ilsecco14: Neobrand (UG)
#08 eresopacaso: Green Tron (G)
#09 audio336: Boros Prowess (WR, Lurrus)
#10 aduig33: Ad Nauseam (WUB)
#11 Laplasjan: Devoted (WG, Lurrus)
#12 pizzaslinger: Mardu Prowess (WBR, Lurrus)
#13 _INF_: Gifts Storm (UR, Jegantha)
#14 Venom1: Jund Midrange (BRG, Lurrus)
#15 ArchaeusDota: Green Tron (RG, Jegantha)
#16 jvidarte: Burn (WR, Lurrus)
#17 alemilan19: Jund Midrange (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_16 : EventTest
    {
        [Test]
        public void Deck01_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",0),
                "PostIkoria",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_RadioactiveTortoise_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",1),
                "PostIkoria",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck03_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",2),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_TSPJendrek_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",3),
                "PostIkoria",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_UrbanPope_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",4),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Yamada_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",5),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",6),
                "PostIkoria",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck08_eresopacaso_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",7),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck09_audio336_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",8),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_aduig33_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",9),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",10),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_pizzaslinger_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",11),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_INF_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",12),
                "PostIkoria",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck14_Venom1_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",13),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_ArchaeusDota_GreenTron_RG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",14),
                "PostIkoria",
                ArchetypeColor.RG,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck16_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",15),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_alemilan19_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-16",16),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
