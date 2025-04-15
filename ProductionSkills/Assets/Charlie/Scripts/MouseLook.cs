using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public static MouseLook Instance;
    public float mouseSensitivity = 200f;
    public Transform playerBody;
    public int lookDistance;

    public static GameObject currentFocus;

    float xRotation = 0f;

    private void Start()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 120;

    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        LookCheck();

        if(Input.GetKeyDown(KeyCode.E))
        {
            if(currentFocus != null)
            {
                Interactable interactable = currentFocus.GetComponent<Interactable>();

                if(interactable != null)
                {
                    interactable.TriggerInteraction();
                }
            }
        }
    }

    private void LookCheck()
    {
        currentFocus = null;

        RaycastHit hit;
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, lookDistance))
        {
            if (hit.transform.GetComponent<Interactable>() != null)
            {
                currentFocus = hit.transform.gameObject;
            }
            else
            {
                currentFocus = null;
            }
        }
    }

}
