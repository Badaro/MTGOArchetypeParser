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
#01 Lavaridge: Temur Control (URG)
#02 NuBlkAu: Izzet Prowess (UR)
#03 _LSN_: Burn (WR)
#04 A22en: Snoop Goblins (BR)
#05 ArchaeusDota: KGC Tron (G)
#06 JUJUBEAN__2004: Scapeshift (URG)
#07 Maratiam: E Tron (C)
#08 AstralPlane: Izzet Prowess (UR)
#09 mechrataal: Azorius Control (WU)
#10 SpiderSpace: Mono White Taxes (W)
#11 Lukas261997: Azorius Control (WU)
#12 Thrall90: Jund Midrange (BRG)
#13 Mateusf34: E Tron (C)
#14 Bullz0Eye: Dredge (BRG)
#15 andrw1232: Rakdos Prowess (BR, Lurrus)
#16 chasedaddydizzle: G Tron (G)
#17 Beenew: KGC Tron (G)
#18 TheJigIsAlwaysup: Gruul Midrange (RG)
#19 123Pwned: Izzet Prowess (UR)
#20 Voltzwagon: Gruul Midrange (RG)
#21 ponchonater55: Incinerator Burn (WR)
#22 staples87: E Tron (C)
#23 Mad-Ramon: Temur Control (URG)
#24 wambocombo2020: Mardu Prowess (WBR, Lurrus)
#25 timewalkinonsunshine: Taking Turns (URG)
#26 Alzik: Gruul Midrange (RG)
#27 ATXroy: Izzet Prowess (UR)
#28 HannoLee: KGC Tron (G)
#29 eclipse4343: Azorius Control (WU)
#30 aqualog: Izzet Prowess (UR)
#31 juzam_gin: Dredge (BRG)
#32 no_lyfe: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_champ_qual_2020_07_27 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_NuBlkAu_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_A22en_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ArchaeusDota_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",4),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_JUJUBEAN2004_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",5),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Maratiam_ETron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_AstralPlane_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_mechrataal_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SpiderSpace_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",9),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Lukas261997_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Bullz0Eye_Dredge_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_andrw1232_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_chasedaddydizzle_GTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",15),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Beenew_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",16),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_TheJigIsAlwaysup_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",17),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_123Pwned_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",19),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ponchonater55_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",20),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck22_staples87_ETron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",21),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck23_MadRamon_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",22),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_wambocombo2020_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",24),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Alzik_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",25),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_ATXroy_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck28_HannoLee_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",27),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck29_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_aqualog_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",29),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck31_juzamgin_Dredge_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck32_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",31),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
