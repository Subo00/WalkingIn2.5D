using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    [SerializeField] private GameObject textLabel;
    [SerializeField] private float textTime;
    private float currentTime = 0f;

    void Start()
    {
        ChangeText("Hello World");
    }

    void Update() //follows the player
    {
        Vector2 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        textLabel.transform.position = namePos;
        if(currentTime > 0f)
        {
            currentTime -= 1 * Time.deltaTime;
        }
        else
        {
            textLabel.SetActive(false);
        }
    }

    public void ChangeText(string text)
    {
        textLabel.SetActive(true);
        currentTime = textTime;
        textLabel.GetComponent<Text>().text = text;
    }
}
