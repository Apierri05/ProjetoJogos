using UnityEngine;

public class GabrielPlayer : PlayerController
{
    protected override KeyCode LeftKey     => KeyCode.LeftArrow;
    protected override KeyCode RightKey    => KeyCode.RightArrow;
    protected override KeyCode JumpKey     => KeyCode.UpArrow;
    protected override KeyCode InteractKey => KeyCode.DownArrow;

    protected override void Interact()
    {
        Debug.Log("Gabriel lancou um machado");
    }
}
