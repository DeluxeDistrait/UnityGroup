using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject levelsMenu;

    public void NewGame()
    {
        //TODO: Make this load the first level
        SceneManager.LoadScene("Level01");
    }

    public void OpenLevelMenu()
    {
        mainMenu.SetActive(false);
        levelsMenu.SetActive(true);
    }

    public void CloseLevelMenu()
    {
        mainMenu.SetActive(true);
        levelsMenu.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
