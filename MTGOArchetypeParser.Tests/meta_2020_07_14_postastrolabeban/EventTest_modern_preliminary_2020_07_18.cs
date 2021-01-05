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
#01 Rav104: Izzet Prowess (UR)
#02 SouthernSliver: Slivers (WUBRG)
#03 Toastxp: Mardu Prowess (WBR, Lurrus)
#04 lsmguys: Azorius Control (WU)
#05 Nammersquats: Infect (UG)
#06 OscarS66: Rakdos Midrange (BR)
#07 _LSN_: Burn (WR)
#08 GedionRavenor: Sultai Control (UBG)
#09 jhollan42: Amulet Titan (UG)
#10 NHA37: Burn (WR)
#11 Thrall90: Jund Midrange (BRG)
#12 bbq42069dude: Humans (WUBRG)
#13 DylansHyper: Dredge (BRG)
#14 BoltTheBirds: Gifts Storm (UR)
#15 gazmon48: E Tron (C)
#16 hodortimebaby: KGC Tron (G)
#17 Night_Owl_61: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_18 : EventTest
    {
        [Test]
        public void Deck01_Rav104_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_lsmguys_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_OscarS66_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck08_GedionRavenor_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_jhollan42_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_NHA37_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_bbq42069dude_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_DylansHyper_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_BoltTheBirds_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck15_gazmon48_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",14),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_hodortimebaby_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",15),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_NightOwl61_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
