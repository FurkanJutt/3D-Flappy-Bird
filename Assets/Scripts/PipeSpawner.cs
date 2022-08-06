using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float maxTime = 1f;
    [SerializeField] private float height = 0f;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipePrefab);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        newPipe.transform.parent = this.transform;
        Destroy(newPipe, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipePrefab);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            newPipe.transform.parent = this.transform;
            timer = 0f;
            Destroy(newPipe, 5f);
        }
        timer += Time.deltaTime;
    }
}
