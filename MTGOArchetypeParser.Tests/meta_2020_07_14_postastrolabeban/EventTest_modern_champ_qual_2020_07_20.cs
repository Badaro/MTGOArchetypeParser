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
#01 TheTunnelingCat: Eldrazi Tron (C)
#02 HeyPharaoh: Azorius Control (WU)
#03 iuriper: Bant Control (WUG)
#04 __BMJ__: UBRG Shadow (UBRG)
#05 rastaf: Izzet Prowess (UR)
#06 AnneLivleysD3ath: Amulet Titan (UG)
#07 LalauWBA: Gruul Prowess (RG, Jegantha)
#08 Lavaridge: Reclamation (URG)
#09 kogamo: Reclamation (UBG)
#10 dani_chad: Jund Midrange (BRG)
#11 MinCash: Ad Nauseam (WUB)
#12 BERNASTORRES: Goblins (BR)
#13 Ryan_39: Gruul Midrange (RG)
#14 jmeyer2030: Electro Balance (URG)
#15 3HaLeX1: Eldrazi Tron (C)
#16 LeoFa: Scapeshift (URG)
#17 musasabi: Jund Midrange (BRG)
#18 ack_s: Gruul Midrange (RG)
#19 alicoco: Ad Nauseam (WUB)
#20 zachattack23: Bant Control (WUG)
#21 quinniac: Gruul Midrange (RG)
#22 _Tia93_: Izzet Prowess (UR)
#23 alnash: Grixis Shadow (UBR)
#24 HannoLee: Green Tron (G)
#25 dormitian: Humans (WUBRG)
#26 Magicofplayer1: Dredge (WBRG)
#27 _Batutinha_: Izzet Prowess (UR)
#28 Naisirc: Hardened Scales (G)
#29 Marxelo: Tokens (W)
#30 Patxi: Azorius Control (WU)
#31 Leviathan102: Amulet Titan (UG)
#32 Boland: Grixis Shadow (UBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_champ_qual_2020_07_20 : EventTest
    {
        [Test]
        public void Deck01_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",0),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_HeyPharaoh_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",1),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_iuriper_BantControl_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",2),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_BMJ_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",3),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck05_rastaf_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",4),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_AnneLivleysD3ath_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",5),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_LalauWBA_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",6),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_Lavaridge_Reclamation_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",7),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck09_kogamo_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",8),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck10_danichad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",9),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_MinCash_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",10),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_BERNASTORRES_Goblins_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",11),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Ryan39_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",12),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_jmeyer2030_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",13),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck15_3HaLeX1_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",14),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck16_LeoFa_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",15),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck17_musasabi_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",16),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck18_acks_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",17),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_alicoco_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",18),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck20_zachattack23_BantControl_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",19),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_quinniac_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",20),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Tia93_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",21),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_alnash_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",22),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck24_HannoLee_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",23),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck25_dormitian_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",24),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Magicofplayer1_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",25),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Batutinha_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",26),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_Naisirc_HardenedScales_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",27),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Marxelo_Tokens_W()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",28),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "Tokens",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Patxi_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",29),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Leviathan102_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",30),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck32_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-20",31),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }


    }
}
