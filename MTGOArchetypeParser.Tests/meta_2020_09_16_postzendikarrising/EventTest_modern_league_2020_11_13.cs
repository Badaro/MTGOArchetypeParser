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
#01 Ivc: Azorius Control (WU)
#02 ragingpikey: Spirits (WU)
#03 Karnesis93: Rakdos Prowess (BR, Lurrus)
#04 mariogomes097: Grixis Shadow (UBR)
#05 Aramyll: Humans (WUBRG)
#06 Scabs: Heliod Combo (WG)
#07 Binolino: Reclaimer Titan (WRG)
#08 Giaws: Shadow Prowess (BR, Lurrus)
#09 sydneydude: Mono Red Prowess (R, Jegantha)
#10 Evaros: Omnath Saheeli (WURG, Yorion)
#11 eXavie: Azorius Taxes (WU, Yorion)
#12 Ely_Silva: Burn (WRG)
#13 victorroatt: Elves (G)
#14 Darkiundsa: Bant Control (WUG, Yorion)
#15 Violent_Outburst: Polymorph (RG)
#16 White_Fish: Hardened Scales (BG, Lurrus)
#17 visitor636: Azorius Control (WU)
#18 bcs8995: Selenya Midrange (WG)
#19 MrRaeb: UBRG Control (UBRG)
#20 MadMaxErnst: Jund Midrange (BRG, Lurrus)
#21 lineopen: Selective Oracle (WU)
#22 Darshik: Naban Wizards (UR)
#23 apriolo1: Amulet Titan (WURG)
#24 Chichichi: Izzet Prowess (UR)
#25 Borjillamtg10: Rakdos Midrange (BR)
#26 seasonofmists: Abzan Company (WBRG)
#27 yuurari_yuko: E Tron (C)
#28 Sanitoeter: Jund Midrange (BRG)
#29 dsissowin: Mono Red Prowess (R)
#30 creepypasta: Izzet Control (UR)
#31 TSPJendrek: Dimir Control (UB)
#32 ProfGOak: Temur Control (URG)
#33 Easyldur1: Dredge (BRG)
#34 Pernobyl: Golgari Midrange (BG, Lurrus)
#35 SeventhProphet: Zombies (WB, Lurrus)
#36 MiketheKnight512: Jund Midrange (BRG)
#37 CrusherBotBG: Hammer Time (W, Lurrus)
#38 fifteenstepper: Infect (UG)
#39 Lukas261997: Amulet Titan (URG)
#40 azax: KGC Tron (G)
#41 antonio00: WURG Control (WURG)
#42 matiaskm: Devoted (WG, Lurrus)
#43 Lordzedane: Bant Blink (WUG)
#44 Gigy: Gruul Midrange (RG)
#45 saidin.raken: Scapeshift (URG)
#46 hugofreitas1: Gifts Storm (UR)
#47 rubenelvas: Oops All Spells (WUBRG)
#48 RagingTiltMonster: Izzet Phoenix (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_11_13 : EventTest
    {
        [Test]
        public void Deck01_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-13",0),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ragingpikey_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-13",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Karnesis93_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-13",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-11-13",3),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Aramyll_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Scabs_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Binolino_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",6),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck08_Giaws_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-13",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_sydneydude_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-11-13",8),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Evaros_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-13",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_eXavie_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-13",10),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_ElySilva_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",11),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_victorroatt_Elves_G()
        {
            Test(
                GetDeck("modern-league-2020-11-13",12),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Darkiundsa_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-13",13),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_ViolentOutburst_Polymorph_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",14),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck16_WhiteFish_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-13",15),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_visitor636_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-13",16),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_bcs8995_SelenyaMidrange_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",17),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",18),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_MadMaxErnst_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-13",19),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_lineopen_SelectiveOracle_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-13",20),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(SelectiveOracle),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Darshik_NabanWizards_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-13",21),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(NabanWizards),
                null,
                null
            );
        }

        [Test]
        public void Deck23_apriolo1_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",22),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_Chichichi_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-13",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Borjillamtg10_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-13",24),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_seasonofmists_AbzanCompany_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",25),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck27_yuurariyuko_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-13",26),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Sanitoeter_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",27),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_dsissowin_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-11-13",28),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck30_creepypasta_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-13",29),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_TSPJendrek_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-13",30),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_ProfGOak_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",31),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Easyldur1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",32),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Pernobyl_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-13",33),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_SeventhProphet_Zombies_WB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-13",34),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(Zombies),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck36_MiketheKnight512_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",35),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck37_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-13",36),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_fifteenstepper_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",37),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Lukas261997_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",38),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck40_azax_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-11-13",39),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck41_antonio00_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",40),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-13",41),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck43_Lordzedane_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",42),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",43),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck45_saidinraken_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",44),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck46_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-13",45),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck47_rubenelvas_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-13",46),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck48_RagingTiltMonster_IzzetPhoenix_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-13",47),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetPhoenix),
                null,
                null
            );
        }


    }
}
