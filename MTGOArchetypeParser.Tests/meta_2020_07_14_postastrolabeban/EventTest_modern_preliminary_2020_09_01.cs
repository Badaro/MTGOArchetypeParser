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
#01 toondoslav: Dredge (BRG)
#02 Gerschi: MarduProwess (WBR, Lurrus)
#03 liuyuchen: JundMidrange (BRG)
#04 Thrall90: RakdosProwess (BR, Lurrus)
#05 Beenew: KGCTron (G)
#06 McWinSauce: BantControl (WUG)
#07 kaikalbuquerque: GruulMidrange (RG)
#08 Lukas261997: KGCAmuletTitan (UBRG)
#09 1yo2yo: BantControl (WUG)
#10 paucr5: BantControl (WUG)
#11 ht991122: TemurReclamation (URG)
#12 FriskiFraska: GolgariMidrange (BG)
#13 chengyiw: RakdosProwess (BR, Lurrus)
#14 larkblue: IzzetProwess (UR)
#15 Nekonii: GolgariElves (BG)
#16 Tw33Ty: Bogles (WG, Lurrus)
#17 PRGJJAR: Dredge (BRG)
#18 Yanti: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_01 : EventTest
    {
        [Test]
        public void Deck01_toondoslav_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",0),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Gerschi_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_liuyuchen_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Thrall90_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Beenew_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",4),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck06_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_kaikalbuquerque_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",6),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Lukas261997_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_1yo2yo_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_paucr5_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_ht991122_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",10),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck12_FriskiFraska_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_chengyiw_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_larkblue_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nekonii_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck16_Tw33Ty_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Yanti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-01",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}