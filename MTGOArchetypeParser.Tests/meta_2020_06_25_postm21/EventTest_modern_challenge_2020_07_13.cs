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
#01 Lavaridge: SultaiSnow (UBG)
#02 sfitz: ThopterUrza (UBR)
#03 Larry11: Ponza (RG)
#04 Polikasoll: IncineratorBurn (R)
#05 ZYURYO: Jund (BRG)
#06 Lord_Beerus: Burn (WR)
#07 sff_mtg: KGCTron (G)
#08 Gigy: Ponza (RG)
#09 kiko: DeathAndTaxes (WR)
#10 TennTyou: BringToNiv (WUBRG)
#11 Smosh: ETron (C)
#12 WeareVenom: SnowControl (WUG)
#13 Nekonii: GolgariElves (BG)
#14 Mogged: Prowess (R)
#15 PizzaTurtle: Bogles (WG, Lurrus)
#16 unicornparadise: ETron (C)
#17 Fabrice_K: SnowReclamation (UBG, Yorion)
#18 MrRaeb: Uroza (UBG, Yorion)
#19 tuckbear: Burn (WR)
#20 Lopik6: AmuletTitan (URG)
#21 MikeEgan: Ponza (RG)
#22 PvtEnormous: Prowess (R)
#23 eXavie: SultaiSnow (UBG)
#24 Ryan100495: Dredge (WBRG)
#25 destinction: Jund (BRG)
#26 JUJUBEAN__2004: SnowControl (WUG)
#27 Tiemuuu: IzzetControl (UR)
#28 Venom1: ETron (C)
#29 otakkun: KGCTron (G)
#30 Jack_Kashtan: GiftsStorm (UR)
#31 Skrown: Dredge (WBRG)
#32 Erik157751: Jund (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_07_13 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",0),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_sfitz_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",1),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Larry11_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",2),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Polikasoll_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",3),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck05_ZYURYO_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",4),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",5),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",6),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck08_Gigy_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",7),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kiko_DeathAndTaxes_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",8),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TennTyou_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",9),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Smosh_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",10),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_WeareVenom_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",11),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nekonii_Elves_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",12),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck14_Mogged_Prowess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",13),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_PizzaTurtle_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",14),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_unicornparadise_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",15),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_FabriceK_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",16),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",17),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_tuckbear_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",18),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Lopik6_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",19),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_MikeEgan_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",20),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_PvtEnormous_Prowess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",21),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_eXavie_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",22),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Ryan100495_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",23),
                new PostM21(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck25_destinction_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",24),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_JUJUBEAN2004_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",25),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",26),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Venom1_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",27),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck29_otakkun_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",28),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck30_JackKashtan_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",29),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Skrown_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",30),
                new PostM21(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Erik157751_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-13",31),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
