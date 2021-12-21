using UnityEngine;

public class GetDamage : MonoBehaviour
{
    public string selfTag;
    public string[] tagName;
    public float damage = 50f;

    void OnTriggerEnter(Collider col)
    {
        foreach (string tag in tagName)
        {
            if(col.tag != selfTag && col.tag == tag)
            {
                this.gameObject.SendMessageUpwards("ReceiveDamage", damage);
            }
        }      
     }
}
