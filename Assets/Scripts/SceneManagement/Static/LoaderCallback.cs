using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderCallback : MonoBehaviour
{
    [SerializeField] private bool isFirstUpdate = true;

    // Update is called once per frame
    private void Update()
    {
        if( isFirstUpdate )
        {
            isFirstUpdate = false;
            Loader.LoaderCallback();
        }
    }
}
