using UnityEngine;
using System.Collections;

public class BotaoElevador : MonoBehaviour
{
    [SerializeField] private Elevador elevador;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private KeyCode tecla = KeyCode.L;
    [SerializeField] private float atraso = 1f;
    [SerializeField] private float raioDeteccao = 1.5f;

    private bool ativado = false;

    private void Update()
    {
        if (ativado && elevador.EstaParado())
            ativado = false;

        if (ativado || !Input.GetKeyDown(tecla)) return;

        if (!JogadorPerto()) return;

        ativado = true;
        if (audioSource != null) audioSource.PlayOneShot(audioSource.clip);
        StartCoroutine(AtivarAposEspera());
    }

    private bool JogadorPerto()
    {
        Collider2D[] cols = Physics2D.OverlapCircleAll(transform.position, raioDeteccao);
        foreach (Collider2D col in cols)
        {
            if (col.CompareTag("Player"))
                return true;
        }
        return false;
    }

    private IEnumerator AtivarAposEspera()
    {
        yield return new WaitForSeconds(atraso);

        if (audioSource != null) audioSource.Stop();
        elevador.Ativar();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, raioDeteccao);
    }
}
