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
#01 sff_mtg: KGC Tron (G)
#02 bnlunt: U Tron (U)
#03 alemilan19: E Tron (C)
#04 Toastxp: Jund Prowess (BRG)
#05 jhollan42: Gifts Storm (UR)
#06 TSPJendrek: Azorius Control (WU)
#07 Ganksyou: Azorius Control (WU)
#08 _Falcon_: E Tron (C)
#09 DarthMalak: Smallpox (WB)
#10 komattaman: Gruul Midrange (RG)
#11 siomomi: E Tron (C)
#12 _alice1986_: Mardu Prowess (WBR, Lurrus)
#13 Delthar: Infect (UG)
#14 JV_7777: E Tron (C)
#15 MATTHEWFOULKES: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_22 : EventTest
    {
        [Test]
        public void Deck01_sffmtg_KGCTron_G()
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
        public void Deck04_Toastxp_JundProwess_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
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
        public void Deck06_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Ganksyou_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
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
        public void Deck10_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",9),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
        public void Deck12_alice1986_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
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
        public void Deck15_MATTHEWFOULKES_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-22",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
