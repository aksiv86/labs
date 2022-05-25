using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int _scene;
    public void LootScene(int _scene)
    {
        SceneManager.LoadScene(_scene);
    }
}
