using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    [Header("Main Buttons")]
    [SerializeField] private Button _newGameButton;

    [Header("Panel Buttons")]
    [SerializeField] private Button _optionsButton;
    [SerializeField] private Button _optionsCategoryVideo;
    [SerializeField] private Button _optionsCategoryGraphics;
    [SerializeField] private Button _optionsCategorySounds;
    [SerializeField] private Button _exitYESButton;

    [Header("'More' Menu Tabs")]
    [SerializeField] private GameObject _tabPanel;
    [SerializeField] private GameObject _catSelector;
    [SerializeField] private GameObject _tabOptions;
    [SerializeField] private GameObject _tabOptionsVideo;
    [SerializeField] private GameObject _tabOptionsGraphics;
    [SerializeField] private GameObject _tabOptionsSounds;

    [Header("Main Panels")]
    [SerializeField] private GameObject _exitPanel;

    private void OnNewGame()
    {
        // Maybe some code for animation or something
        SceneManager.LoadScene("Corridor");
    }

    private void OnOptions()
    {
        OptionCategories("video");

        _tabOptions.SetActive(true);
    }

    private void OptionCategories(string category)
    {
        Debug.Log("Current category: " + category); // Comment this when options tab will be finished
        if (category == "video")
        {
            _tabOptionsVideo.SetActive(true);
            _tabOptionsGraphics.SetActive(false);
            _tabOptionsSounds.SetActive(false);
        }
        else if (category == "graphics")
        {
            _tabOptionsVideo.SetActive(false);
            _tabOptionsGraphics.SetActive(true);
            _tabOptionsSounds.SetActive(false);
        }
        else if (category == "sounds")
        {
            _tabOptionsVideo.SetActive(false);
            _tabOptionsGraphics.SetActive(false);
            _tabOptionsSounds.SetActive(true);
        }
        else
        {
            Debug.LogError("Option category can't be defined");
        }
    }
    private void ExitYes()
    {
        Application.Quit();
    }

    private void ButtonConnector()
    {
        _newGameButton.onClick.AddListener(OnNewGame);

        _optionsButton.onClick.AddListener(OnOptions);
        _optionsCategoryVideo.onClick.AddListener(() => OptionCategories("video"));
        _optionsCategoryGraphics.onClick.AddListener(() => OptionCategories("graphics"));
        _optionsCategorySounds.onClick.AddListener(() => OptionCategories("sounds"));

        _exitYESButton.onClick.AddListener(ExitYes);
    }

    void Start()
    {
        ButtonConnector();
        _tabPanel.SetActive(false);
        _exitPanel.SetActive(false);
    }
}
