using UnityEngine;

public class FactorySpawner : Factory
{
    public GameObject FastPrefab;
    public GameObject StrongPrefab;
    public GameObject WeakPrefab;
    
    
    public override void CreateFast()
    {
        //this is where the code goes and is changed to fit what the game needs
        GameObject fast = GameObject.Instantiate(FastPrefab, new Vector3(/*add random position on the platform*/), Quaternion.identity);

    }

    public override void CreateStrong()
    {
        
    }

    public override void CreateWeak()
    {
        
    }
}
