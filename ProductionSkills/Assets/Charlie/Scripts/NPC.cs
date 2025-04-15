using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC : MonoBehaviour
{
    public GameObject dialogueMenu;
    public void OpenDialogue()
    {
        Cursor.lockState = CursorLockMode.None;
        dialogueMenu.SetActive(true);
        MouseLook.Instance.mouseSensitivity = 0;
    }

    public void CloseDialogue()
    {
        Cursor.lockState= CursorLockMode.Locked;
        dialogueMenu.SetActive(false);
        MouseLook.Instance.mouseSensitivity = 200f;
    }

    public void YesDialogueOption()
    {
        SceneManager.LoadScene("Level02");
    }

    public void NoDialogueOption()
    {
        CloseDialogue();
    }
}
