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
#01 baiburqueno: Eldrazi Tron (G)
#02 brog: Devoted (WUG)
#03 B1gDan: Bant Midrange (WUG)
#04 SourceOdin: Urza Oko (WUG)
#05 Ivan_Catanduva_Br: Spirits (WUG)
#06 bolov0: Primeval Titan (UG)
#07 KeeperX: Naya Midrange (WRG)
#08 GrimValdimor: Eldrazi Tron (C)
#09 yanmaster: Hardened Scales (G)
#10 Nammersquats: Humans (WUBRG)
#11 Xuxa: Dredge (BRG)
#12 SKK: Amulet Titan (UG)
#13 Broniak: Titan Shift (RG)
#14 zachattack23: Urza Oko (UBG)
#15 MTG-Maestro: Urza Oko (UG)
#16 FedeSamba: Titan Shift (RG)
#17 tomvon9: Green Tron (WG)
#18 twinlesstwin: Yawgmoth (BG)
#19 McWinSauce: Bant Control (WUG)
#20 UrBffTricks: WUBG Control (WUBG)
#21 sebastianpozzo: Green Eldrazi (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_24 : EventTest
    {
        [Test]
        public void Deck01_baiburqueno_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",0),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_brog_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",1),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck03_B1gDan_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",2),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_SourceOdin_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",3),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck05_IvanCatanduvaBr_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",4),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck06_bolov0_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",5),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck07_KeeperX_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",6),
                "LastOkoDays",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_GrimValdimor_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",7),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_yanmaster_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",8),
                "LastOkoDays",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",9),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Xuxa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",10),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck12_SKK_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",11),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck13_Broniak_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",12),
                "LastOkoDays",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck14_zachattack23_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",13),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck15_MTGMaestro_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",14),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck16_FedeSamba_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",15),
                "LastOkoDays",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck17_tomvon9_GreenTron_WG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",16),
                "LastOkoDays",
                ArchetypeColor.WG,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck18_twinlesstwin_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",17),
                "LastOkoDays",
                ArchetypeColor.BG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck19_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",18),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_UrBffTricks_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",19),
                "LastOkoDays",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_sebastianpozzo_GreenEldrazi_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",20),
                "LastOkoDays",
                ArchetypeColor.UG,
                "GreenEldrazi",
                null,
                null
            );
        }


    }
}
