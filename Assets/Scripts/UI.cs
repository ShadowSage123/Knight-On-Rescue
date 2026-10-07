using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI instance;

    [SerializeField] private GameObject gameOverUI;
    [Space]
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI killCountText;

    private int killCount;

    private void Awake()
    {
        instance = this;
        Time.timeScale = 1;
    }

    private void Update()
    {
        timerText.text = Time.time.ToString("F2") + "s";
    }

    public void EnableGameOverUI()
    {
        Time.timeScale = .5f;
        gameOverUI.SetActive(true);
    }

    public void RestartLevel()
    {
        int sceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }
    public void AddKillCount()
    {
        killCount++;
        killCountText.text = killCount.ToString();
    }
}
