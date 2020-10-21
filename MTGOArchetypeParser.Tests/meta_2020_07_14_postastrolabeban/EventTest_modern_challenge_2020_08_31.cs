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
#01 _Stream: IzzetProwess (UR)
#02 Fayrawks: SultaiReclamation (UBG)
#03 HotBread: IzzetProwess (UR)
#04 billsive: BantReclamation (WUG)
#05 BERNASTORRES: KGCTron (G)
#06 vixyp: BantMidrange (WUG)
#07 Oscar_Franco: JundMidrange (BRG)
#08 cftsoc3: BantBlink (WUG)
#09 nahuel10: BantControl (WUG)
#10 trader08111: JundMidrange (BRG)
#11 Asoen: RakdosMidrange (BR)
#12 Bullz0Eye: ETron (C)
#13 drVendigo: GruulMidrange (RG)
#14 doughhater: ValakutField (URG)
#15 evange_: RakdosProwess (BR, Lurrus)
#16 GodOfSlaughter: BringToNiv (WUBRG, Yorion)
#17 Turn1Vial: Slivers (WUBRG)
#18 cws: GiftsStorm (UR)
#19 SourceOdin: PrimevalTitan (WRG)
#20 Zxion631: BorosSunforger (WBR)
#21 albert62: JundMidrange (BRG)
#22 Vallejo97: IzzetProwess (UR)
#23 CReactor: RakdosProwess (BR, Lurrus)
#24 runn3runn3r: OboshAggro (R, Obosh)
#25 AstralPlane: IzzetProwess (UR)
#26 Tatsumaki_: KGCTron (G)
#27 Kurusu: KikiChord (WRG, Yorion)
#28 Filyoni: Dredge (BRG)
#29 DaniMRebel: Humans (WUBRG)
#30 B1gDan: HeliodCombo (WG)
#31 krusader666: TitanShift (RG)
#32 zMunkeyXz: Mill (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_31 : EventTest
    {
        [Test]
        public void Deck01_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Fayrawks_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck03_HotBread_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_billsive_BantReclamation_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck05_BERNASTORRES_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",4),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck06_vixyp_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_OscarFranco_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck09_nahuel10_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_trader08111_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Bullz0Eye_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",11),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_drVendigo_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_doughhater_ValakutField_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",13),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(ValakutField),
                null,
                null
            );
        }

        [Test]
        public void Deck15_evange_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_GodOfSlaughter_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_Turn1Vial_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck18_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SourceOdin_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Zxion631_BorosSunforger_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(BorosSunforger),
                null,
                null
            );
        }

        [Test]
        public void Deck21_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Vallejo97_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_CReactor_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_runn3runn3r_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",23),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck25_AstralPlane_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Tatsumaki_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",25),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck27_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_Filyoni_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",27),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck29_DaniMRebel_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck30_B1gDan_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck31_krusader666_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",30),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck32_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-31",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }


    }
}
