using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenasMini : MonoBehaviour
{
    //int numero es en que numero de scena quiere ir
    public void btnScene(string nameScene) {
        SceneManager.LoadScene(nameScene);
    }
}
