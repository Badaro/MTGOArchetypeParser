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
#01 AvocadoToast: Jund Midrange (BRG, Lurrus)
#02 PlebSwagger: Boros Prowess (WR, Lurrus)
#03 yamakiller: Boros Prowess (WR, Lurrus)
#04 NinoMtg: Delver (UBR, Lurrus)
#05 pokerswizard: Boros Prowess (WR, Lurrus)
#06 aspiringspike: Azorius Control (WU, Kaheera)
#07 Wizard_Of_Jack: Jund Midrange (BRG, Lurrus)
#08 CaptainFarbosa: Reclamation (UBG)
#09 Karolmo: Titan Shift (RG)
#10 Doni_Dominaria: Gruul Midrange (RG, Obosh)
#11 Do0mSwitch: Azorius Control (WU)
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
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_PlebSwagger_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",1),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_yamakiller_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",2),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_NinoMtg_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",3),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_pokerswizard_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",4),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_aspiringspike_AzoriusControl_WU_Kaheera()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",5),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck07_WizardOfJack_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",6),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_CaptainFarbosa_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",7),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Karolmo_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",8),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck10_DoniDominaria_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",9),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_Do0mSwitch_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",10),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_MikeEgan_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",11),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_SharkcasterMage_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",12),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Lucabireskusku_ThopterCombo_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",13),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_AlecInTheInk_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",14),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck16_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",15),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Chefen_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",16),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_maximusdee_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",17),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck19_A22en_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",18),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_Amigobriell_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",19),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",20),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_gilliganisla_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",21),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck23_DoctorofTime_LivingEnd_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",22),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Naisirc_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",23),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_fingers1991_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",24),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Darkiundsa_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",25),
                new PostIkoria(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_PTarts2win_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",26),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",27),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Nyph_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",28),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_TERROl2_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",29),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_TerminalJustice_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",30),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck32_biterror_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-10",31),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
