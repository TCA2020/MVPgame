using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVPentry : MonoBehaviour
{
    [SerializeField] MVPview view;
    void Start()
    {
        MVPmodel model = new MVPmodel();
        MVPpres pres = new MVPpres(model, view);
    }

    
}
