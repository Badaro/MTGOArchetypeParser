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
#01 Graciasportanto: Uroza (URG)
#02 PhReSHTinGZ: Amulet Titan (UG)
#03 pbarrrgh: Simic Control (UG)
#04 Trellon: Blue Tron (U)
#05 Magicofplayer1: Dredge (BRG)
#06 Whitecell: Neobrand (UG)
#07 PieGonti: Humans (WUBRG)
#08 __matsugan: Neobrand (UG)
#09 moyashi0904: Bant Control (WUG)
#10 Sonso JF: Heliod Combo (WUG)
#11 stantuffodado88: Mono Red Prowess (R)
#12 ConnorM426: Niv To Light (WUBRG)
#13 GGoggles: Humans (WUBRG)
#14 lighdar: Eldrazi Tron (C)
#15 WhiteFaces: Dredge (BRG)
#16 ilidioTheBrabo157SL: Burn (WR)
#17 Lord_Beerus: Burn (WR)
#18 katoriarch123: Bant Control (WUG)
#19 122pablo: Ascendancy Combo (WURG)
#20 Shorak123: Temur Control (URG)
#21 pizzaslinger: Gruul Midrange (RG)
#22 Butakov: Jund Midrange (BRG)
#23 Bayesta_93: Gruul Midrange (RG)
#24 a_p_s: Gruul Midrange (RG)
#25 Gernardi: Gruul Midrange (RG)
#26 hoveydw: Bant Midrange (WUG)
#27 KelMasterP: Gruul Midrange (RG)
#28 Edel: Jund Midrange (BRG)
#29 bresett123: Gruul Midrange (RG)
#30 exoticherman: Infect (UG)
#31 Fluorspar: Humans (WUBRG)
#32 Misplacedginger: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_showcase_challenge_2020_04_12 : EventTest
    {
        [Test]
        public void Deck01_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",0),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_PhReSHTinGZ_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",1),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_pbarrrgh_SimicControl_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",2),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",3),
                new PostOuatBan(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck05_Magicofplayer1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",4),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Whitecell_Neobrand_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",5),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck07_PieGonti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",6),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",7),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_moyashi0904_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",8),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SonsoJF_HeliodCombo_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",9),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_stantuffodado88_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",10),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ConnorM426_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",11),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck13_GGoggles_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",12),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_lighdar_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",13),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_WhiteFaces_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",14),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ilidioTheBrabo157SL_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",15),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck17_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",16),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",17),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",18),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Shorak123_TemurControl_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",19),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_pizzaslinger_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",20),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Butakov_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",21),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Bayesta93_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",22),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_aps_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",23),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Gernardi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",24),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_hoveydw_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",25),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_KelMasterP_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",26),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Edel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",27),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_bresett123_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",28),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",29),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",30),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-04-12",31),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
