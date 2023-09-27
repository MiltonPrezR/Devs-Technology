using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class entreScenePerfil : MonoBehaviour
{
    private void Awake()
    {
        var entreS = FindObjectsOfType<entreScenePerfil>();
        if (entreS.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
