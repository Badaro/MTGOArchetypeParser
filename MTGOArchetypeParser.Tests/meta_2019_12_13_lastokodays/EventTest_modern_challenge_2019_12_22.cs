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
#01 Toastxp: Urza Oko (WUG)
#02 Brener: Bant Midrange (WUG)
#03 Nisus: Crabvine (UBG)
#04 McWinSauce: Bant Control (WUG)
#05 MLupa: Bant Midrange (WUG)
#06 _IlNano_: Humans (WUBRG)
#07 LSMD: Grixis Shadow (UBR)
#08 LORiWWA: Amulet Titan (UG)
#09 VTCLA: Urza Oko (UG)
#10 Numena_Lowallyn: Eldrazi Tron (G)
#11 AlphaFrog: Eldrazi Tron (C)
#12 Danker: Bant Control (WUG)
#13 Prescienced: Green Eldrazi (UG)
#14 thestudygroup: Mono White Taxes (W)
#15 SoulStrong: UBRG Shadow (UBRG)
#16 kiko: Esper Taxes (WUB)
#17 MentalMisstep: Thopter Urza (WUBG)
#18 Laplasjan: Eldrazi Tron (C)
#19 zebhillard: Titan Shift (RG)
#20 CyrusCG: Titan Shift (RG)
#21 Tiemuuu: Izzet Control (UR)
#22 llawtonss: Izzet Control (UR)
#23 Degan1: Bant Midrange (WUG)
#24 cronman87: Mono Red Prowess (R)
#25 RicardoMSLan: Eldrazi Tron (C)
#26 Coly2: Mono Red Prowess (R)
#27 Lord_Beerus: Bant Control (WUG)
#28 trap_man: Mono Red Prowess (R)
#29 blastoids: Grixis Shadow (UBR)
#30 B1gDan: Bant Midrange (WUG)
#31 coert: Mono Red Prowess (R)
#32 TheGaul: Golgari Midrange (BG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_challenge_2019_12_22 : EventTest
    {
        [Test]
        public void Deck01_Toastxp_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",0),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Brener_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",1),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Nisus_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",2),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",3),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MLupa_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",4),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_IlNano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",5),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_LSMD_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",6),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_LORiWWA_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",7),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_VTCLA_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",8),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck10_NumenaLowallyn_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",9),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_AlphaFrog_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",10),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_Danker_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",11),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Prescienced_GreenEldrazi_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",12),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck14_thestudygroup_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",13),
                new LastOkoDays(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",14),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck16_kiko_EsperTaxes_WUB()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",15),
                new LastOkoDays(),
                ArchetypeColor.WUB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck17_MentalMisstep_ThopterUrza_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",16),
                new LastOkoDays(),
                ArchetypeColor.WUBG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck18_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",17),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_zebhillard_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",18),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck20_CyrusCG_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",19),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck21_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",20),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_llawtonss_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",21),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Degan1_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",22),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_cronman87_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",23),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck25_RicardoMSLan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",24),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck26_Coly2_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",25),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck27_LordBeerus_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",26),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_trapman_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",27),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck29_blastoids_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",28),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck30_B1gDan_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",29),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_coert_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",30),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck32_TheGaul_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-22",31),
                new LastOkoDays(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
