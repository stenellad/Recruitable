using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;

namespace Recruitable
{
    public class Recruitable : DefaultPrisonerRecruitmentCalculationModel
    {
        private float[] PrisonerValues { get; set; }
        public Recruitable()
        {
            PrisonerValues = File.ReadLines("..\\..\\Modules\\Recruitable\\bin\\Win64_Shipping_Client\\values.txt").Select(float.Parse).ToArray();
        }
        public override float[] GetDailyRecruitedPrisoners(MobileParty mainParty)
        {
            return PrisonerValues;
        }
    }
}
