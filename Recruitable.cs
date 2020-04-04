using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;

namespace Recruitable
{
    public class Recruitable : DefaultPrisonerRecruitmentCalculationModel
    {
        public override float[] GetDailyRecruitedPrisoners(MobileParty mainParty)
        {
            return new float[]
            {
                1f,
                0.7f,
                0.5f,
                0.4f,
                0.3f,
                0.2f,
                0.1f
            };
        }
    }
}
