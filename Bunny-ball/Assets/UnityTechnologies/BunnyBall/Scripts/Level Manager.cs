using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public string Level1;
    public string Level2;
    public string Level3;

    public void LoadLevel1()
    {
        SceneManager.LoadScene(Level1);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(Level2);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene(Level3);
    }

}
