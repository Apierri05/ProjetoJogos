using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int coletados = 0;

    public GameObject portaSaida;

    private int totalColetaveis;

	void Start(){
		totalColetaveis = GameObject.FindGameObjectsWithTag("ColetavelCookie").Length;
		Debug.Log($"[GameManager] Total de coletaveis na cena: {totalColetaveis}");

		AlexandrePlayer alexandre = FindFirstObjectByType<AlexandrePlayer>();
		GabrielPlayer gabriel = FindFirstObjectByType<GabrielPlayer>();

		Collider2D colAle = alexandre?.GetComponent<Collider2D>();
		Collider2D colGab = gabriel?.GetComponent<Collider2D>();

		if (colAle != null && colGab != null)
			Physics2D.IgnoreCollision(colAle, colGab);

		CaixaMetalica[]  caixas   = FindObjectsByType<CaixaMetalica> (FindObjectsSortMode.None);
		MiniComeCome[]   inimigos = FindObjectsByType<MiniComeCome>   (FindObjectsSortMode.None);

		foreach (CaixaMetalica caixa in caixas)
		{
			Collider2D colCaixa = caixa.GetComponent<Collider2D>();
			if (colCaixa == null) continue;

			if (colAle != null) Physics2D.IgnoreCollision(colAle,  colCaixa);
			if (colGab != null) Physics2D.IgnoreCollision(colGab,  colCaixa);

			foreach (MiniComeCome inimigo in inimigos)
			{
				Collider2D colInimigo = inimigo.GetComponent<Collider2D>();
				if (colInimigo != null) Physics2D.IgnoreCollision(colInimigo, colCaixa);
			}
		}

		for (int i = 0; i < inimigos.Length; i++)
		{
			Collider2D colA = inimigos[i].GetComponent<Collider2D>();
			if (colA == null) continue;
			for (int j = i + 1; j < inimigos.Length; j++)
			{
				Collider2D colB = inimigos[j].GetComponent<Collider2D>();
				if (colB != null) Physics2D.IgnoreCollision(colA, colB);
			}
		}
	}
    void Awake()
    {
        instance = this;
    }

    public void ColetouItem()
    {
        coletados++;
        Debug.Log($"[GameManager] Coletados: {coletados}/{totalColetaveis}");

        if (totalColetaveis > 0 && coletados >= totalColetaveis)
        {
            LiberarSaida();
        }
    }

    void LiberarSaida()
    {
        Debug.Log("Saída liberada!");

        portaSaida.GetComponent<PortaSaida>().Liberar();
    }

    public static string cenaParaReiniciar;

    public void MorrerJogadores()
    {
        cenaParaReiniciar = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Cutscene6");
    }
}
