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
#01 gazmon48: KGC Tron (G)
#02 Do0mSwitch: Bant Control (WUG)
#03 aplapp: Rakdos Prowess (BR, Lurrus)
#04 Pennywisse: Grixis Shadow (UBR)
#05 exoticherman: Rakdos Prowess (BR, Lurrus)
#06 flatnose: Merfolk (UG)
#07 Rav104: Rakdos Prowess (BR, Lurrus)
#08 edward40hands: Golgari Midrange (BG)
#09 sinforlife54: Mono White Eldrazi Taxes (W)
#10 otakkun: KGC Tron (G)
#11 uaedoliB: Humans (WUBRG)
#12 nick4567: Temur Reclamation (URG)
#13 Laplasjan: Devoted (WG, Lurrus)
#14 Sodeq: Ad Nauseam (WUB)
#15 asnook: Jund Midrange (BRG)
#16 cws: Gifts Storm (UR)
#17 kanister: Bant Control (WUG)
#18 Delthar: Mill (UB)
#19 Toastxp: Bant Control (WUG)
#20 Gigy: Gruul Midrange (RG)
#21 Luzur: Sultai Control (UBG)
#22 spellvine: Izzet Prowess (UR)
#23 HouseOfManaMTG: Reclaimer Titan (WRG)
#24 Yanti: Jund Midrange (BRG)
#25 Storytime: Kinnan Devoted (WUG)
#26 Xuxa: Dredge (BRG)
#27 NorrathDecay: Burn (WR)
#28 ConnorM426: Temur Reclamation (URG)
#29 musasabi: KGC Amulet Titan (UBRG)
#30 NHA37: E Tron (C)
#31 BSK_hercules: Temur Reclamation (URG)
#32 kthanakit26: Burn (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_16 : EventTest
    {
        [Test]
        public void Deck01_gazmon48_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",0),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_aplapp_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Pennywisse_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_flatnose_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Rav104_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_edward40hands_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_sinforlife54_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",8),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck10_otakkun_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",9),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck11_uaedoliB_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_nick4567_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",11),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_asnook_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck17_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Delthar_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Toastxp_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",19),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Luzur_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_spellvine_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_HouseOfManaMTG_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck24_Yanti_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",23),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Storytime_KinnanDevoted_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(KinnanDevoted),
                null
            );
        }

        [Test]
        public void Deck26_Xuxa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ConnorM426_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",27),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_musasabi_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_NHA37_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",29),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck31_BSKhercules_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",30),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }


    }
}
