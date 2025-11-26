using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float averageSpawnRatePerSecond = 0.5f;
    public float top = 8f;
    public float bottom = -3f;

    void Update()
    {
        // since Update is called once per frame, we multiply with
        // Time.deltaTime, to compensate for difference in computer speed
        // (there are also other ways to solve this)
        if (Random.Range(0.0f, 1.0f) < averageSpawnRatePerSecond * Time.deltaTime)
        {
            var go = Instantiate(prefab);
            go.transform.position = new Vector3(
                Camera.main.transform.position.x + transform.position.x,
                Random.Range(bottom, top),
                0);

            // Clean up after 30 secs
            Destroy(go, 30f);
        }
    }
}
