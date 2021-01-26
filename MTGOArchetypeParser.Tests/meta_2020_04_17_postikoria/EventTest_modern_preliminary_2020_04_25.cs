using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Mistakenn: Primeval Titan (UG)
#02 TSPJendrek: Dimir Control (UB, Lurrus)
#03 RearrangedAS: Spirits (WU, Jegantha)
#04 Mlgb92: Jeskai Control (WUR, Lurrus)
#05 Sonso JF: Boros Prowess (WR, Lurrus)
#06 Sharkcaster_Mage: Primeval Titan (BG)
#07 Laplasjan: Devoted (WG, Lurrus)
#08 Gerschi: Jund Shadow (BRG, Lurrus)
#09 nsroller: Jund Midrange (BRG, Lurrus)
#10 PietroSas: Burn (WR, Lurrus)
#11 cicciogire: Jund Midrange (BRG, Lurrus)
#12 Damgar: Green Tron (G)
#13 penips: Orzhov Taxes (WB)
#14 matyo804: Devoted (WUG)
#15 fradev1988: Bant Control (WUG)
#16 harukispecial: Jeskai Control (WUR)
#17 Treno: Devoted (WG, Lurrus)
#18 Heibing: Living End (WURG)
#19 felider: Burn (WR, Lurrus)
#20 patrick50: Burn (WR, Lurrus)
#21 Punkah: Humans (WUBRG, Jegantha)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_04_25 : EventTest
    {
        [Test]
        public void Deck01_Mistakenn_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",0),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck02_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",1),
                "PostIkoria",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_RearrangedAS_Spirits_WU_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",2),
                "PostIkoria",
                ArchetypeColor.WU,
                "Spirits",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_Mlgb92_JeskaiControl_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",3),
                "PostIkoria",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_SonsoJF_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",4),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_SharkcasterMage_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",5),
                "PostIkoria",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",6),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Gerschi_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",7),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_nsroller_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",8),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_PietroSas_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",9),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_cicciogire_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",10),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Damgar_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",11),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck13_penips_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",12),
                "PostIkoria",
                ArchetypeColor.WB,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck14_matyo804_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",13),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck15_fradev1988_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",14),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_harukispecial_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",15),
                "PostIkoria",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Treno_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",16),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Heibing_LivingEnd_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",17),
                "PostIkoria",
                ArchetypeColor.WURG,
                "LivingEnd",
                null,
                null
            );
        }

        [Test]
        public void Deck19_felider_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",18),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_patrick50_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",19),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Punkah_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-25",20),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
