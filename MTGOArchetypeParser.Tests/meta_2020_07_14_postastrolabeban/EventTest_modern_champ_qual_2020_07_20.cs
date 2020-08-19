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
    public class EventTest_modern_champ_qual_2020_07_20 : EventTest
    {
        [Test]
        public void Deck01_TheTunnelingCat_ETron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",0),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_HeyPharaoh_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck03_iuriper_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck04_BMJ_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck05_rastaf_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck06_AnneLivleysD3ath_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_LalauWBA_Prowess_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",6),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Prowess),
                typeof(GruulProwess),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_Lavaridge_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",7),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck09_kogamo_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck10_danichad_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck11_MinCash_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_BERNASTORRES_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck13_Ryan39_Ponza_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck14_jmeyer2030_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",13),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck15_3HaLeX1_ETron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",14),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_LeoFa_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",15),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck17_musasabi_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck18_acks_Ponza_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",17),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_alicoco_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck20_zachattack23_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_quinniac_Ponza_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",20),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Tia93_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck23_alnash_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck24_HannoLee_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",23),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck25_dormitian_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Magicofplayer1_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Batutinha_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck28_Naisirc_HardenedScales_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",27),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Marxelo_Tokens_W()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",28),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Patxi_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Leviathan102_PrimevalTitan_KGCAmuletTitan_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",30),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_Boland_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }


    }
}
