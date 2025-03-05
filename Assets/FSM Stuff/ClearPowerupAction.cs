using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Actions/ClearPowerup")]
public class ClearPowerupAction : Action
{
    public override void Act(StateController controller)
    {
        DinoStateController m = (DinoStateController)controller;
        m.currentPowerupType = PowerupType.Default;
    }
}