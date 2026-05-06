using UnityEngine;

public class ColetavelMachado : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GabrielPlayer gabriel = other.GetComponent<GabrielPlayer>();
        if (gabriel != null)
        {
            gabriel.ColetarMachado();
            Destroy(gameObject);
        }
    }
}
