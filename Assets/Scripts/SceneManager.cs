using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject go;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
