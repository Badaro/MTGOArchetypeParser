using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 kbzx: Izzet Prowess (UR)
#02 Phill_Hellmuth: Grixis Shadow (UBR)
#03 TSPJendrek: Sultai Control (UBG)
#04 TwistedWombat: Reclamation (URG)
#05 Fluorspar: Humans (WUBRG)
#06 Snusnumrick: Eldrazi Tron (C)
#07 Trellon: Blue Tron (U)
#08 CHILLEDADED: Burn (WR)
#09 Predicted: Yawgmoth (WBG)
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
#31 bigjc00: Amulet Titan (URG)
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
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_PhillHellmuth_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",1),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck03_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",2),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_TwistedWombat_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",3),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",4),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Snusnumrick_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",5),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",6),
                "PostAstrolabeBan",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck08_CHILLEDADED_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",7),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",8),
                "PostAstrolabeBan",
                ArchetypeColor.WBG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck10_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",9),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Cy4nhur_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",10),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck12_buddha715_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",11),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_staffmat1992_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",12),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Costola91_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",13),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck15_nahuel10_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",14),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",15),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_friedliverattack_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",16),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",17),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_musasabi_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",18),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck20_Logic_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",19),
                "PostAstrolabeBan",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck21_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",20),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck22_PhantasmalBear_AzoriusMidrange_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",21),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_drVendigo_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",22),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck24_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",23),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck25_kaikalbuquerque_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",24),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Bullz0Eye_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",25),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck27_calheiros_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",26),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck28_Xemnon1_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",27),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Filyoni_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",28),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_asnook_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",29),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_bigjc00_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",30),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck32_MCScards_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-17",31),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
