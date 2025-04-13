using UnityEngine;
using TMPro;

public class CounterIncrease : MonoBehaviour
{
    public TextMeshProUGUI CounterText;
    int counter;
    public void ButtonPressed()
    {
        counter++;
        CounterText.text = "Counter: " + counter;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
