using UnityEngine;
using UnityEngine.SceneManagement;

public class PortaSaida : MonoBehaviour
{
    private bool liberada = false;
    private int playersNaPorta = 0;
	private AudioSource audioSource;

    public string proximaCena;

	void Start(){
		audioSource = GetComponent<AudioSource>();
	}
    public void Liberar()
    {
        liberada = true;
        gameObject.SetActive(true);
		audioSource.Play();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playersNaPorta++;
            Debug.Log("Players na porta: " + playersNaPorta);

            VerificarSaida();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playersNaPorta--;
            Debug.Log("Players na porta: " + playersNaPorta);
        }
    }

    void VerificarSaida()
    {
		Debug.Log("Verificando saída...");
        Debug.Log("Liberada: " + liberada);
        Debug.Log("Players na porta: " + playersNaPorta);
        if (liberada && playersNaPorta >= 2)
        {
            Debug.Log("Ambos players presentes. Indo para próxima fase!");
            SceneManager.LoadScene(proximaCena);
        }
    }
}
