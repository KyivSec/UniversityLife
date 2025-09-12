using TMPro;
using UnityEngine;

public class PhoneTime : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private int initialTime;
    
    private float realTimeCounter = 0f;
    private int totalMinutes;
    
    private void Start()
    {
        totalMinutes = initialTime;
        UpdateTimeDisplay();
    }
    
    private void Update()
    {
        realTimeCounter += Time.deltaTime;
        
        if (realTimeCounter >= 2f)
        {
            realTimeCounter = 0f;
            totalMinutes++;
            UpdateTimeDisplay();
        }
    }
    
    private void UpdateTimeDisplay()
    {
        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;
        
        timeText.text = $"{hours:D2}:{minutes:D2}";
    }

    public void SetTime(int minutes)
    {
        totalMinutes = minutes;
        UpdateTimeDisplay();
    }
}
