using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuSettingsButton : MonoBehaviour
{
    public void LoadingForSettingsBUtton()
    {
        SceneManager.LoadScene("SettingsMenu"); // SettingsMenu adl� sahneyi y�kler
    }

    public void LoadingForResumeButton()
    {
        SceneManager.LoadScene("SampleScene"); // SettingsMenu adl� sahneyi y�kler
    }
}