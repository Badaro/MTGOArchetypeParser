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
#01 PuntThenWhine: Amulet Titan (G)
#02 last7stand: Humans (WUBRG)
#03 Ibio: Grixis Shadow (UBR)
#04 maxxattack: Infect (UG)
#05 yamakiller: Eldrazi Tron (C)
#06 N3nne: Burn (WR)
#07 midcardpromo: Simic Taxes (UG)
#08 BrainSmoothie: Mardu Midrange (WBR)
#09 Oliver_Hart: Infect (UG)
#10 CarlSwaggin: Green Tron (G)
#11 updraftelemental: UBRG Shadow (UBRG)
#12 Xwhale: Dredge (BRG)
#13 MyNameTidus: Amulet Titan (UG)
#14 Gods_Shadow: Primeval Titan (RG)
#15 Ramp: Titan Shift (RG)
#16 BernardoDG: Jund Midrange (BRG)
#17 B1gDan: Bant Midrange (WUG)
#18 Dazai: Bant Control (WUG)
#19 audio336: Sultai Shadow (UBG)
#20 Tiemuuu: Izzet Control (UR)
#21 Epachniak: Mono Red Prowess (R)
#22 Schiaveto: UBRG Shadow (UBRG)
#23 crazeejakee07: Bant Midrange (WUG)
#24 kenjinsakura: Grixis Shadow (UBR)
#25 Pikula: Grixis Shadow (UBR)
#26 llawtonss: Bant Control (WUG)
#27 OPMegaProEloKoks: Crabvine (UBG)
#28 namanii: Titan Shift (RG)
#29 JOXEMI333: Green Tron (G)
#30 Chipsoss: Sultai Shadow (UBG)
#31 Brener: Gifts Storm (UR)
#32 NMSX: Simic Taxes (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_03_lastokodays
{
    public class EventTest_modern_challenge_2019_12_10 : EventTest
    {
        [Test]
        public void Deck01_PuntThenWhine_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",0),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_last7stand_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",1),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Ibio_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",2),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck04_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",3),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck05_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",4),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck06_N3nne_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",5),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_midcardpromo_SimicTaxes_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",6),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck08_BrainSmoothie_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",7),
                new LastOkoDays(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_OliverHart_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",8),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck10_CarlSwaggin_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",9),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck11_updraftelemental_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",10),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Xwhale_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",11),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck13_MyNameTidus_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",12),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_GodsShadow_PrimevalTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",13),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Ramp_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",14),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck16_BernardoDG_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",15),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_B1gDan_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",16),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Dazai_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",17),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_audio336_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",18),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",19),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Epachniak_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",20),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Schiaveto_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",21),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck23_crazeejakee07_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",22),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_kenjinsakura_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",23),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Pikula_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",24),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck26_llawtonss_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",25),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_OPMegaProEloKoks_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",26),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck28_namanii_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",27),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck29_JOXEMI333_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",28),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck30_Chipsoss_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",29),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Brener_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",30),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck32_NMSX_SimicTaxes_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-10",31),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericTaxes),
                null,
                null
            );
        }


    }
}
