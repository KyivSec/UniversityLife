using System.Data.Common;
using TMPro;
using UnityEngine;

public class PhoneTime : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;
    void Update()
    {
        var phoneTime = System.DateTime.Now;
        timeText.text = phoneTime.ToString("HH:mm");
    }
}
