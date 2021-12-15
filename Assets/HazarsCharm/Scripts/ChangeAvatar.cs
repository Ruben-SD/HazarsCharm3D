using UnityEngine;

public class ChangeAvatar : MonoBehaviour
{
    public string tagName;

    private void OnTriggerEnter(Collider col)
    {
        GameObject astronaut_suit, player;
        if (col.tag == tagName)
        {
            player = col.gameObject.transform.parent.gameObject;
            SetChildren(player, false);

            astronaut_suit = this.transform.parent.gameObject.transform.parent.gameObject;
            EnableScripts(astronaut_suit);
            EnableComponents(astronaut_suit);
            SetChildren(astronaut_suit, true);
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