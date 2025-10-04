using UnityEngine;
using System.Collections;

public class FactorySpawner : Factory
{
    public GameObject FastPrefab;
    public GameObject StrongPrefab;


    public override Enemy CreateFast()
    {
        //this is where the code goes and is changed to fit what the game needs
        GameObject fast = Instantiate(FastPrefab, new Vector3(Random.Range(-30.0f, 13.0f), 0.5f, Random.Range(-30.0f, -13.0f)), Quaternion.identity);
        return fast.GetComponent<Enemy>();
    }/*-30, 13 to -30, -13 add random position on the platform*/

    public override Enemy CreateStrong()
    {
        GameObject strong = Instantiate(StrongPrefab, new Vector3(Random.Range(30, 13), 0.5f, Random.Range(-30, 13)), Quaternion.identity);
        return strong.GetComponent<Enemy>();
    }/*30, 13 to -30, 13 add random position on the platform*/
    
}
