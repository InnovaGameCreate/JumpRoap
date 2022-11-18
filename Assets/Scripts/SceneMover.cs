using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    enum SceneType
    {
        title,
        main,
        result,
    }

    
    [SerializeField]
    private SceneType _sceneType;


    void Start()
    {
        StartCoroutine("SceneCoroutine");
    }

    IEnumerator SceneCoroutine()
    {
        yield return new WaitForSeconds(1.0f);
        yield return new WaitUntil(() => Input.GetKeyUp(KeyCode.Alpha1));
        SceneChanger();
    }

    void SceneChanger()
    {
        switch (_sceneType)
        {
            case SceneType.title:
                SceneManager.LoadScene(1);
                StaticJumpCount.jumpCount = 0;
                break;
            case SceneType.result:
                SceneManager.LoadScene(0);
                break;
        }
    }
}
