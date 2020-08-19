using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_10 : EventTest
    {
        [Test]
        public void Deck01_MissTrigger_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_StrawberryPi_Burn_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck04_yuseimax_Soulflayer_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Soulflayer),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Batutinha_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck08_SSkarm_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",7),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Asmodean1990_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck10_Mogged_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck11_Auron12_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck12_didoguidotti1_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",11),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck13_Vashezzo_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",12),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck14_MicAncona_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",13),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Granham_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",14),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck16_siomomi_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",15),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_LordBeerus_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",16),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Gerschi_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_OscarFranco_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",18),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck20_ht991122_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck21_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",20),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck22_SebastianStueckl_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",21),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Venom1_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",22),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_alexthegreat38_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",23),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck25_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck26_BERNASTORRES_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck27_drVendigo_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",26),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_MrRaeb_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",27),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Bullz0Eye_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Filyoni_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_ejcos531_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck32_NuclearRabbit_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-10",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }


    }
}
