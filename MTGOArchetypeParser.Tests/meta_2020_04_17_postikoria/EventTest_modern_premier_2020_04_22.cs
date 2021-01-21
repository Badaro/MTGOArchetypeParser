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
#01 GR_DONKIN: Ad Nauseam (WUB)
#02 Xwhale: Burn (WR, Lurrus)
#03 ander_lizarrakoa: Uroza (URG)
#04 TwistedWombat: Niv To Light (WUBRG, Jegantha)
#05 Darkiundsa: WBRG Shadow (WBRG, Lurrus)
#06 VampireGodric: Bant Control (WUG)
#07 Acekiller: Burn (WR, Lurrus)
#08 WhiTe TsaR: UBRG Control (UBRG, Lurrus)
#09 AndyAWKWARD: Jund Midrange (BRG, Lurrus)
#10 timewalkinonsunshine: Taking Turns (URG)
#11 albert62: Jund Midrange (BRG, Lurrus)
#12 Edel: Golgari Midrange (BG, Lurrus)
#13 Traft: Jeskai Control (WUR, Lurrus)
#14 jessy_samek: Burn (WR, Lurrus)
#15 TSPJendrek: Delver (UB, Lurrus)
#16 mikeleee: Humans (WUBRG, Jegantha)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_premier_2020_04_22 : EventTest
    {
        [Test]
        public void Deck01_GRDONKIN_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",0),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Xwhale_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",1),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_anderlizarrakoa_Uroza_URG()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",2),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck04_TwistedWombat_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",3),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Darkiundsa_WBRGShadow_WBRG_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",4),
                "PostIkoria",
                ArchetypeColor.WBRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_VampireGodric_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",5),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Acekiller_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",6),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_WhiTeTsaR_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",7),
                "PostIkoria",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_AndyAWKWARD_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",8),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",9),
                "PostIkoria",
                ArchetypeColor.URG,
                "TakingTurns",
                null,
                null
            );
        }

        [Test]
        public void Deck11_albert62_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",10),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Edel_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",11),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Traft_JeskaiControl_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",12),
                "PostIkoria",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_jessysamek_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",13),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_TSPJendrek_Delver_UB_Lurrus()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",14),
                "PostIkoria",
                ArchetypeColor.UB,
                "Delver",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_mikeleee_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-premier-2020-04-22",15),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
