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
#01 Lavaridge: Reclamation (URG)
#02 NuBlkAu: Izzet Prowess (UR)
#03 _LSN_: Burn (WR)
#04 A22en: Goblins (BR)
#05 ArchaeusDota: Green Tron (G)
#06 JUJUBEAN__2004: Scapeshift (URG)
#07 Maratiam: Eldrazi Tron (C)
#08 AstralPlane: Izzet Prowess (UR)
#09 mechrataal: Azorius Control (WU)
#10 SpiderSpace: Mono White Taxes (W)
#11 Lukas261997: Azorius Control (WU)
#12 Thrall90: Jund Midrange (BRG)
#13 Mateusf34: Eldrazi Tron (C)
#14 Bullz0Eye: Dredge (BRG)
#15 andrw1232: Rakdos Prowess (BR, Lurrus)
#16 chasedaddydizzle: Green Tron (G)
#17 Beenew: Green Tron (G)
#18 TheJigIsAlwaysup: Gruul Midrange (RG)
#19 123Pwned: Izzet Prowess (UR)
#20 Voltzwagon: Gruul Midrange (RG)
#21 ponchonater55: Burn (WR)
#22 staples87: Eldrazi Tron (C)
#23 Mad-Ramon: Reclamation (URG)
#24 wambocombo2020: Mardu Prowess (WBR, Lurrus)
#25 timewalkinonsunshine: Taking Turns (URG)
#26 Alzik: Gruul Midrange (RG)
#27 ATXroy: Izzet Prowess (UR)
#28 HannoLee: Green Tron (G)
#29 eclipse4343: Azorius Control (WU)
#30 aqualog: Izzet Prowess (UR)
#31 juzam_gin: Dredge (WBRG)
#32 no_lyfe: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_champ_qual_2020_07_27 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_Reclamation_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",0),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck02_NuBlkAu_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",1),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",2),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck04_A22en_Goblins_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",3),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck05_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",4),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck06_JUJUBEAN2004_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",5),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Maratiam_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",6),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_AstralPlane_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",7),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_mechrataal_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",8),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_SpiderSpace_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",9),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Lukas261997_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",10),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",11),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",12),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_Bullz0Eye_Dredge_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",13),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck15_andrw1232_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",14),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_chasedaddydizzle_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",15),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck17_Beenew_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",16),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck18_TheJigIsAlwaysup_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",17),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_123Pwned_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",18),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck20_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",19),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_ponchonater55_Burn_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",20),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck22_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",21),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck23_MadRamon_Reclamation_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",22),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck24_wambocombo2020_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",23),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",24),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "TakingTurns",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Alzik_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",25),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck27_ATXroy_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",26),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_HannoLee_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",27),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck29_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",28),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_aqualog_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",29),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck31_juzamgin_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",30),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck32_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",31),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
