using UnityEngine;

public class GabrielPlayer : PlayerController
{
    [SerializeField] private GameObject machadoPrefab;
    [SerializeField] private float cooldown = 1f;
    [SerializeField] private int estoqueInicial = 3;

    private float proximoLancamento = 0f;
    private int machadosDisponiveis;

    protected override KeyCode LeftKey     => KeyCode.LeftArrow;
    protected override KeyCode RightKey    => KeyCode.RightArrow;
    protected override KeyCode JumpKey     => KeyCode.UpArrow;
    protected override KeyCode InteractKey => KeyCode.DownArrow;

    protected override void Awake()
    {
        base.Awake();
        machadosDisponiveis = estoqueInicial;
    }

    public void ColetarMachado()
    {
        machadosDisponiveis++;
    }

    protected override void Interact()
    {
        if (machadosDisponiveis <= 0) return;
        if (Time.time < proximoLancamento) return;
        proximoLancamento = Time.time + cooldown;

        machadosDisponiveis--;
        float direcao = movement.IsFacingRight ? 1f : -1f;
        GameObject machado = Instantiate(machadoPrefab, transform.position, Quaternion.identity);
        machado.GetComponent<MachadoGabriel>().Lancar(direcao);
    }
}
