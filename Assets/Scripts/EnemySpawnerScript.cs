using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    float timeElapsed = 0f;
    public GameObject enemy;
    public float baseSpeed = 10f;
    public float interval = 1;
    float timer = 0f;
    bool paused = false;
    void Start()
    {
        timeElapsed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused)
        {
            timeElapsed += Time.deltaTime;
            timer += Time.deltaTime;
            if (timer > interval)
            {
                spawnEnemy(timeElapsed * 0.01f);
                timer = 0f;
            }

        }

    }
    void spawnEnemy(float time)
    {
        GameObject instance = Instantiate(enemy, transform);
        instance.GetComponent<EnemyMovement>().speed = baseSpeed + time;
    }
    public void PauseSpawning()
    {
        paused = true;
    }
    public void RestartGame()
    {
        timeElapsed = 0f;
        timer = 0f;
        paused = false;
    }
}
