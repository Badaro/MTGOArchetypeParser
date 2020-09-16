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
#01 juzam_gin: Dredge (WBRG)
#02 NosonosaN: JundProwess (BRG, Lurrus)
#03 McWinSauce: BantControl (WUG)
#04 iL_Tedesco: JundMidrange (BRG)
#05 Lavaridge: TemurReclamation (URG)
#06 Tsubasa_Cat: Burn (WR)
#07 MrSeri: HeliodCombo (WG)
#08 AuDollarydoo: Crabvine (UBG)
#09 HouseOfManaMTG: RakdosProwess (BR, Lurrus)
#10 therock988: RakdosProwess (BR, Lurrus)
#11 ZYURYO: GruulMidrange (RG)
#12 DamonXWind: IzzetProwess (UR)
#13 kthanakit26: IzzetProwess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_26 : EventTest
    {
        [Test]
        public void Deck01_juzamgin_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_NosonosaN_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",1),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_iLTedesco_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Lavaridge_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",4),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TsubasaCat_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MrSeri_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_AuDollarydoo_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck09_HouseOfManaMTG_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_therock988_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_ZYURYO_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",10),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_DamonXWind_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-26",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
