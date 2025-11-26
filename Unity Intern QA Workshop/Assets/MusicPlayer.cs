using System.Linq;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioListener audioListener;
    
    void Start()
    {
        audioListener = FindObjectsByType<AudioListener>(FindObjectsSortMode.None).First();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            audioListener.enabled = !audioListener.enabled;
        }
    }
}
