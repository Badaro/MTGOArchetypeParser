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
#01 komattaman: GruulMidrange (RG)
#02 Simarisu: IzzetProwess (UR)
#03 BERNASTORRES: Bogles (WG, Lurrus)
#04 ImmanuelKantrolGod: BantControl (WUG)
#05 Somefellow: AmuletTitan (URG)
#06 Nickburch13: MarduProwess (WBR, Lurrus)
#07 fling5133: SultaiReclamation (UBG)
#08 JustBurn420: Slivers (WUBRG)
#09 lSoLlAKirA: BantControl (WUG)
#10 Rinko: EnduringIdeal (W)
#11 MissTrigger: Merfolk (WU, Lurrus)
#12 Hyeri0418: GolgariMidrange (BG)
#13 TheBlazingKFC_mtg: Neobrand (UG)
#14 katuo079595: TitanVial (WRG)
#15 Lillia: KGCAmuletTitan (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_02 : EventTest
    {
        [Test]
        public void Deck01_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",0),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Simarisu_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BERNASTORRES_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Somefellow_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",4),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_Nickburch13_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_fling5133_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck08_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck09_lSoLlAKirA_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Rinko_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",9),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck11_MissTrigger_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Hyeri0418_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_TheBlazingKFCmtg_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck14_katuo079595_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Lillia_KGCAmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-02",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }


    }
}