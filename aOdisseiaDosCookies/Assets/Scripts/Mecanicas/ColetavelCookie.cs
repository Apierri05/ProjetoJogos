using UnityEngine;

public class ColetavelCookie : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.ColetouItem();
            Destroy(gameObject);
        }
    }
}
