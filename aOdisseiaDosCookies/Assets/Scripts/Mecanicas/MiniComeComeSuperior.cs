using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MiniComeComeSuperior : MonoBehaviour, IInimigo
{
    [SerializeField] private float velocidade        = 2f;
    [SerializeField] private float distanciaPatrulha = 4f;
    [SerializeField] private GameObject projetilPrefab;
    [SerializeField] private float intervaloDeTiro   = 2f;
    [SerializeField] private bool atirarParaDireita  = true;
    [SerializeField] private bool olharParaDireita   = true;

    private Rigidbody2D rb;
    private Vector2 pontoInicial;
    private bool movendoParaDireita = true;
    private float proximoTiro;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        pontoInicial = transform.position;

        PhysicsMaterial2D semFriccao = new PhysicsMaterial2D();
        semFriccao.friction   = 0f;
        semFriccao.bounciness = 0f;
        rb.sharedMaterial = semFriccao;

        Collider2D col = GetComponent<Collider2D>();
        if (col != null) col.sharedMaterial = semFriccao;

        movendoParaDireita = olharParaDireita;
        if (!olharParaDireita)
        {
            Vector3 escala = transform.localScale;
            escala.x *= -1;
            transform.localScale = escala;
        }
    }

    private void FixedUpdate()
    {
        Patrulhar();
    }

    private void Update()
    {
        if (Time.time >= proximoTiro)
        {
            Atirar();
            proximoTiro = Time.time + intervaloDeTiro;
        }
    }

    private void Patrulhar()
    {
        float x = transform.position.x;

        if (movendoParaDireita)
        {
            rb.linearVelocity = new Vector2(velocidade, rb.linearVelocity.y);
            if (x >= pontoInicial.x + distanciaPatrulha)
                Virar();
        }
        else
        {
            rb.linearVelocity = new Vector2(-velocidade, rb.linearVelocity.y);
            if (x <= pontoInicial.x - distanciaPatrulha)
                Virar();
        }
    }

    private void Virar()
    {
        movendoParaDireita = !movendoParaDireita;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void Atirar()
    {
        if (projetilPrefab == null) return;

        Vector2 direcao = atirarParaDireita ? Vector2.right : Vector2.left;
        GameObject projetil = Instantiate(projetilPrefab, transform.position, Quaternion.identity);
        projetil.GetComponent<ProjetilComeCome>().Lancar(direcao);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            GameManager.instance.MorrerJogadores();
    }

    public void Morrer()
    {
        Destroy(gameObject);
    }
}
