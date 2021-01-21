using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 MissTrigger: Merfolk (WU, Lurrus)
#02 kthanakit26: Burn (WR)
#03 StrawberryPi: Burn (WR)
#04 yuseimax: Soulflayer (BRG)
#05 Kurusu: Kiki Chord (WRG, Yorion)
#06 Laplasjan: Devoted (WG, Lurrus)
#07 _Batutinha_: Jund Shadow (BRG)
#08 SSkarm: Scapeshift (URG)
#09 Asmodean1990: Jund Midrange (BRG)
#10 Mogged: Izzet Prowess (UR)
#11 Auron12: Izzet Prowess (UR)
#12 didoguidotti1: Reclamation (URG)
#13 Vashezzo: Reclamation (URG)
#14 MicAncona: Gruul Midrange (RG)
#15 Granham: Green Tron (G)
#16 siomomi: Eldrazi Tron (C)
#17 Lord_Beerus: Gruul Midrange (RG)
#18 Gerschi: Mardu Prowess (WBR, Lurrus)
#19 Oscar_Franco: Jund Midrange (BRG)
#20 ht991122: Izzet Prowess (UR)
#21 CrusherBotBG: Hammer Time (W)
#22 SebastianStueckl: Gruul Midrange (RG)
#23 Venom1: Eldrazi Tron (C)
#24 alexthegreat38: Izzet Prowess (UR)
#25 Mcleskey: Burn (WR)
#26 BERNASTORRES: Izzet Prowess (UR)
#27 drVendigo: Gruul Midrange (RG)
#28 MrRaeb: Gruul Midrange (RG)
#29 Bullz0Eye: Bant Control (WUG)
#30 Filyoni: Devoted (WG, Lurrus)
#31 ejcos531: Azorius Control (WU)
#32 NuclearRabbit: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_10 : EventTest
    {
        [Test]
        public void Deck01_MissTrigger_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",0),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "Merfolk",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",1),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck03_StrawberryPi_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",2),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck04_yuseimax_Soulflayer_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",3),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Soulflayer",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",4),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",5),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Batutinha_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",6),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_SSkarm_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",7),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Asmodean1990_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",8),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Mogged_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",9),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_Auron12_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",10),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_didoguidotti1_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",11),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Vashezzo_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",12),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck14_MicAncona_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",13),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Granham_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",14),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck16_siomomi_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",15),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_LordBeerus_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",16),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Gerschi_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",17),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_OscarFranco_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",18),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_ht991122_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",19),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck21_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",20),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "HammerTime",
                null,
                null
            );
        }

        [Test]
        public void Deck22_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",21),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Venom1_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",22),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck24_alexthegreat38_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",23),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck25_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",24),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck26_BERNASTORRES_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",25),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck27_drVendigo_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",26),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck28_MrRaeb_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",27),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Bullz0Eye_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",28),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Filyoni_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",29),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_ejcos531_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",30),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_NuclearRabbit_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",31),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}
