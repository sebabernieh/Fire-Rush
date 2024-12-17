using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelSelectController : MonoBehaviour
{
    public static LevelSelectController instance;


    private void Awake()
    {
        // Singleton pattern
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Optional: Keep the controller between scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicate instances
        }
    }
    public GameObject levelInfoBox;
    public TMP_Text levelText, actionText;
}
