using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections.Generic;

public class MenuSettings : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown; // Resolution dropdown for settings
    Resolution[] resolutions;               // Array of available screen resolutions

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        // Get the available screen resolutions
        resolutions = Screen.resolutions;

        // Clear the dropdown options
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        // Loop through all available resolutions
        for (int i = 0; i < resolutions.Length; i++)
        {
            // Add each resolution to the dropdown list
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            // If this is the current resolution, set it as the default in the dropdown
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        // Add options to the dropdown and set the default selection
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Function to load the main menu scene
    public void MainMenu()
    {
        // Load the main menu scene (assuming it has the name "Main Menu")
        SceneManager.LoadScene("MainMenu");  // Change to your game's scene index or name
    }

    // Function to change the screen resolution
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        // Set the screen resolution
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    // Function to change the volume using AudioListener
    public void SetVolume(float volume)
    {
        // The AudioListener volume value ranges from 0 (mute) to 1 (full volume)
        AudioListener.volume = volume;
    }

    // Function to change the quality of the game
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    // Function to toggle fullscreen mode
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}