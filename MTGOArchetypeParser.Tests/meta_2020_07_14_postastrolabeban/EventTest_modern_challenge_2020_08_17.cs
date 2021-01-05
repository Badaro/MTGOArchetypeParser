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
#01 kbzx: Izzet Prowess (UR)
#02 Phill_Hellmuth: Grixis Shadow (UBR)
#03 TSPJendrek: Sultai Control (UBG)
#04 TwistedWombat: Temur Control (URG)
#05 Fluorspar: Humans (WUBRG)
#06 Snusnumrick: Eldrazi Tron (C)
#07 Trellon: Blue Tron (U)
#08 CHILLEDADED: Burn (WR)
#09 Predicted: Yawgmoth (BG)
#10 TennTyou: Niv To Light (WUBRG)
#11 Cy_4nhur: Goblins (BR)
#12 buddha715: Burn (WR, Lurrus)
#13 staffmat1992: Gruul Midrange (RG)
#14 Costola91: Grixis Shadow (UBR)
#15 nahuel10: Gruul Midrange (RG)
#16 jvidarte: Burn (WR, Lurrus)
#17 fried-liver-attack: Eldrazi Tron (C)
#18 Gigy: Gruul Midrange (RG)
#19 musasabi: Amulet Titan (UG)
#20 _Logic_: Ascendancy Combo (WURG)
#21 __matsugan: Neobrand (UG)
#22 PhantasmalBear: Azorius Midrange (WU)
#23 drVendigo: Gruul Midrange (RG)
#24 junghans: Heliod Combo (WG)
#25 kaikalbuquerque: Bogles (WG)
#26 Bullz0Eye: Green Tron (G)
#27 calheiros: Burn (WR)
#28 Xemnon1: Rakdos Prowess (BR, Lurrus)
#29 Filyoni: Devoted (WG, Lurrus)
#30 asnook: Jund Midrange (BRG)
#31 bigjc00: Amulet Titan (RG)
#32 MCScards: Rakdos Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_17 : EventTest
    {
        [Test]
        public void Deck01_kbzx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_PhillHellmuth_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck03_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TwistedWombat_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",3),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Snusnumrick_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",5),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",6),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck08_CHILLEDADED_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Predicted_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Cy4nhur_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck12_buddha715_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_staffmat1992_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Costola91_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_nahuel10_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",14),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_friedliverattack_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",16),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",17),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_musasabi_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck20_Logic_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck21_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck22_PhantasmalBear_AzoriusMidrange_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_drVendigo_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",22),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck25_kaikalbuquerque_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Bullz0Eye_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",25),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck27_calheiros_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Xemnon1_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",27),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Filyoni_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_asnook_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",29),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_bigjc00_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",30),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_MCScards_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",31),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
