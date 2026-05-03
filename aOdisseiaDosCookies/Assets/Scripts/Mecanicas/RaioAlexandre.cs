using UnityEngine;

[RequireComponent(typeof(Movement))]
public class RaioAlexandre : MonoBehaviour
{
    [SerializeField] private float alcance = 10f;
    [SerializeField] private LayerMask layerEletrizavel;

    private Movement movement;
	
    private void Awake()
    {
        movement = GetComponent<Movement>();
    }

    public void Atirar()
    {
        float direcao = movement.IsFacingRight ? 1f : -1f;
        Vector2 origem = transform.position;

        RaycastHit2D hit = Physics2D.Raycast(origem, Vector2.right * direcao, alcance, layerEletrizavel);

        if (hit.collider != null)
        {
            IEletrizavel alvo = hit.collider.GetComponent<IEletrizavel>();
            alvo?.Eletrizar();
        }

        Debug.DrawRay(origem, Vector2.right * direcao * alcance, Color.yellow, 0.5f);
    }
}
