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
#01 Ganksyou: Azorius Control (WU)
#02 Rhianne: Dredge (WBRG)
#03 tylerjjobrien: Niv To Light (WUBRG, Yorion)
#04 Zar0s: Scapeshift (URG)
#05 RodeoJones: Saheeli Combo (WURG)
#06 Thrall90: Jund Midrange (BRG)
#07 Redgy819: Eldrazi Tron (C)
#08 katuo079595: Scapeshift (URG)
#09 ArchaeusDota: Green Tron (WG)
#10 mylast: Izzet Prowess (UR)
#11 rastaf: Izzet Prowess (UR)
#12 Znapcaster: Bant Control (WUG)
#13 spellvine: Izzet Prowess (UR)
#14 Xwhale: Goblins (BR)
#15 Wizard_2002: Humans (WUBRG)
#16 komattaman: Gruul Midrange (RG)
#17 McWinSauce: Reclamation (URG)
#18 jhollan42: Bant Control (WUG)
#19 SakeIzumo: Izzet Prowess (UR)
#20 tanisong1221: Azorius Control (WU)
#21 Lavaridge: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_28 : EventTest
    {
        [Test]
        public void Deck01_Ganksyou_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",0),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Rhianne_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",1),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck03_tylerjjobrien_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",2),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Zar0s_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",3),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck05_RodeoJones_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",4),
                "PostAstrolabeBan",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",5),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Redgy819_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",6),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_katuo079595_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",7),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck09_ArchaeusDota_GreenTron_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",8),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck10_mylast_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",9),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_rastaf_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",10),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_Znapcaster_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",11),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_spellvine_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",12),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck14_Xwhale_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",13),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Wizard2002_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",14),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck16_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",15),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_McWinSauce_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",16),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck18_jhollan42_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",17),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck19_SakeIzumo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",18),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck20_tanisong1221_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",19),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Lavaridge_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-28",20),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
