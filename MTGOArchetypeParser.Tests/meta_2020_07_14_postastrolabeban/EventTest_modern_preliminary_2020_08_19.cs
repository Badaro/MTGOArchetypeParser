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
#01 Laplasjan: Devoted (WG, Lurrus)
#02 coert: Burn (WR)
#03 Rooney56: BantControl (WUG)
#04 trader08111: MarduProwess (WBR, Lurrus)
#05 aManatease: IzzetProwess (UR)
#06 Lavaridge: TemurReclamation (URG)
#07 JV_7777: ETron (C)
#08 ZYX_Jerry: Burn (WR, Lurrus)
#09 ImmanuelKantrolGod: BantControl (WUG)
#10 McWinSauce: BantControl (WUG)
#11 Zar0s: TitanVial (WRG)
#12 otakkun: KGCTron (G)
#13 kbzx: IzzetProwess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_19 : EventTest
    {
        [Test]
        public void Deck01_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Rooney56_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_trader08111_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_aManatease_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Lavaridge_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",5),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck07_JV7777_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ZYXJerry_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Zar0s_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck12_otakkun_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",11),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck13_kbzx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
