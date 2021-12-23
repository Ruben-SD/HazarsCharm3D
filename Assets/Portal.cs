using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Killer lava;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        Debug.Log("Deactivated");
        this.gameObject.transform.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.transform.GetComponent<BoxCollider>().enabled = true;
        //Destroy(lava);
    }

    void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
