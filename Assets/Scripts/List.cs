using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class List : MonoBehaviour
{
    public void MoveLevel1()
    {
        SceneManager.LoadScene("Level 1");
        Debug.Log("Level 1���� ��ȯ");
    }

    public void MoveLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
}