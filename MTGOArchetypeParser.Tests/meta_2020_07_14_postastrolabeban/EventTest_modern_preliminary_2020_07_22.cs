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
#01 sff_mtg: KGCTron (G)
#02 bnlunt: UTron (U)
#03 alemilan19: ETron (C)
#04 Toastxp: JundProwess (BRG)
#05 jhollan42: GiftsStorm (UR)
#06 TSPJendrek: AzoriusStoneblade (WU)
#07 Ganksyou: AzoriusStoneblade (WU)
#08 _Falcon_: ETron (C)
#09 DarthMalak: Smallpox (WB)
#10 komattaman: Ponza (RG)
#11 siomomi: ETron (C)
#12 _alice1986_: RakdosProwess (BR, Lurrus)
#13 Delthar: Infect (UG)
#14 JV_7777: ETron (C)
#15 MATTHEWFOULKES: IzzetProwess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_22 : EventTest
    {
        [Test]
        public void Deck01_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",0),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck02_bnlunt_UTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",1),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_alemilan19_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",2),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Toastxp_Prowess_JundProwess_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Prowess),
                typeof(JundProwess),
                null
            );
        }

        [Test]
        public void Deck05_jhollan42_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TSPJendrek_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck07_Ganksyou_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck08_Falcon_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",7),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_DarthMalak_Smallpox_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck10_komattaman_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",9),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_siomomi_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",10),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_alice1986_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Delthar_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck14_JV7777_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",13),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_MATTHEWFOULKES_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }


    }
}
