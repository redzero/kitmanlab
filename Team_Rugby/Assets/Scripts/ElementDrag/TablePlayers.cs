using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


        /// <summary>
        /// place to place the players
        /// </summary>
public class TablePlayers : MonoBehaviour, IDropHandler
{

    public GameObject player{

        get{
            if(transform. childCount>0){
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(!player){
           // DraggBtn.playerBeingDragged.transform.SetParent(transform);
        }
    }

   
}
