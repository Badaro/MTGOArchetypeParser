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
#01 TSPJendrek: Azorius Control (WU)
#02 Genxim: Ad Nauseam (WUB)
#03 KelMasterP: Gruul Midrange (RG)
#04 phol: Amulet Titan (UG)
#05 bigjc00: Amulet Titan (G)
#06 offline: Amulet Titan (UG)
#07 Bullwinkkle6705: Sultai Shadow (UBG)
#08 Darkwonyx: Amulet Titan (UG)
#09 Tiemuuu: Izzet Control (UR)
#10 cloudthresher77: Eldrazi Tron (C)
#11 Yooisa: Primeval Titan (UG)
#12 VTCLA: Amulet Titan (UG)
#13 bntrusty14: Mardu Midrange (WBR)
#14 angelsjeffrey: Mono Red Prowess (R)
#15 Bayris: Jund Midrange (BRG)
#16 HannoLee: Uroza (UG)
#17 madechai: Thopter Urza (UB)
#18 LordoftheLobsters: Simic Control (UG)
#19 AlabasterWolfie: Grinding Breach (UBR)
#20 Jenara19: Amulet Titan (UG)
#21 Xeroo: Mardu Shadow (WBR)
#22 Magic4everStoreShop6: Mono Red Prowess (R)
#23 __matsugan: Neobrand (UG)
#24 Twibs: Green Tron (G)
#25 Chefen: Eldrazi Tron (C)
#26 Fugate: Neobrand (UG)
#27 cavedan: Niv To Light (WUBRG)
#28 Chris_Concarnage: Eldrazi Tron (C)
#29 instantdeath929: Amulet Titan (UG)
#30 shadow_PT: Neobrand (UG)
#31 lsv: Thopter Urza (UB)
#32 Kazuga: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_challenge_2020_02_16 : EventTest
    {
        [Test]
        public void Deck01_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Genxim_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_KelMasterP_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_phol_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_bigjc00_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_offline_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_Bullwinkkle6705_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Darkwonyx_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_cloudthresher77_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_Yooisa_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck12_VTCLA_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_bntrusty14_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_angelsjeffrey_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Bayris_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_HannoLee_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck17_madechai_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck18_LordoftheLobsters_SimicControl_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_AlabasterWolfie_GrindingBreach_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Jenara19_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_Xeroo_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Magic4everStoreShop6_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Twibs_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck25_Chefen_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck26_Fugate_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",25),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck27_cavedan_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",26),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ChrisConcarnage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",27),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck29_instantdeath929_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",28),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_shadowPT_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",29),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck31_lsv_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",30),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck32_Kazuga_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-16",31),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
