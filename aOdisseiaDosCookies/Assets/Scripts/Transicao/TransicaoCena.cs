using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoCena : MonoBehaviour
{
    public void CarregarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
        
    }
}