using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayerVideo : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private string proximaCena;

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoFim;
        videoPlayer.Play();
    }

    private void Update()
    {
        if (Input.anyKeyDown)
            CarregarProximaCena();
    }

    private void OnVideoFim(VideoPlayer vp)
    {
        CarregarProximaCena();
    }

    private void CarregarProximaCena()
    {
        videoPlayer.loopPointReached -= OnVideoFim;
        SceneManager.LoadScene(proximaCena);
    }
}
