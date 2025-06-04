using UnityEngine;

public class FollowCamera : MonoBehaviour

{

    public GameObject John;


    void Update()
    {
        if(John != null){

        
        Vector3 position = transform.position;
        position.x = John.transform.position.x;
        transform.position = position;
        }
    }
}

