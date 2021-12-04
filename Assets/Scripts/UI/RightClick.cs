using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RightClick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]private Dialog dialog;
    [SerializeField] private string message;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right)
        {
            dialog.ChangeText(message);
        }
    }
}
