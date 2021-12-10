using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    public string[] tagName;

    void OnCollisionEnter(Collision exampleCol)
    {
        foreach(string tag in tagName)
        {
            if(exampleCol.collider.tag != tag)
            {
                //Replace 'Game Over' with your game over scene's name.
                //SceneManager.LoadScene("Game Over");
                Debug.Log("Collision with " + exampleCol.gameObject);
                Application.Quit();
            }
        }      
     }
}
