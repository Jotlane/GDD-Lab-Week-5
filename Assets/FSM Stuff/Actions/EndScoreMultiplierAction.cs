using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/EndScoreMultiplier")]
public class EndScoreMultiplierAction : Action
{
    public override void Act(StateController controller)
    {
        DinoStateController m = (DinoStateController)controller;
        m.currentPowerupType = PowerupType.ScoreMult;
        m.ResetScoreMultiplierEvent.Invoke();
    }
}