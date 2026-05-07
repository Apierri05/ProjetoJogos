using UnityEngine;

public class Agua : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<AlexandrePlayer>() != null)
            GameManager.instance.MorrerJogadores();
    }
}
