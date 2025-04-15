using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    public string Name;

    public virtual void TriggerInteraction()
    {
        Debug.Log(Name + " interaction trigger");
        onInteract.Invoke();

    }

    public UnityEvent onInteract;
}
