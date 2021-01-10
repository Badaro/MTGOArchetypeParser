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
#01 in5ano: Scapeshift (URG, Yorion)
#02 Slatorade: Bogles (WG, Lurrus)
#03 Jositoshekel: Ad Nauseam (WUB)
#04 TopherMarsh: Uroza (URG, Yorion)
#05 GiovaniMF: Boros Prowess (WR, Lurrus)
#06 ilidioTheBrabo157SL: Burn (WR, Lurrus)
#07 haubidtran: Uroza (URG, Yorion)
#08 pmc22337: Sultai Control (UBG)
#09 AJOCHUM: Mardu Prowess (WBR, Lurrus)
#10 Chrislampa: Gruul Midrange (RG, Obosh)
#11 Boin: Jund Midrange (BRG, Lurrus)
#12 Searzist: Jund Midrange (BRG, Lurrus)
#13 nahuel10: WURG Control (WURG, Yorion)
#14 Ouranos139: Amulet Titan (URG)
#15 Habby: Gruul Midrange (RG, Obosh)
#16 Karnesis93: Amulet Titan (UG)
#17 sydneydude: Boros Prowess (WR, Lurrus)
#18 Adam_Hen: Jund Midrange (BRG, Lurrus)
#19 SoulStrong: Grixis Control (UBR, Lurrus)
#20 selbstdenker: Amulet Titan (UG)
#21 otakkun: Eldrazi Tron (C)
#22 MadMaxErnst: Jund Midrange (BRG, Lurrus)
#23 TwistedWombat: Jund Midrange (BRG, Lurrus)
#24 Parrit: Hardened Scales (BG, Lurrus)
#25 hugo87: Gifts Storm (UR)
#26 _Batutinha_: Boros Prowess (WR, Lurrus)
#27 Gamestore_Linz: Boros Prowess (WR, Lurrus)
#28 NewHJ: Jund Midrange (BRG, Lurrus)
#29 Traft: Jund Midrange (BRG, Lurrus)
#30 a_p_s: Amulet Titan (URG)
#31 Patxi: Bant Control (WUG, Yorion)
#32 FallenKonflicz: Gruul Midrange (RG, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_05_10 : EventTest
    {
        [Test]
        public void Deck01_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",0),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Slatorade_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",1),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Jositoshekel_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",2),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TopherMarsh_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",3),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_GiovaniMF_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",4),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ilidioTheBrabo157SL_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_haubidtran_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",6),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_pmc22337_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",7),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_AJOCHUM_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",8),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Chrislampa_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",9),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_Boin_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",10),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Searzist_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",11),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_nahuel10_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",12),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck14_Ouranos139_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",13),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_Habby_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",14),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_Karnesis93_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",15),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck17_sydneydude_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",16),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_AdamHen_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",17),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_SoulStrong_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",18),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_selbstdenker_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",19),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",20),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck22_MadMaxErnst_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",21),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_TwistedWombat_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",22),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",23),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",24),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Batutinha_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",25),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_GamestoreLinz_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",26),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_NewHJ_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",27),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Traft_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",28),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_aps_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",29),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck31_Patxi_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",30),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_FallenKonflicz_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-10",31),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }


    }
}
