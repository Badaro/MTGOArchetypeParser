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
#01 pepeteam: Urza Oko (UG)
#02 Toastxp: Urza Oko (UG)
#03 fradelrock: Eldrazi Tron (C)
#04 jessy_samek: Urza Oko (WURG)
#05 MentalMisstep: Urza Oko (UG)
#06 i_b_TRUE: Titan Shift (RG)
#07 Do0mSwitch: Bant Control (WUG)
#08 Icteridae: Devoted (WUG)
#09 Yaggdryzzill: Eldrazi Tron (C)
#10 JPA93: Infect (UG)
#11 didoguidotti1: Sultai Shadow (UBG)
#12 Volollo: Urza Oko (UG)
#13 Ihavethefire: Naya Midrange (WRG)
#14 McWinSauce: Bant Control (WUG)
#15 bershekprc10: Eldrazi Tron (C)
#16 mechint: Urza Oko (UG)
#17 sandydogmtg: Burn (R)
#18 Nilsfit: Urza Oko (UG)
#19 bobthedog: Urza Oko (UG)
#20 Valident: Azorius Control (WU)
#21 2radMTG: Bogles (WG)
#22 kangurello: Gifts Storm (UR)
#23 Nammersquats: Bant Midrange (WUG)
#24 _ctrl_q_f_: Devoted (WUG)
#25 SebastianStueckl: Merfolk (UG)
#26 LSMD: Grixis Shadow (UBR)
#27 Naisirc: Primeval Titan (UG)
#28 milikin: Dredge (BRG)
#29 shadow_PT: Eldrazi Tron (C)
#30 Sodeq: Dredge (BRG)
#31 Irra0770: Jund Midrange (BRG)
#32 KillaGerm: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_champs_2020_01_05 : EventTest
    {
        [Test]
        public void Deck01_pepeteam_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",0),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Toastxp_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck03_fradelrock_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",2),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_jessysamek_UrzaOko_WURG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",3),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MentalMisstep_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",4),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ibTRUE_TitanShift_RG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",5),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck07_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",6),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",7),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Yaggdryzzill_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",8),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_JPA93_Infect_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",9),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck11_didoguidotti1_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",10),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Volollo_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",11),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Ihavethefire_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",12),
                new LastOkoDays(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",13),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_bershekprc10_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",14),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_mechint_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",15),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck17_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",16),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Nilsfit_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",17),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck19_bobthedog_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",18),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Valident_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",19),
                new LastOkoDays(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_2radMTG_Bogles_WG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",20),
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck22_kangurello_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",21),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Nammersquats_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",22),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_ctrlqf_Devoted_WUG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",23),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck25_SebastianStueckl_Merfolk_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",24),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck26_LSMD_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",25),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Naisirc_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",26),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck28_milikin_Dredge_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",27),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck29_shadowPT_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",28),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",29),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",30),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_KillaGerm_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-01-05",31),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
