using UnityEngine;

public class CharacterStats : ScriptableObject {

    public float moveSpeed = 4.0f;

    public float jumpForce = 5.0f;

    public bool  canDoubleJump = false;

    public int   maxHealth = 3;

    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
}
