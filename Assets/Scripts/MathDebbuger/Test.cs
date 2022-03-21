using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vec3 f = new Vec3(2, -4, -1);
        Vec3 g = new Vec3(0, 5, 2);
        Vector3 h = new Vector3(2, -4, -1);
        Vector3 i = new Vector3(0, 5, 2);


        Debug.Log(f);
        Debug.Log(g);
        Debug.Log(h);
        Debug.Log(i);
        Debug.Log(Vec3.Project(f,g));
        Debug.Log(Vector3.Project(h, i));
    }

    
}
