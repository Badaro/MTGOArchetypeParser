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
#01 DreamsOfAshiok: ETron (C)
#02 no_lyfe: Prowess (R)
#03 GR_DONKIN: AdNauseam (WUB)
#04 Theo_Jung: Jund (BRG)
#05 rastaf: IncineratorBurn (R)
#06 Gigy: Ponza (RG)
#07 Icteridae: ETron (C)
#08 wambocombo2020: Ponza (RG)
#09 ThekingFor1000years: Infect (WUG)
#10 BnR: GrixisShadow (UBR)
#11 MATTHEWFOULKES: SnoopGoblins (BR)
#12 1plus1equals3: Devoted (WG, Lurrus)
#13 MlckyB: Bogles (WG)
#14 Shazzam: IncineratorBurn (WR)
#15 Finalnub: Neobrand (UG)
#16 pokerswizard: KGCTron (G)
#17 dsnavely13: GiftsStorm (UR)
#18 NHA37: JeskaiProwess (WUR, Lurrus)
#19 BananOlaf: Ponza (RG)
#20 helvetti: Dredge (BRG)
#21 Edel: Jund (BRG)
#22 benjamin13: Ponza (RG)
#23 karatedom: RakdosProwess (WBR, Lurrus)
#24 Ambaro15: ReclamationTeachings (UBG)
#25 PeanutBrittle: IzzetProwess (UR)
#26 qbturtle15: Ponza (RG, Obosh)
#27 Sungjin: SnowShift (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_16 : EventTest
    {
        [Test]
        public void Deck01_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",0),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_nolyfe_Prowess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",1),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_GRDONKIN_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TheoJung_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck05_rastaf_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",4),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck06_Gigy_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",5),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Icteridae_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_wambocombo2020_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ThekingFor1000years_Infect_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck10_BnR_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck11_MATTHEWFOULKES_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck12_1plus1equals3_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Shazzam_Burn_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck15_Finalnub_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck16_pokerswizard_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",15),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck17_dsnavely13_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck18_NHA37_Prowess_JeskaiProwess_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Prowess),
                typeof(JeskaiProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_BananOlaf_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",18),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_helvetti_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Edel_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck22_benjamin13_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",21),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck23_karatedom_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Ambaro15_WildernessReclamation_ReclamationTeachings_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",23),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(WildernessReclamation),
                typeof(ReclamationTeachings),
                null
            );
        }

        [Test]
        public void Deck25_PeanutBrittle_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck26_qbturtle15_Ponza_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",25),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck27_Sungjin_SnowControl_SnowShift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SnowControl),
                typeof(SnowShift),
                null
            );
        }


    }
}
