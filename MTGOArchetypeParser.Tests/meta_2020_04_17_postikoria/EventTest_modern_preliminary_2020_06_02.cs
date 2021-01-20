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
#01 Wartico1: Mardu Prowess (WBR, Lurrus)
#02 Mistakenn: Amulet Titan (UG)
#03 exoticherman: Jund Shadow (BRG, Lurrus)
#04 Toastxp: Jund Shadow (BRG, Lurrus)
#05 rastaf: Gruul Midrange (RG, Obosh)
#06 MarcoBelacca95: Gruul Midrange (RG, Obosh)
#07 sandydogmtg: Ad Nauseam (WUB)
#08 lovealienzzz: Rakdos Prowess (BR, Lurrus)
#09 themightylinguine: Rakdos Prowess (BR, Lurrus)
#10 Icteridae: Devoted (WUG)
#11 alemilan19: Scapeshift (WURG, Yorion)
#12 Xwhale: Scapeshift (URG, Yorion)
#13 ParanoidAndroid700: Orzhov Taxes (WB)
#14 TerminalJustice: Green Tron (G)
#15 uaedoliB: Humans (WUBRG)
#16 Eaglov: Primeval Titan (BG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_06_02 : EventTest
    {
        [Test]
        public void Deck01_Wartico1_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",0),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",1),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_exoticherman_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",2),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Toastxp_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",3),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_rastaf_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",4),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_MarcoBelacca95_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",5),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_sandydogmtg_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",6),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck08_lovealienzzz_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",7),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_themightylinguine_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",8),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",9),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck11_alemilan19_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",10),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_Xwhale_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",11),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_ParanoidAndroid700_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",12),
                new PostIkoria(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck14_TerminalJustice_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",13),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck15_uaedoliB_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",14),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Eaglov_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-02",15),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }


    }
}
