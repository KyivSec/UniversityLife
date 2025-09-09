using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    [Header("Menu Tabs")]
    [SerializeField] private GameObject _tabPanel;
    [SerializeField] private GameObject _tabOptions;
    [SerializeField] private GameObject _tabOptionsVideo;
    [SerializeField] private GameObject _tabOptionsGraphics;
    [SerializeField] private GameObject _tabOptionsSounds;
    [SerializeField] private GameObject _tabCredits;

    private void OnNewGame()
    {

    }

    private void OnOptions()
    {
        OptionCategories("video");
        _tabNameText.text = "Options";

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
        Debug.Log("Current category: " + category); // Comment this when finish
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

    private void ButtonConnector()
    {
        _newGameButton.onClick.AddListener(OnNewGame);

        _optionsButton.onClick.AddListener(OnOptions);
        _optionsCategoryVideo.onClick.AddListener(() => OptionCategories("video"));
        _optionsCategoryGraphics.onClick.AddListener(() => OptionCategories("graphics"));
        _optionsCategorySounds.onClick.AddListener(() => OptionCategories("sounds"));
    }

    void Start()
    {
        ButtonConnector();
        _tabPanel.SetActive(false);
    }
}
