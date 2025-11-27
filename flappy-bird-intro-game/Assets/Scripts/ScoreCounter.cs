using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static uint TotalScore = 0;
    
    private uint trackedScore = 0;
    private TextMesh text;

    private void Start()
    {
        text = GetComponent<TextMesh>();
    }

    void Update()
    {
        if (TotalScore != trackedScore)
        {
            trackedScore = TotalScore;
            text.text = "Socre" + trackedScore;
        }
    }
}
