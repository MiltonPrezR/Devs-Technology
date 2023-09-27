using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public GameObject loading;
    public TextMeshProUGUI textProgress;
    public Slider sliderProgress;
    public float currentPercent;
    private AsyncOperation loadAsync;

    public void LoadSceneButton(string sceneLoadName)
    {
        loading.SetActive(true);
        StartCoroutine(LoadScene(sceneLoadName));
    }

    public IEnumerator LoadScene(string nameToLoad)
    {
        textProgress.text = "Loading.. 00%";
        loadAsync = SceneManager.LoadSceneAsync(nameToLoad);
        loadAsync.allowSceneActivation = false;
        while (!loadAsync.isDone)
        {
            // 0.9 -> 100
            // 0.9?   0.9 *100 /0.9
            currentPercent = loadAsync.progress * 100 / 0.9f;
            textProgress.text = "Loading.. " + currentPercent.ToString("00")+"%";
            yield return null;
        }
    }
    private void Update()
    {
        sliderProgress.value = currentPercent;

        if (loadAsync != null && currentPercent >= 100)
        {
                loadAsync.allowSceneActivation = true;
        }
      
    }
}
