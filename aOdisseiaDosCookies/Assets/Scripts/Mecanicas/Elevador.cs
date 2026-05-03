using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Elevador : MonoBehaviour
{
    [SerializeField] private Transform pontoA;
    [SerializeField] private Transform pontoB;
    [SerializeField] private float velocidade = 2f;

    private enum Estado { Parado, IndoParaB, RetornandoParaA }
    private Estado estado = Estado.Parado;

    private Vector3 posA;
    private Vector3 posB;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.gravityScale = 0f;
    }

    private void Start()
    {
        posA = pontoA.position;
        posB = pontoB.position;
    }

    public void Ativar()
    {
        if (estado == Estado.Parado)
            estado = Estado.IndoParaB;
    }

    private void FixedUpdate()
    {
        if (estado == Estado.Parado) return;

        Vector2 alvo = estado == Estado.IndoParaB ? posB : posA;
        Vector2 novaPos = Vector2.MoveTowards(rb.position, alvo, velocidade * Time.fixedDeltaTime);
        rb.MovePosition(novaPos);

        if (Vector2.Distance(rb.position, alvo) < 0.01f)
        {
            if (estado == Estado.IndoParaB)
                estado = Estado.RetornandoParaA;
            else
                estado = Estado.Parado;
        }
    }
}
