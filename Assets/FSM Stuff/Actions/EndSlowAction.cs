using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/EndSlow")]
public class BEndSlowAction : Action
{
    public override void Act(StateController controller)
    {
        DinoStateController m = (DinoStateController)controller;
        m.currentPowerupType = PowerupType.Slow;
        Time.timeScale = 1f;
    }
}