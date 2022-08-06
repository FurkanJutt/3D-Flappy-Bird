using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] public static int score = 0;

    private TextMeshProUGUI text_Score;

    // Start is called before the first frame update
    void Start()
    {
        text_Score = GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text_Score.text = score.ToString();
    }
}
