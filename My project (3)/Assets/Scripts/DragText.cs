using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool isDragging;
    private Vector3 offset;
    private bool isMouseOver;
    static GameObject me;
    static GameObject last;

    void Update()
    {
        if (isMouseOver && Input.GetMouseButton(0) && !isDragging && me == this.gameObject) // Se activa solo cuando el mouse está sobre el objeto y se hace clic
        {
            last = me;
            isDragging = true;
            offset = transform.position - GetMouseWorldPosition();
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (me == null)
        {
            isMouseOver = true;
            me = this.gameObject;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!isDragging)
        {
            isMouseOver = false;
            me = null;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        return mousePos;
    }

    public void Destruir()
    {
        Destroy(last);
    }
}
