using UnityEngine;

public class ChangeAvatar : MonoBehaviour
{
    public string tagName;

    private void OnTriggerEnter(Collider col)
    {
        GameObject rocket, player;
        if (col.tag == tagName)
        {
            player = col.gameObject.transform.parent.gameObject;

            player.GetComponent<ThirdPersonCamera>().lookAt = this.transform.parent.gameObject.transform.parent.gameObject.transform;
            SetChildren(player, false);
            //player.GetComponent<ThirdPersonCamera>().gameObject.transform.parent = this.transform;

            rocket = this.transform.parent.gameObject.transform.parent.gameObject;
            //rocket.GetComponent<Camera>().enabled = false;
            EnableScripts(rocket);
            EnableComponents(rocket);
            SetChildren(rocket, true);

            Debug.Log("Player name: " + player.name);
            Debug.Log("Suit name: " + rocket.name);
        }
    }

    private void EnableScripts(GameObject gameObject)
    {
        MonoBehaviour[] scriptComponents = gameObject.GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour script in scriptComponents)
        {
            script.enabled = true;
        }
    }

    private void EnableComponents(GameObject gameObject)
    {
        gameObject.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<CharacterController>().enabled = true;
    }

    private void SetChildren(GameObject gameObject, bool option)
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(option);
        }
    }
}
