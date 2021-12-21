using UnityEngine;

public class ChangeAvatar : MonoBehaviour
{
    public string tagName;
    public string nameCamera;

    private void OnTriggerEnter(Collider col)
    {
        GameObject oldAvatar, newAvatar;
        if (col.tag == tagName)
        {
            // Astronaut Suit to Rocket
            if (tagName == "Finish")
                oldAvatar = col.gameObject;
            // Kid to Astronaut Suit
            else
                oldAvatar = col.gameObject.transform.parent.gameObject;
            SetChildren(oldAvatar, false);

            // Astronaut Suit to Rocket
            if (tagName == "Finish")
                newAvatar = this.transform.parent.gameObject;
            // Kid to Astronaut Suit
            else
                newAvatar = this.transform.parent.gameObject.transform.parent.gameObject;
            EnableScripts(newAvatar);
            EnableComponents(newAvatar);
            SetChildren(newAvatar, true);
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
        GameObject rocketCamera;
        if (tagName == "Finish")
        {
            rocketCamera = GameObject.Find(nameCamera);
            rocketCamera.GetComponent<Camera>().enabled = true;
            rocketCamera.GetComponent<AudioListener>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }

    private void SetChildren(GameObject gameObject, bool option)
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(option);
        }
    }
}