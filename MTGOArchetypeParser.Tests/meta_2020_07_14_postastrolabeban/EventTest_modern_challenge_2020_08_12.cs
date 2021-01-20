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
#01 Gerschi: Mardu Prowess (WBR, Lurrus)
#02 TSPJendrek: Sultai Control (UBG)
#03 Yooisa: Infect (UG)
#04 HouseOfManaMTG: Green Tron (G)
#05 dsissowin: Izzet Prowess (UR)
#06 __matsugan: Neobrand (UG)
#07 sakuragi21722749: Eldrazi Tron (C)
#08 MrRaeb: Gruul Midrange (RG)
#09 Predicted: Yawgmoth (WBG)
#10 gazmon48: Green Tron (G)
#11 Mateusf34: Eldrazi Tron (C)
#12 Maox: Izzet Prowess (UR)
#13 Fabrice_K: Eldrazi Tron (C)
#14 kefka27: Eldrazi Tron (C)
#15 albert62: Jund Midrange (BRG)
#16 MissTrigger: Burn (R)
#17 jvidarte: Burn (WR)
#18 nahuel10: Bant Control (WUG)
#19 Tiemuuu: Izzet Control (UR)
#20 harukispecial: Sultai Control (UBG)
#21 _Falcon_: Izzet Prowess (UR)
#22 Gabriele2020: Humans (WUBRG)
#23 Ryan100495: Dredge (WBRG)
#24 kthanakit26: Izzet Prowess (UR)
#25 thekingofnone: Scapeshift (URG)
#26 belanna999: Eldrazi Tron (C)
#27 TheSouthDakota: Jund Shadow (BRG)
#28 HIziri88: Gruul Midrange (RG)
#29 mariogomes097: Grixis Shadow (UBR)
#30 kaikalbuquerque: Jund Midrange (BRG)
#31 unicornparadise: Rakdos Prowess (BR, Lurrus)
#32 Raptor_Nachos: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_12 : EventTest
    {
        [Test]
        public void Deck01_Gerschi_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Yooisa_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck04_HouseOfManaMTG_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",3),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_dsissowin_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck06_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck07_sakuragi21722749_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_MrRaeb_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck10_gazmon48_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",9),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck11_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",10),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_Maox_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck13_FabriceK_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_kefka27_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",13),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_MissTrigger_Burn_R()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",15),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck17_jvidarte_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck18_nahuel10_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_harukispecial_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck22_Gabriele2020_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Ryan100495_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck24_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",23),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck25_thekingofnone_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",24),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck26_belanna999_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",25),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_TheSouthDakota_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",26),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck28_HIziri88_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",27),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck30_kaikalbuquerque_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",29),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_unicornparadise_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_RaptorNachos_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12",31),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }


    }
}
