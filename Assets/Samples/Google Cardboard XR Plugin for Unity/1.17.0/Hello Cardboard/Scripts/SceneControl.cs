using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public Button nextButton;
    public Button previousButton;

    private void Start()
    {
        nextButton.onClick.AddListener(NextScene);
        previousButton.onClick.AddListener(PreviousScene);
    }

    private void NextScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        int nextSceneIndex = SceneManager.GetSceneByName(currentSceneName).buildIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    private void PreviousScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        int previousSceneIndex = SceneManager.GetSceneByName(currentSceneName).buildIndex - 1;

        if (previousSceneIndex >= 0)
        {
            SceneManager.LoadScene(previousSceneIndex);
        }
    }
}
