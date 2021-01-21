using FluentAssertions;
using MTGOArchetypeParser.Model;
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
#15 gazmon48: Eldrazi Tron (C)
#16 hodortimebaby: Green Tron (G)
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
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",1),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",2),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_lsmguys_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",3),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",4),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck06_OscarS66_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",5),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",6),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck08_GedionRavenor_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",7),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_jhollan42_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",8),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck10_NHA37_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",9),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck11_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",10),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_bbq42069dude_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",11),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck13_DylansHyper_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",12),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck14_BoltTheBirds_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",13),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck15_gazmon48_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",14),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck16_hodortimebaby_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",15),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck17_NightOwl61_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-18",16),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
