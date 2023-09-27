using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScene : MonoBehaviour
{
    private Animator animacion;

    void Start() {
        animacion = GetComponentInChildren<Animator>();
    }
    public void CargarScene() {
        int nuevaScene = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(Scene_Load(nuevaScene));
    }

    public IEnumerator Scene_Load (int sceneIndex) {

        animacion.SetTrigger("StartTransitions");
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(sceneIndex);
    }
}
