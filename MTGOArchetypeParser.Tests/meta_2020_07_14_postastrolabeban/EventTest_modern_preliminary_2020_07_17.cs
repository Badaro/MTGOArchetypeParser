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
#01 wambocombo2020: Gruul Midrange (RG)
#02 karatedom: Mardu Prowess (WBR, Lurrus)
#03 _goblinlackey: Green Tron (G)
#04 staples87: Eldrazi Tron (C)
#05 _Batutinha_: Izzet Prowess (UR)
#06 billsive: Azorius Control (WU)
#07 SwordHunter: Saheeli Combo (WURG)
#08 l337erhosen: Elementals (WUBRG)
#09 mac121711: Goblins (BR)
#10 Gerschi: Grixis Shadow (UBR)
#11 unicornparadise: Azorius Control (WU)
#12 EskimoJoe: Green Tron (G)
#13 BnR: Grixis Shadow (UBR)
#14 mariogomes097: Grixis Shadow (UBR)
#15 MZBlazer: Jund Midrange (BRG)
#16 Phill_Hellmuth: Jund Midrange (BRG)
#17 cariollins: Izzet Prowess (UR)
#18 Daking3603: Goblins (BR)
#19 PeanutBrittle: Izzet Prowess (UR)
#20 Edel: Jund Midrange (BRG)
#21 sandydogmtg: Goblins (BR)
#22 Ennuixd: Gifts Storm (UR)
#23 Nammersquats: Infect (UG)
#24 SebastianStueckl: Sultai Control (UBG)
#25 Searzist: Mono Red Prowess (R)
#26 qbturtle15: Azorius Control (WU)
#27 GombleWhop: Eldrazi Tron (C)
#28 _LSN_: Burn (WR)
#29 MrRaeb: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_17 : EventTest
    {
        [Test]
        public void Deck01_wambocombo2020_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",0),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_karatedom_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_goblinlackey_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck04_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",3),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_Batutinha_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_billsive_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SwordHunter_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_l337erhosen_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck09_mac121711_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Gerschi_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck11_unicornparadise_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_EskimoJoe_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",11),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck13_BnR_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck14_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_MZBlazer_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_PhillHellmuth_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",15),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_cariollins_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Daking3603_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck19_PeanutBrittle_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Edel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_sandydogmtg_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Ennuixd_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck24_SebastianStueckl_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",23),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Searzist_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",24),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_GombleWhop_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",26),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck28_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck29_MrRaeb_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
