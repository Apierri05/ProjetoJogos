using UnityEngine;
using System.Collections;

public class BotaoPonte : MonoBehaviour
{
    [SerializeField] private Ponte[]     pontes;
    [SerializeField] private AudioSource audioSource;

    private bool ativado = false;

    private void Update()
    {
        if (ativado || !Input.GetKeyDown(KeyCode.L)) return;

        ativado = true;
        audioSource.PlayOneShot(audioSource.clip);
        StartCoroutine(AtivarAposEspera());
    }

    private IEnumerator AtivarAposEspera()
    {
        yield return new WaitForSeconds(1f);

        audioSource.Stop();

        foreach (Ponte ponte in pontes)
            ponte.Ativar();
    }
}
