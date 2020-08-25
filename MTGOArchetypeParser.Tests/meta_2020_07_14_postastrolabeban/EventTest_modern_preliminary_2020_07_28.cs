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
#01 Ganksyou: AzoriusControl (WU)
#02 Rhianne: Dredge (WBRG)
#03 tylerjjobrien: BringToNiv (WUBRG, Yorion)
#04 Zar0s: Scapeshift (URG)
#05 RodeoJones: SnowSaheeli (WURG)
#06 Thrall90: JundMidrange (BRG)
#07 Redgy819: ETron (C)
#08 katuo079595: Scapeshift (URG)
#09 ArchaeusDota: KGCTron (G)
#10 mylast: IzzetProwess (UR)
#11 rastaf: IzzetProwess (UR)
#12 Znapcaster: BantControl (WUG)
#13 spellvine: IzzetProwess (UR)
#14 Xwhale: SnoopGoblins (BR)
#15 Wizard_2002: Humans (WUBRG)
#16 komattaman: GruulMidrange (RG)
#17 McWinSauce: TemurReclamation (URG)
#18 jhollan42: BantControl (WUG)
#19 SakeIzumo: IzzetProwess (UR)
#20 tanisong1221: AzoriusControl (WU)
#21 Lavaridge: GruulMidrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_28 : EventTest
    {
        [Test]
        public void Deck01_Ganksyou_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Rhianne_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_tylerjjobrien_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Zar0s_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",3),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck05_RodeoJones_SnowSaheeli_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                null
            );
        }

        [Test]
        public void Deck06_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Redgy819_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_katuo079595_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",7),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ArchaeusDota_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",8),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck10_mylast_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_rastaf_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Znapcaster_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_spellvine_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Xwhale_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck15_Wizard2002_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",15),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_McWinSauce_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",16),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck18_jhollan42_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SakeIzumo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck20_tanisong1221_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Lavaridge_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",20),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
