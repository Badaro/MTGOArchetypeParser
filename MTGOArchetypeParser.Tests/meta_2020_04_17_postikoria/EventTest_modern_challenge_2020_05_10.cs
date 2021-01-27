using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 AvocadoToast: Jund Midrange (BRG, Lurrus)
#02 PlebSwagger: Boros Prowess (WR, Lurrus)
#03 yamakiller: Boros Prowess (WR, Lurrus)
#04 NinoMtg: Delver (UBR, Lurrus)
#05 pokerswizard: Boros Prowess (WR, Lurrus)
#06 aspiringspike: Miracles (WU, Kaheera)
#07 Wizard_Of_Jack: Jund Midrange (BRG, Lurrus)
#08 CaptainFarbosa: Reclamation (UBG)
#09 Karolmo: Titan Shift (RG)
#10 Doni_Dominaria: Gruul Midrange (RG, Obosh)
#11 Do0mSwitch: Miracles (WU)
#12 MikeEgan: Delver (UBR, Lurrus)
#13 Sharkcaster_Mage: Primeval Titan (UG)
#14 Lucabireskusku: Thopter Combo (UB, Lurrus)
#15 AlecInTheInk: Titan Shift (RG)
#16 TSPJendrek: Dimir Control (UB, Lurrus)
#17 Chefen: Gruul Midrange (RG, Obosh)
#18 maximusdee: Primeval Titan (UG)
#19 A22en: Bant Control (WUG, Yorion)
#20 Amigobriell: WURG Control (WURG, Yorion)
#21 2jjm: Burn (WR, Lurrus)
#22 gilliganisla: Green Tron (G)
#23 DoctorofTime: Living End (WURG)
#24 Naisirc: Hardened Scales (BG, Lurrus)
#25 fingers1991: Boros Prowess (WR, Lurrus)
#26 Darkiundsa: WUBG Control (WUBG, Yorion)
#27 PTarts2win: Primeval Titan (UG)
#28 Parrit: Hardened Scales (BG, Lurrus)
#29 Nyph: Amulet Titan (UG)
#30 TERROl2: Jund Midrange (BRG, Lurrus)
#31 TerminalJustice: Gifts Storm (UR)
#32 bit_error: Bogles (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_10 : EventTest
    {
        [Test]
        public void Deck01_AvocadoToast_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",0),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_PlebSwagger_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",1),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_yamakiller_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",2),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_NinoMtg_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",3),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Delver",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_pokerswizard_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",4),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_aspiringspike_Miracles_WU_Kaheera()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",5),
                "PostIkoria",
                ArchetypeColor.WU,
                "Miracles",
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck07_WizardOfJack_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",6),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_CaptainFarbosa_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",7),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Karolmo_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",8),
                "PostIkoria",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck10_DoniDominaria_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",9),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_Do0mSwitch_Miracles_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",10),
                "PostIkoria",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck12_MikeEgan_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",11),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Delver",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_SharkcasterMage_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",12),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Lucabireskusku_ThopterCombo_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",13),
                "PostIkoria",
                ArchetypeColor.UB,
                "ThopterCombo",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_AlecInTheInk_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",14),
                "PostIkoria",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck16_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",15),
                "PostIkoria",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Chefen_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",16),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_maximusdee_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",17),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck19_A22en_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",18),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_Amigobriell_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",19),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",20),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_gilliganisla_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",21),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck23_DoctorofTime_LivingEnd_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",22),
                "PostIkoria",
                ArchetypeColor.WURG,
                "LivingEnd",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Naisirc_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",23),
                "PostIkoria",
                ArchetypeColor.BG,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_fingers1991_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",24),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Darkiundsa_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",25),
                "PostIkoria",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_PTarts2win_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",26),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",27),
                "PostIkoria",
                ArchetypeColor.BG,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Nyph_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",28),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck30_TERROl2_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",29),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_TerminalJustice_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",30),
                "PostIkoria",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck32_biterror_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",31),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
