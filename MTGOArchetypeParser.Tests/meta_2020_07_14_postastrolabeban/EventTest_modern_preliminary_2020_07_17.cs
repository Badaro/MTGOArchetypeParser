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
#01 wambocombo2020: Ponza (RG)
#02 karatedom: RakdosProwess (WBR, Lurrus)
#03 _goblinlackey: KGCTron (G)
#04 staples87: ETron (C)
#05 _Batutinha_: IzzetProwess (UR)
#06 billsive: AzoriusControl (WU)
#07 SwordHunter: SnowSaheeli (WURG)
#08 l337erhosen: Elementals (WUBRG)
#09 mac121711: SnoopGoblins (BR)
#10 Gerschi: GrixisShadow (UBR)
#11 unicornparadise: AzoriusStoneblade (WU)
#12 EskimoJoe: KGCTron (G)
#13 BnR: GrixisShadow (UBR)
#14 mariogomes097: GrixisShadow (UBR)
#15 MZBlazer: Jund (BRG)
#16 Phill_Hellmuth: Jund (BRG)
#17 cariollins: IzzetProwess (UR)
#18 Daking3603: SnoopGoblins (BR)
#19 PeanutBrittle: IzzetProwess (UR)
#20 Edel: Jund (BRG)
#21 sandydogmtg: SnoopGoblins (BR)
#22 Ennuixd: GiftsStorm (UR)
#23 Nammersquats: Infect (UG)
#24 SebastianStueckl: SultaiSnow (UBG)
#25 Searzist: Prowess (R)
#26 qbturtle15: AzoriusStoneblade (WU)
#27 GombleWhop: ETron (C)
#28 _LSN_: Burn (WR)
#29 MrRaeb: SultaiSnow (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_17 : EventTest
    {
        [Test]
        public void Deck01_wambocombo2020_Ponza_RG()
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
        public void Deck02_karatedom_Prowess_RakdosProwess_WBR_Lurrus()
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
        public void Deck03_goblinlackey_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_staples87_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",3),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Batutinha_Prowess_IzzetProwess_UR()
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
        public void Deck07_SwordHunter_SaheeliCombo_SnowSaheeli_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
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
        public void Deck09_mac121711_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck10_Gerschi_DeathsShadow_GrixisShadow_UBR()
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
        public void Deck11_unicornparadise_AzoriusControl_AzoriusStoneblade_WU()
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
        public void Deck12_EskimoJoe_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",11),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck13_BnR_DeathsShadow_GrixisShadow_UBR()
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
        public void Deck14_mariogomes097_DeathsShadow_GrixisShadow_UBR()
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
        public void Deck15_MZBlazer_Rock_Jund_BRG()
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
        public void Deck16_PhillHellmuth_Rock_Jund_BRG()
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
        public void Deck17_cariollins_Prowess_IzzetProwess_UR()
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
        public void Deck18_Daking3603_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck19_PeanutBrittle_Prowess_IzzetProwess_UR()
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
        public void Deck20_Edel_Rock_Jund_BRG()
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
        public void Deck21_sandydogmtg_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
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
        public void Deck24_SebastianStueckl_SnowControl_SultaiSnow_UBG()
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
        public void Deck25_Searzist_Prowess_R()
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
        public void Deck26_qbturtle15_AzoriusControl_AzoriusStoneblade_WU()
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
        public void Deck27_GombleWhop_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-17",26),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
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
        public void Deck29_MrRaeb_SnowControl_SultaiSnow_UBG()
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
