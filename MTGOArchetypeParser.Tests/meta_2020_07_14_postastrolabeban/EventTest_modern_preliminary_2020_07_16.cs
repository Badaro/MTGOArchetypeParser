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
#01 DreamsOfAshiok: Eldrazi Tron (C)
#02 no_lyfe: Mono Red Prowess (R)
#03 GR_DONKIN: Ad Nauseam (WUB)
#04 Theo_Jung: Jund Midrange (BRG)
#05 rastaf: Burn (R)
#06 Gigy: Gruul Midrange (RG)
#07 Icteridae: Eldrazi Tron (C)
#08 wambocombo2020: Gruul Midrange (RG)
#09 ThekingFor1000years: Infect (WUG)
#10 BnR: Grixis Shadow (UBR)
#11 MATTHEWFOULKES: Goblins (BR)
#12 1plus1equals3: Devoted (WG, Lurrus)
#13 MlckyB: Bogles (WG)
#14 Shazzam: Burn (WR)
#15 Finalnub: Neobrand (WUG)
#16 pokerswizard: Green Tron (G)
#17 dsnavely13: Gifts Storm (UR)
#18 NHA37: Jeskai Prowess (WUR, Lurrus)
#19 BananOlaf: Gruul Midrange (RG)
#20 helvetti: Dredge (BRG)
#21 Edel: Jund Midrange (BRG)
#22 benjamin13: Gruul Midrange (RG)
#23 karatedom: Mardu Prowess (WBR, Lurrus)
#24 Ambaro15: Reclamation (UBG)
#25 PeanutBrittle: Izzet Prowess (UR)
#26 qbturtle15: Gruul Midrange (RG, Obosh)
#27 Sungjin: Scapeshift (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_16 : EventTest
    {
        [Test]
        public void Deck01_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",0),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",1),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_GRDONKIN_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",2),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck04_TheoJung_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",3),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_rastaf_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",4),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck06_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",5),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",6),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_wambocombo2020_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",7),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_ThekingFor1000years_Infect_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",8),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck10_BnR_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",9),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck11_MATTHEWFOULKES_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",10),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck12_1plus1equals3_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",11),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",12),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Shazzam_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",13),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck15_Finalnub_Neobrand_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",14),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck16_pokerswizard_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",15),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck17_dsnavely13_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",16),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck18_NHA37_JeskaiProwess_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",17),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_BananOlaf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",18),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_helvetti_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",19),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Edel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",20),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_benjamin13_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",21),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_karatedom_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",22),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Ambaro15_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",23),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck25_PeanutBrittle_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",24),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck26_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",25),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck27_Sungjin_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-16",26),
                "PostAstrolabeBan",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                null
            );
        }


    }
}
