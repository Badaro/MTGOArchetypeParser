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
#01 TheEnzym: Mill (UB)
#02 IzzetSignetIsTheBest: Reclaimer Titan (WRG)
#03 DrRobertSpaghetti: Gruul Midrange (RG)
#04 Metcalf23: Mono White Taxes (W)
#05 staffmat1992: Gruul Midrange (RG)
#06 Graven_Cairns: Jund Midrange (BRG)
#07 Smdster: Temur Control (URG)
#08 JB2002: Azorius Control (WU, Yorion)
#09 solaec0501: Humans (WUBRG)
#10 il_matagatto: Humans (WUBRG)
#11 Delpoctrol: Dredge (BRG)
#12 Rebus8: Humans (WUBRG)
#13 Gerschi: Shadow Prowess (BR, Lurrus)
#14 Antoine57437: Abzan Company (WBRG)
#15 An_Actual_Potato: Temur Control (URG)
#16 wambocombo2020: Humans (WUBRG)
#17 Magister_1993: Azorius Control (WU)
#18 Erik157751: Sultai Shadow (UBG)
#19 Rulleboren: Mill (UB, Lurrus)
#20 AstralPlane: Rakdos Prowess (BR, Lurrus)
#21 Bullwinkkle6705: WURG Control (WURG)
#22 Trid0n: Bogles (WG)
#23 SebastianStueckl: Sultai Control (UBG)
#24 kiko: Jeskai Taxes (WUR)
#25 quinniac: Mono Red Prowess (R)
#26 pokerswizard: Mill (UB, Lurrus)
#27 Xwhale: Humans (WUBRG)
#28 Wiltron92: Grixis Shadow (UBR)
#29 iaky91: Bogles (WG)
#30 eXavie: Temur Control (URG)
#31 Jokersrwild: Golgari Midrange (BG)
#32 TheBigMoke: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_09_20 : EventTest
    {
        [Test]
        public void Deck01_TheEnzym_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",0),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck02_IzzetSignetIsTheBest_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",1),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck03_DrRobertSpaghetti_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",2),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",3),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck05_staffmat1992_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",4),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_GravenCairns_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",5),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Smdster_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",6),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_JB2002_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",7),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_solaec0501_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_ilmatagatto_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",9),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Delpoctrol_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",10),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Rebus8_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Gerschi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",12),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Antoine57437_AbzanCompany_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",13),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck15_AnActualPotato_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",14),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_wambocombo2020_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Magister1993_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",16),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Erik157751_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",17),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Rulleboren_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",18),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_AstralPlane_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",19),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Bullwinkkle6705_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",20),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Trid0n_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",21),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck23_SebastianStueckl_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",22),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_kiko_JeskaiTaxes_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",23),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck25_quinniac_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",24),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_pokerswizard_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",25),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_Xwhale_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",26),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Wiltron92_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",27),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck29_iaky91_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",28),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck30_eXavie_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",29),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Jokersrwild_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",30),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_TheBigMoke_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-20",31),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
