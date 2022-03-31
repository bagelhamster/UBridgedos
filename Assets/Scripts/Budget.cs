using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Budget : MonoBehaviour
{
    public TextMeshProUGUI Budget2;
    public float Budget3 = 5000;
    public static int Budget1=5000;
    // Start is called before the first frame update
    void Start()
    {
        Budget2 = GetComponent<TextMeshProUGUI>();
        int Budget1 = (int)Budget3;
    }

    // Update is called once per frame
    void Update()
    {
        Budget2.text = "Budget £" + Budget3;
        int Budget1 = (int)Budget3;
    }
}
