using UnityEngine;



public abstract class Factory : MonoBehaviour
{
    
    public abstract Enemy CreateFast();

    public abstract Enemy CreateStrong();

    
}
