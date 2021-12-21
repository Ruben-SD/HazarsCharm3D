using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using AnimatorStateInfo;

public class isfinished : MonoBehaviour
{
    GameObject inittext;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        inittext = this.transform.parent.gameObject;
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
}
