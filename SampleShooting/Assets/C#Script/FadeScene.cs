using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScene : MonoBehaviour
{
    private string _SceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadSceneEvent()
    {
        SceneManager.LoadScene(_SceneName);
    }

    public void LoadScene(string sceneName)
    {
        GetComponent<Animator>().enabled = true;
        _SceneName = sceneName;
    }
}
