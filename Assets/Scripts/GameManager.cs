using UnityEngine;

public class GameManager : MonoBehaviour
{

    public FactorySpawner fs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Enemy enemy = fs.CreateFast();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
