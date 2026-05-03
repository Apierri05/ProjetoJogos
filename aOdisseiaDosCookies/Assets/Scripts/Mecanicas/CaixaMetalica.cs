using UnityEngine;

public class CaixaMetalica : MonoBehaviour, IEletrizavel
{
    [SerializeField] private Elevador[] elevadores;
    [SerializeField] private AudioSource audioSource;

    public void Eletrizar()
    {
        audioSource.PlayOneShot(audioSource.clip);
        foreach (Elevador elevador in elevadores)
            elevador.Ativar();
    }
}
