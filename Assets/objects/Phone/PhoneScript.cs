using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneScript : MonoBehaviour
{
    [SerializeField] private GameObject phoneUIElement;
    [SerializeField] private float animationSpeed = 10f;
    [SerializeField] private int initialPosition;
    [SerializeField] private int finalPosition;
    private bool isPhoneUp;
    private RectTransform phoneRectTransform;
    private Coroutine currentAnimation;

    private void Start()
    {
        phoneRectTransform = phoneUIElement.GetComponent<RectTransform>();

        Vector2 startPos = phoneRectTransform.anchoredPosition;
        startPos.y = initialPosition;
        phoneRectTransform.anchoredPosition = startPos;
    }

    private void PhoneAnimationUp()
    {
        if (currentAnimation != null)
            StopCoroutine(currentAnimation);
        
        currentAnimation = StartCoroutine(AnimatePhone(finalPosition));
        isPhoneUp = true;
    }

    private void PhoneAnimationDown()
    {
        if (currentAnimation != null)
            StopCoroutine(currentAnimation);
        
        currentAnimation = StartCoroutine(AnimatePhone(initialPosition));
        isPhoneUp = false;
    }

    private IEnumerator AnimatePhone(int targetYPosition)
    {
        Vector2 currentPos = phoneRectTransform.anchoredPosition;
        Vector2 targetPos = new Vector2(currentPos.x, targetYPosition);
        
        while (Vector2.Distance(currentPos, targetPos) > 0.1f)
        {
            currentPos = Vector2.Lerp(currentPos, targetPos, animationSpeed * Time.deltaTime);
            phoneRectTransform.anchoredPosition = currentPos;
            yield return null;
        }
        
        phoneRectTransform.anchoredPosition = targetPos;
    }

    public void MenuButtonAction()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Mouse2))
        {
            if (isPhoneUp)
                PhoneAnimationDown();
            else
                PhoneAnimationUp(); 
        }
    }
}