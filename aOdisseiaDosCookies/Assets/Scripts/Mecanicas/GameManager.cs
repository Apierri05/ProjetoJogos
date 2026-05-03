using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int coletados = 0;

    public GameObject portaSaida;

    private int totalColetaveis;
	
	void Start(){
		totalColetaveis = GameObject.FindGameObjectsWithTag("ColetavelCookie").Length;

		AlexandrePlayer alexandre = FindFirstObjectByType<AlexandrePlayer>();
		GabrielPlayer gabriel = FindFirstObjectByType<GabrielPlayer>();

		if (alexandre != null && gabriel != null)
		{
			Collider2D colAle = alexandre.GetComponent<Collider2D>();
			Collider2D colGab = gabriel.GetComponent<Collider2D>();
			if (colAle != null && colGab != null)
				Physics2D.IgnoreCollision(colAle, colGab);
		}
	}
    void Awake()
    {
        instance = this;
    }

    public void ColetouItem()
    {
        coletados++;

        if (coletados >= totalColetaveis)
        {
            LiberarSaida();
        }
    }

    void LiberarSaida()
    {
        Debug.Log("Saída liberada!");

        portaSaida.GetComponent<PortaSaida>().Liberar();
    }
}
