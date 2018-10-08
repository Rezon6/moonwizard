using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    //skripta sem sér um að spawna óvini

    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnDelay;
    public float spawnMaxDelay;
    public float spawnMinDelay;
    public float startDelay;
    public bool stop;

    int randEnemy;
    
	void Start ()
    {
        StartCoroutine(delaySpawner());
	}
	
	void Update ()
    {
        spawnDelay = Random.Range(spawnMinDelay, spawnMaxDelay);
    }

    IEnumerator delaySpawner()
    {
        yield return new WaitForSeconds(startDelay);

        while (!stop)
        {
            randEnemy = Random.Range(0,0);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1 ,Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate (enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
