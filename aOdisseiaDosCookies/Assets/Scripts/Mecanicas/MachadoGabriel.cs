using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MachadoGabriel : MonoBehaviour
{
    [SerializeField] private float velocidadeHorizontal = 8f;
    [SerializeField] private float velocidadeVertical   = 4f;
    [SerializeField] private float tempoVida            = 3f;

    public void Lancar(float direcao)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(direcao * velocidadeHorizontal, velocidadeVertical);
        Destroy(gameObject, tempoVida);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        IInimigo inimigo = other.GetComponent<IInimigo>();
        if (inimigo != null)
        {
            inimigo.Morrer();
            Destroy(gameObject);
        }
    }
}
