using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuSettingsButton : MonoBehaviour
{
    public void LoadingForSettingsBUtton()
    {
        SceneManager.LoadScene("SettingsMenu"); // SettingsMenu adlý sahneyi yükler
    }

    public void LoadingForResumeButton()
    {
        SceneManager.LoadScene("SampleScene"); // SettingsMenu adlý sahneyi yükler
    }
}