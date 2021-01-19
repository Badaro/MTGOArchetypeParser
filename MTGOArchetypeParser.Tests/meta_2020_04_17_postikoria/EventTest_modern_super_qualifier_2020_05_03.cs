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
#01 mansak: Jund Midrange (BRG, Lurrus)
#02 Ivc: Azorius Control (WU)
#03 Golgarburr: Jund Midrange (BRG, Lurrus)
#04 yuurari_yuko: Amulet Titan (URG)
#05 TennTyou: Niv To Light (WUBRG)
#06 SpiderSpace: Saheeli Combo (WUR, Yorion)
#07 otakkun: Eldrazi Tron (C)
#08 Gerardo94: Uroza (URG, Yorion)
#09 lucasensei2: Electro Balance (UR)
#10 _Phoenix_: Humans (WUBRG)
#11 jled: Jund Shadow (BRG, Lurrus)
#12 Kenzaburo: Grixis Shadow (UBR, Lurrus)
#13 nekonekoneko: Burn (WR, Lurrus)
#14 Gaffiere1903: Ad Nauseam (WUB)
#15 Parrit: Hardened Scales (BG, Lurrus)
#16 patheus_84: Ad Nauseam (WUB)
#17 theBMeister: Zirda Combo (WUG, Zirda)
#18 fistfullofmetal: Green Tron (RG, Jegantha)
#19 Scabs: Hardened Scales (BG, Lurrus)
#20 haubidtran: Kinnan Legends (WUG, Yorion)
#21 GGbizz: Ad Nauseam (WUB)
#22 signblindman: Gruul Midrange (RG, Obosh)
#23 AnneLivleysD3ath: Amulet Titan (UG)
#24 hugo87: Gifts Storm (UR)
#25 ArturRizzotti: Uroza (URG, Yorion)
#26 TrollingSaruman: Devoted (WG, Lurrus)
#27 FakeShaver: Living End (BRG)
#28 in5ano: Uroza (URG, Yorion)
#29 Heibing: WURG Control (WURG, Yorion)
#30 ecobaronen: WURG Control (WURG, Yorion)
#31 Artyom76: Gifts Storm (UR, Jegantha)
#32 Adam_Hen: Jund Midrange (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_05_03 : EventTest
    {
        [Test]
        public void Deck01_mansak_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",0),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",1),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Golgarburr_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",2),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_yuurariyuko_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",3),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",4),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SpiderSpace_SaheeliCombo_WUR_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",5),
                new PostIkoria(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",6),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_Gerardo94_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",7),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_lucasensei2_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",8),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck10_Phoenix_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",9),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck11_jled_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",10),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Kenzaburo_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",11),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_nekonekoneko_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",12),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Gaffiere1903_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",13),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",14),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",15),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck17_theBMeister_ZirdaCombo_WUG_Zirda()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",16),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(ZirdaCombo),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck18_fistfullofmetal_GreenTron_RG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",17),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck19_Scabs_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",18),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_haubidtran_KinnanLegends_WUG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",19),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(KinnanLegends),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_GGbizz_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",20),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck22_signblindman_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",21),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck23_AnneLivleysD3ath_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",22),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",23),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck25_ArturRizzotti_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",24),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_TrollingSaruman_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",25),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_FakeShaver_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",26),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck28_in5ano_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",27),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_Heibing_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",28),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck30_ecobaronen_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",29),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_Artyom76_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",30),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck32_AdamHen_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-03",31),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
