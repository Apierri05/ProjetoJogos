using UnityEngine;
using System.Collections;

public class BotaoElevador : MonoBehaviour
{
    [SerializeField] private Elevador elevador;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private KeyCode tecla = KeyCode.L;
    [SerializeField] private float atraso = 1f;

    private bool ativado = false;

    private void Update()
    {
        if (ativado || !Input.GetKeyDown(tecla)) return;

        ativado = true;
        if (audioSource != null) audioSource.PlayOneShot(audioSource.clip);
        StartCoroutine(AtivarAposEspera());
    }

    private IEnumerator AtivarAposEspera()
    {
        yield return new WaitForSeconds(atraso);

        if (audioSource != null) audioSource.Stop();
        elevador.Ativar();
    }
}
