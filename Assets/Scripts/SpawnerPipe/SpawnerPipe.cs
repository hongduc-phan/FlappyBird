using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipe : MonoBehaviour {
    
    [SerializeField]
    private GameObject pipeHolder;
	// Use this for initialization
	void Start () {
        StartCoroutine(Spawner());
	}
    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(2);
        Vector3 temp = pipeHolder.transform.position;
        temp.y = Random.Range(-2.5f, 3.2f);
        Instantiate(pipeHolder, temp, Quaternion.identity);
        StartCoroutine(Spawner());
    }
	
	
}
