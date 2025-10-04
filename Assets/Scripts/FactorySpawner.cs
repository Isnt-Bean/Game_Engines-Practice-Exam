using UnityEngine;
using Random = Unity.Mathematics.Random;

public class FactorySpawner : Factory
{
    public GameObject FastPrefab;
    public GameObject StrongPrefab;
    
    public float SpawnRate;
    
    
    
    public override void CreateFast()
    {
        //this is where the code goes and is changed to fit what the game needs
        GameObject fast = GameObject.Instantiate(FastPrefab, new Vector3(), Quaternion.identity);
    }/*-30, 13 to -30, -13 add random position on the platform*/

    public override void CreateStrong()
    {
        GameObject weak = GameObject.Instantiate(FastPrefab, new Vector3(), Quaternion.identity);
    }/*30, 13 to -30, 13 add random position on the platform*/
}
