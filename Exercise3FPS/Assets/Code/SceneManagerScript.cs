using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField]
    List<SceneInfo> SceneInfoList;
    Transform PlayerTrans;
    [SerializeField]
    float range = 100;

    private void Start() {
        PlayerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update() {
        foreach (SceneInfo s in SceneInfoList) {
            Scene scene = SceneManager.GetSceneByName(s.sceneName);
            float currDist = Vector3.Distance(PlayerTrans.position, s.posistion);
            if (currDist <= range) {    //player in range of scene
                if (!scene.isLoaded) {
                    loadScene(scene);
                }
            } else {
                if (scene.isLoaded) {
                    unloadScene(scene);
                }
            }
        }
    }

    private void loadScene(Scene inputScene) {
        SceneManager.LoadSceneAsync(inputScene.buildIndex);
    }

    private void unloadScene(Scene inputScene) {
        SceneManager.UnloadSceneAsync(inputScene.buildIndex);
    }
}
