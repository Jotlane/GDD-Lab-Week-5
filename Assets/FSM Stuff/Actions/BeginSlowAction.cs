using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/BeginSlow")]
public class BeginSlowAction : Action
{
    public override void Act(StateController controller)
    {
        DinoStateController m = (DinoStateController)controller;
        m.currentPowerupType = PowerupType.Slow;
        Time.timeScale = 0.1f;
    }
}