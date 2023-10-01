using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button playButton;
    public Button pauseButton;
    public Button stopButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayVideo);
        pauseButton.onClick.AddListener(PauseVideo);
        stopButton.onClick.AddListener(StopVideo);
    }

    private void PlayVideo()
    {
        videoPlayer.Play();
    }

    private void PauseVideo()
    {
        videoPlayer.Pause();
    }

    private void StopVideo()
    {
        videoPlayer.Stop();
    }
}
