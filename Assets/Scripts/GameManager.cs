using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FactorySpawner fs;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Enemy enemy = fs.CreateFast();
            Enemy enemy1 = fs.CreateStrong();
        }
    }
}
