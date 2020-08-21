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
#01 Lavaridge: TemurReclamation (URG)
#02 NuBlkAu: IzzetProwess (UR)
#03 _LSN_: Burn (WR)
#04 A22en: SnoopGoblins (BR)
#05 ArchaeusDota: KGCTron (G)
#06 JUJUBEAN__2004: Scapeshift (URG)
#07 Maratiam: ETron (C)
#08 AstralPlane: IzzetProwess (UR)
#09 mechrataal: AzoriusControl (WU)
#10 SpiderSpace: DeathAndTaxes (W)
#11 Lukas261997: AzoriusStoneblade (WU)
#12 Thrall90: Jund (BRG)
#13 Mateusf34: ETron (C)
#14 Bullz0Eye: Dredge (BRG)
#15 andrw1232: RakdosProwess (BR, Lurrus)
#16 chasedaddydizzle: GTron (G)
#17 Beenew: KGCTron (G)
#18 TheJigIsAlwaysup: Ponza (RG)
#19 123Pwned: IzzetProwess (UR)
#20 Voltzwagon: Ponza (RG)
#21 ponchonater55: IncineratorBurn (WR)
#22 staples87: ETron (C)
#23 Mad-Ramon: TemurReclamation (URG)
#24 wambocombo2020: RakdosProwess (WBR, Lurrus)
#25 timewalkinonsunshine: TakingTurns (URG)
#26 Alzik: Ponza (RG)
#27 ATXroy: IzzetProwess (UR)
#28 HannoLee: KGCTron (G)
#29 eclipse4343: Miracles (WU)
#30 aqualog: IzzetProwess (UR)
#31 juzam_gin: Dredge (WBRG)
#32 no_lyfe: Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_champ_qual_2020_07_27 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck02_NuBlkAu_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
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
        public void Deck04_A22en_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck05_ArchaeusDota_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",4),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
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
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_AstralPlane_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
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
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SpiderSpace_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",9),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Lukas261997_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck12_Thrall90_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
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
                typeof(ETron),
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
        public void Deck15_andrw1232_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
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
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Beenew_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",16),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck18_TheJigIsAlwaysup_Ponza_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",17),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_123Pwned_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck20_Voltzwagon_Ponza_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",19),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ponchonater55_Burn_IncineratorBurn_WR()
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
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck23_MadRamon_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",22),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck24_wambocombo2020_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
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
        public void Deck26_Alzik_Ponza_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",25),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck27_ATXroy_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck28_HannoLee_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",27),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck29_eclipse4343_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck30_aqualog_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",29),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck31_juzamgin_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck32_nolyfe_Prowess_R()
        {
            Test(
                GetDeck("modern-champ-qual-2020-07-27",31),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }


    }
}
