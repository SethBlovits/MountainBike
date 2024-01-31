using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 currentTilePosition;
    public GameObject tile;
    GameObject tileClone;
    public GameObject Killzone;

    void Start()
    {
        Vector3 spawnPoint = transform.position;
        
        for(int i = 0;i<(spawnPoint-Killzone.transform.position).magnitude;i += (int)tile.transform.localScale.z){
            tileClone = Instantiate(tile,spawnPoint+transform.forward*i,Quaternion.identity);
        }
        Instantiate(tile,spawnPoint + new Vector3(tile.transform.localScale.x,0,0),Quaternion.identity);
        Instantiate(tile,spawnPoint + new Vector3(-tile.transform.localScale.x,0,0),Quaternion.identity);
        currentTilePosition = tileClone.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        checkSpawn();
    }
    void checkSpawn(){
        Vector3 spawnPoint = transform.position;
        //Debug.Log(currentTilePosition);
        //Debug.Log((currentTilePosition-spawnPoint).magnitude);
        if((currentTilePosition-spawnPoint).magnitude>=tile.transform.localScale.z-1){
            tileClone = Instantiate(tile,spawnPoint,Quaternion.identity);
            currentTilePosition = tileClone.transform.position;
            Instantiate(tile,spawnPoint + new Vector3(tile.transform.localScale.x,0,0),Quaternion.identity);
            Instantiate(tile,spawnPoint + new Vector3(-tile.transform.localScale.x,0,0),Quaternion.identity);
        }
        currentTilePosition = tileClone.transform.position; 
    }


}
