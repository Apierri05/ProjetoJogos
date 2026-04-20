using UnityEngine;

public class AlexandrePlayer : PlayerController
{
    protected override KeyCode LeftKey     => KeyCode.A;
    protected override KeyCode RightKey    => KeyCode.D;
    protected override KeyCode JumpKey     => KeyCode.W;
    protected override KeyCode InteractKey => KeyCode.S;

    protected override void Interact()
    {
        Debug.Log("Alexandre lancou um raio");
    }
}
