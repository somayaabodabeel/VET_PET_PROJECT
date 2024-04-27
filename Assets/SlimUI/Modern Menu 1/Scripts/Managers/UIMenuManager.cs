using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
  
    public GameObject exitPopup;

    private void Start()
    {
        // Set initial state
        mainMenu.SetActive(true);
       
        exitPopup.SetActive(false);
    }

    public void PlayButtonClicked()
    {
        // Play animation or transition to next scene
        mainMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitButtonClicked()
    {
        // Display exit popup
        exitPopup.SetActive(true);
    }

    public void ConfirmExit()
    {
        // Add any necessary exit logic
        Application.Quit();
    }

    public void CancelExit()
    {
        // Cancel exit and hide the popup
        exitPopup.SetActive(false);
    }
}
