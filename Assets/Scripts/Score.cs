using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    TextMeshProUGUI textMeshPro;
    
    private void Start()
    {
        score = 0;
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        textMeshPro.text = score.ToString();
    }
}
