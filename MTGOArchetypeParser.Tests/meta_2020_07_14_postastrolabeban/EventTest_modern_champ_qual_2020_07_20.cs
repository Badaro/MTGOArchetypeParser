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
#01 TheTunnelingCat: E Tron (C)
#02 HeyPharaoh: Azorius Control (WU)
#03 iuriper: Bant Control (WUG)
#04 __BMJ__: Sultai Shadow (UBG)
#05 rastaf: Izzet Prowess (UR)
#06 AnneLivleysD3ath: KGC Amulet Titan (UG)
#07 LalauWBA: Gruul Prowess (RG, Jegantha)
#08 Lavaridge: Temur Control (URG)
#09 kogamo: Sultai Control (UBG)
#10 dani_chad: Jund Midrange (BRG)
#11 MinCash: Ad Nauseam (WUB)
#12 BERNASTORRES: Snoop Goblins (BR)
#13 Ryan_39: Gruul Midrange (RG)
#14 jmeyer2030: Izzet Restore Balance (UR)
#15 3HaLeX1: E Tron (C)
#16 LeoFa: Scapeshift (URG)
#17 musasabi: Jund Midrange (BRG)
#18 ack_s: Gruul Midrange (RG)
#19 alicoco: Ad Nauseam (WUB)
#20 zachattack23: Bant Control (WUG)
#21 quinniac: Gruul Midrange (RG)
#22 _Tia93_: Izzet Prowess (UR)
#23 alnash: Grixis Shadow (UBR)
#24 HannoLee: KGC Tron (G)
#25 dormitian: Humans (WUBRG)
#26 Magicofplayer1: Dredge (BRG)
#27 _Batutinha_: Izzet Prowess (UR)
#28 Naisirc: Hardened Scales (G)
#29 Marxelo: Tokens (W)
#30 Patxi: Azorius Control (WU)
#31 Leviathan102: KGC Amulet Titan (UG)
#32 Boland: Grixis Shadow (UBR)
*/

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
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_HeyPharaoh_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_iuriper_BantControl_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_BMJ_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_rastaf_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_AnneLivleysD3ath_KGCAmuletTitan_UG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_LalauWBA_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",6),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_Lavaridge_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",7),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kogamo_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_danichad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
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
        public void Deck12_BERNASTORRES_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Ryan39_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_jmeyer2030_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
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
                typeof(Tron),
typeof(EldraziTron),
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
        public void Deck17_musasabi_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_acks_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",17),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
        public void Deck20_zachattack23_BantControl_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_quinniac_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",20),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Tia93_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_alnash_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck24_HannoLee_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",23),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
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
        public void Deck26_Magicofplayer1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Batutinha_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Leviathan102_KGCAmuletTitan_UG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",30),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }


    }
}
