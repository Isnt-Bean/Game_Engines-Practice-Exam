using UnityEngine;
using System.Collections;
public class GameManager : MonoBehaviour
{
    public FactorySpawner fs;
    void Start()
    {
        StartCoroutine(ResetEnemies());
    }

    IEnumerator ResetEnemies()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Enemy enemy = fs.CreateFast();
                Enemy enemy1 = fs.CreateStrong();
            }
            yield return new WaitForSeconds(15f);
        }
    }
}
