using DG.Tweening.Core.Easing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    private static SceneMove instance;
    void Awake()
    {

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Title_Scene");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene("Tutorial");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("StageSelectUI");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Takumi");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("Takumi 1");
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Takumi 2");
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("Takumi 3");
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("Takumi4");
        }
    }
}