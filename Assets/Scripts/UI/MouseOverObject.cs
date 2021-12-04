using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MouseOverObject : MonoBehaviour
{
    [SerializeField] private GameObject hoverLabel;
    [SerializeField] private string hoverMessage;
    [SerializeField] private Dialog dialog;
    [SerializeField] private string dialogMessage;
    
    public void OnMouseDown()
    {
        dialog.ChangeText(dialogMessage);
    }
    void OnMouseEnter()
    {
        hoverLabel.GetComponent<Text>().text = hoverMessage;
        Cursor.visible = false;
        hoverLabel.SetActive(true);
    }

    void OnMouseOver()
    {
        hoverLabel.transform.position = Input.mousePosition;
    }
    void OnMouseExit()
    {
        Cursor.visible = true;
        hoverLabel.SetActive(false);
    }

    
}
