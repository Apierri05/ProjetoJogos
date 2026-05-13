using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogo : MonoBehaviour
{
    [System.Serializable]
    public class CutsceneEvent
    {
        public int lineIndex;
        public GameObject target;
        public bool activate;
    }

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    [SerializeField] private CutsceneEvent[] events;
    [SerializeField] private string proximaCena;

    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialog();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialog()
    {
        index = 0;
        CheckEvents(); // executa eventos da primeira linha
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;

            CheckEvents(); // executa eventos da linha atual

            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            string cena = !string.IsNullOrEmpty(proximaCena) ? proximaCena : GameManager.cenaParaReiniciar;
            if (!string.IsNullOrEmpty(cena))
                SceneManager.LoadScene(cena);
            else
                gameObject.SetActive(false);
        }
    }

    void CheckEvents()
    {
        for (int x = 0; x < events.Length; x++)
        {
            if (events[x].lineIndex == index)
            {
                if (events[x].target != null)
                {
                    events[x].target.SetActive(events[x].activate);
                }
            }
        }
    }
}