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
#01 Sodeq: Dredge (BRG)
#02 SourceOdin: Simic Prowess (UG)
#03 Gul_Dukat: Temur Prowess (URG)
#04 cityofcards: Eldrazi Tron (C)
#05 PuntThenWhine: Amulet Titan (RG)
#06 jschloss: Golgari Midrange (BG)
#07 LSMD: Grixis Shadow (UBR)
#08 Chefen: Eldrazi Tron (G)
#09 GNT: Mono Red Prowess (R)
#10 LoneCubone: Infect (WG)
#11 Zacharee: Devoted (WUG)
#12 McWinSauce: Bant Control (WUG)
#13 exoticherman: Infect (UG)
#14 mrounds1216: Mono Blue Prowess (U)
#15 Runeskjold: Electro Balance (UR)
#16 Zxrogue: Niv To Light (WUBRG)
#17 BorosCharm: Burn (WR)
#18 Tyrannical: Eldrazi Tron (C)
#19 Poderosisimo: Crabvine (UBG)
#20 bladede: Green Tron (G)
#21 PRGJJAR: Dredge (BRG)
#22 nahuel10: Burn (WR)
#23 Ivan_Catanduva_Br: Temur Prowess (URG)
#24 dillyg10: Bant Midrange (WUG)
#25 FromTheCrypt: Green Tron (G)
#26 Twibs: Eldrazi Tron (C)
#27 BananOlaf: Devoted (WUG)
#28 AndreaMazzone: Burn (WR)
#29 genkytoro: Jund Midrange (BRG)
#30 Tsunidae: Amulet Titan (UG)
#31 msskinbolic: Eldrazi Tron (C)
#32 Jadacant: Primeval Titan (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_challenge_2020_01_12 : EventTest
    {
        [Test]
        public void Deck01_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",0),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SourceOdin_SimicProwess_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck03_GulDukat_TemurProwess_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",2),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck04_cityofcards_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",3),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_PuntThenWhine_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",4),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_jschloss_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",5),
                new LastOkoDays(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_LSMD_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",6),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Chefen_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",7),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_GNT_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",8),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_LoneCubone_Infect_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",9),
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Zacharee_Devoted_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",10),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck12_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",11),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",12),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck14_mrounds1216_MonoBlueProwess_U()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",13),
                new LastOkoDays(),
                ArchetypeColor.U,
                typeof(ParadoxicalUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Runeskjold_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",14),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck16_Zxrogue_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",15),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck17_BorosCharm_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",16),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Tyrannical_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",17),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_Poderosisimo_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",18),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck20_bladede_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",19),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck21_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",20),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck22_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",21),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck23_IvanCatanduvaBr_TemurProwess_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",22),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck24_dillyg10_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",23),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_FromTheCrypt_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",24),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck26_Twibs_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",25),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_BananOlaf_Devoted_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",26),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck28_AndreaMazzone_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",27),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck29_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",28),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Tsunidae_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",29),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck31_msskinbolic_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",30),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck32_Jadacant_PrimevalTitan_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-12",31),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }


    }
}