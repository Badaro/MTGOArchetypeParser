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
#01 mac121711: Jeskai Control (WUR)
#02 AstralPlane: Izzet Prowess (UR)
#03 chengyiw: Dredge (WBRG)
#04 JV_7777: E Tron (C)
#05 SakeIzumo: Izzet Prowess (UR)
#06 TheLousyZoot: Snoop Goblins (WBR)
#07 tyaburi: Mono Red Prowess (R)
#08 Zonast: Ad Nauseam (WUB)
#09 nekonekoneko: Dredge (WBRG)
#10 updraftelemental: Jund Shadow (BRG)
#11 Toastxp: Gruul Prowess (RG, Jegantha)
#12 Granham: Azorius Control (WU)
#13 Lexmart: Bant Control (WUG)
#14 kanister: Temur Control (URG)
#15 Nickburch13: Burn (WR, Lurrus)
#16 _INF_: Gifts Storm (UR)
#17 hoveydw: Jund Shadow (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_25 : EventTest
    {
        [Test]
        public void Deck01_mac121711_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_AstralPlane_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_chengyiw_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_JV7777_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",3),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SakeIzumo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TheLousyZoot_SnoopGoblins_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck07_tyaburi_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",6),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Zonast_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck09_nekonekoneko_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_updraftelemental_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Toastxp_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",10),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_Granham_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Lexmart_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kanister_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",13),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nickburch13_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck17_hoveydw_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-25",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
