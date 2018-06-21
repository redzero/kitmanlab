using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


        /// <summary>
        /// action drag with DragHandler
        /// </summary>
[RequireComponent(typeof(Image))]
public class DraggBtn : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

    public static GameObject playerBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public Transform parentFather;
    public GameObject scrollRect;


    void Start()
    {
        //parentFather = transform.parent;
        scrollRect = GameObject.Find("Panel1");
        //this.gameObject.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        playerBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
       
        //scrollRect.GetComponent<ScrollRect>().enabled = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        this.transform.parent = scrollRect.transform.parent;

    }


    public void OnEndDrag(PointerEventData eventData)
    {
        playerBeingDragged = null;
     GetComponent<CanvasGroup>().blocksRaycasts = true;
        //if (transform.parent != startParent){
        //    transform.position = startPosition;
        //}
        
    }
}
