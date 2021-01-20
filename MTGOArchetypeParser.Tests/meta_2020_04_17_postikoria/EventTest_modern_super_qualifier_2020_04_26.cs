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
#01 Blade400: Eldrazi Tron (C)
#02 im2g00t4ubarn: Bant Control (WUG)
#03 Naisirc: Hardened Scales (BG, Lurrus)
#04 quinniac: Devoted (WG, Lurrus)
#05 NIMAME: Ad Nauseam (WUB)
#06 kbr3: Hardened Scales (WG, Lurrus)
#07 Rhianne: Dredge (BRG)
#08 Brener: Golgari Midrange (BG, Lurrus)
#09 sokos13: UBRG Control (UBRG, Lurrus)
#10 MadMaxErnst: UBRG Control (UBRG, Lurrus)
#11 SourceOdin: Uroza (URG, Yorion)
#12 signblindman: Gruul Midrange (RG, Obosh)
#13 Golgarburr: Jund Midrange (BRG, Lurrus)
#14 Papelucho10: Infect (UG)
#15 Adam_Hen: Jund Midrange (BRG, Lurrus)
#16 Gerschi: Jund Prowess (BRG, Lurrus)
#17 Bayesta_93: Burn (WR, Lurrus)
#18 albert62: Jund Midrange (BRG, Lurrus)
#19 PTarts2win: Eldrazi Tron (C)
#20 Ma7x: Niv To Light (WUBRG, Yorion)
#21 Sonso JF: Boros Prowess (WR, Lurrus)
#22 jsteed: Jund Midrange (BRG, Lurrus)
#23 Bloodbraid__Elf: Ad Nauseam (WUB)
#24 Finespoo: Dredge (BRG)
#25 Troeffelhelt: Elves (WG, Zirda)
#26 Uagli1: Goblins (BRG)
#27 Quatch: Ad Nauseam (WUB)
#28 ImAFireHydrant: UBRG Control (UBRG, Lurrus)
#29 coert: Burn (WR, Lurrus)
#30 __BMJ__: Grixis Shadow (UBR, Lurrus)
#31 VA1VE: Ad Nauseam (WUB)
#32 yuurari_yuko: Amulet Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_04_26 : EventTest
    {
        [Test]
        public void Deck01_Blade400_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",0),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_im2g00t4ubarn_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",1),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Naisirc_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",2),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_quinniac_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",3),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_NIMAME_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",4),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck06_kbr3_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",5),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Rhianne_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",6),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Brener_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",7),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_sokos13_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",8),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_MadMaxErnst_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",9),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_SourceOdin_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",10),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_signblindman_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",11),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_Golgarburr_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",12),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",13),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck15_AdamHen_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",14),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Gerschi_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",15),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Bayesta93_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",16),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_albert62_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",17),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_PTarts2win_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",18),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_Ma7x_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",19),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_SonsoJF_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",20),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_jsteed_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",21),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_BloodbraidElf_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",22),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Finespoo_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",23),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Troeffelhelt_Elves_WG_Zirda()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",24),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Elves),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck26_Uagli1_Goblins_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",25),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Quatch_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",26),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ImAFireHydrant_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",27),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",28),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_BMJ_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",29),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_VA1VE_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",30),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck32_yuurariyuko_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-26",31),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
