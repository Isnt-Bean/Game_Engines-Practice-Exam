using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RestartLevel : MonoBehaviour
{
    
    public Button restartButton;

    void Start()
    {
        restartButton.onClick.AddListener(restartLevel);
    }
    public void restartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
