using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyCounter : MonoBehaviour
{
    public static KeyCounter instance;

    public TMP_Text keyText;
    public int currentKeys = 0;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        keyText.text = "Keys: " + currentKeys.ToString();
    }

    public void IncreaseKeys(int v)
    {
        currentKeys += v;
        keyText.text = "Keys: " + currentKeys.ToString();
    }
}
