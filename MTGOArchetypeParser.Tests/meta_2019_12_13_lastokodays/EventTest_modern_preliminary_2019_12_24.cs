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
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_brog_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",1),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck03_B1gDan_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",2),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SourceOdin_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",3),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck05_IvanCatanduvaBr_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",4),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck06_bolov0_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",5),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck07_KeeperX_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",6),
                new LastOkoDays(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_GrimValdimor_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",7),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_yanmaster_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",8),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",9),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Xuxa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",10),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SKK_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",11),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_Broniak_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",12),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck14_zachattack23_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",13),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck15_MTGMaestro_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",14),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck16_FedeSamba_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",15),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck17_tomvon9_GreenTron_WG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",16),
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck18_twinlesstwin_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",17),
                new LastOkoDays(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck19_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",18),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_UrBffTricks_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",19),
                new LastOkoDays(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_sebastianpozzo_GreenEldrazi_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-24",20),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }


    }
}
