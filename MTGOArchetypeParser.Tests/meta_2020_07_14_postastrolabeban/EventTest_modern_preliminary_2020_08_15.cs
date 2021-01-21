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
#01 Rooney56: Azorius Control (WU)
#02 CavalloGoloso: Izzet Control (UR)
#03 Costola91: Grixis Shadow (UBR)
#04 BasedCloy: Eldrazi Tron (C)
#05 Wuhsa: Niv To Light (WUBRG, Yorion)
#06 lilianaofthevess: Izzet Prowess (UR)
#07 CReactor: Green Tron (G)
#08 Imaeda: Izzet Prowess (UR)
#09 Hampuse1: Dice Factory Tron (C)
#10 BSK_hercules: Temur Reclamation (URG)
#11 Zar0s: Amulet Titan (UG)
#12 otakkun: Green Tron (G)
#13 ht991122: Temur Reclamation (URG)
#14 kbzx: Izzet Prowess (UR)
#15 komattaman: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_15 : EventTest
    {
        [Test]
        public void Deck01_Rooney56_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_CavalloGoloso_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Costola91_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck04_BasedCloy_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",3),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_lilianaofthevess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck07_CReactor_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",6),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck08_Imaeda_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck09_Hampuse1_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",8),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck10_BSKhercules_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Zar0s_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",11),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck13_ht991122_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",12),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kbzx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck15_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-15",14),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
