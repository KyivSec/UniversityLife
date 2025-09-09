using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("UI Text")]
    [SerializeField] private TMP_Text _tabNameText;

    [Header("Buttons")]
    [SerializeField] private Button _newGameButton;
    [SerializeField] private Button _optionsButton;
    [SerializeField] private Button _optionsCategoryVideo;
    [SerializeField] private Button _optionsCategoryGraphics;
    [SerializeField] private Button _optionsCategorySounds;
    [SerializeField] private Button _creditsButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _exitYESButton;
    [SerializeField] private Button _exitNOButton;

    [Header("Menu Tabs")]
    [SerializeField] private GameObject _tabPanel;
    [SerializeField] private GameObject _catSelector;
    [SerializeField] private GameObject _tabOptions;
    [SerializeField] private GameObject _tabOptionsVideo;
    [SerializeField] private GameObject _tabOptionsGraphics;
    [SerializeField] private GameObject _tabOptionsSounds;
    [SerializeField] private GameObject _tabCredits;
    [SerializeField] private GameObject _tabExit;

    private void OnNewGame()
    {
        // Maybe some code for animation or something
        SceneManager.LoadScene("Corridor");
    }

    private void OnOptions()
    {
        OptionCategories("video");
        _tabNameText.text = "Options";
        _catSelector.SetActive(true);

        if (_tabPanel.activeSelf)
        {
            _tabPanel.SetActive(false);
            _tabOptionsVideo.SetActive(false);
            _tabOptionsGraphics.SetActive(false);
            _tabOptionsSounds.SetActive(false);
        }

        else
        {
            _tabPanel.SetActive(true);
            _tabOptions.SetActive(true);
            _tabCredits.SetActive(false);
        }
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
            Debug.Log("Category can't be defined");
        }
    }

    private void OnCredits()
    {
        _tabNameText.text = "Credits";
        _catSelector.SetActive(false);

        if (_tabPanel.activeSelf)
        {
            _tabPanel.SetActive(false);
            _tabCredits.SetActive(false);
        }
        else
        {
            _tabPanel.SetActive(true);
            _tabCredits.SetActive(true);
        }
    }

    private void OnExit()
    {
        _tabNameText.text = "Exit Confirmation";
        _catSelector.SetActive(false);
        if (_tabPanel.activeSelf)
        {
            _tabPanel.SetActive(false);
            _tabExit.SetActive(false);
        }
        else
        {
            _tabPanel.SetActive(true);
            _tabExit.SetActive(true);
        }
    }
    private void ExitNo()
    {
        _tabPanel.SetActive(false);
        _tabExit.SetActive(false);
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

        _creditsButton.onClick.AddListener(OnCredits);

        _exitButton.onClick.AddListener(OnExit);
        _exitYESButton.onClick.AddListener(ExitYes);
        _exitNOButton.onClick.AddListener(ExitNo);

    }

    void Start()
    {
        ButtonConnector();
        _tabPanel.SetActive(false);
    }
}
