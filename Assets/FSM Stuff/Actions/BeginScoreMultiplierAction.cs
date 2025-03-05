using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/BeginScoreMultiplier")]
public class BeginScoreMultiplierAction : Action
{
    public override void Act(StateController controller)
    {
        DinoStateController m = (DinoStateController)controller;
        m.currentPowerupType = PowerupType.ScoreMult;
        m.IncreaseScoreMultiplierEvent.Invoke();
    }
}