using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject killWall;
    float timer;
    void Start()
    {
        timer = Random.Range(1,10);

    }

    // Update is called once per frame
    void Update()
    {
        if(checkTimer()){
            spawnByEnd();
        }
    }
    void spawnByEnd(){
        Instantiate(enemy,killWall.transform.position,Quaternion.identity);
    }
    bool checkTimer(){
        if(timer<= 0 ){
            timer = Random.Range(1,10);
            return true;
        }
        else{
            timer -= Time.deltaTime;
            return false;
        }
    }
}
