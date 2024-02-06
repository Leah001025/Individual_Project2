using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEvents : MonoBehaviour
{
    bool TabChk = false;
    public void OnClickInventoryEvent()
    {
        RectTransform rectTran = gameObject.GetComponent<RectTransform>();
        GameObject obj = GameObject.Find("Inventory");
        Vector3 position = obj.transform.localPosition;
        if (TabChk == false)
        {
            position.x = 0;
            obj.transform.localPosition = position;
            TabChk = true;
        }
        else
        {
            position.x = 390;
            obj.transform.localPosition = position;
            TabChk = false;
        }
    }

    public void OnClickStatEvent()
    {
        RectTransform rectTran = gameObject.GetComponent<RectTransform>();
        GameObject obj = GameObject.Find("Status");
        Vector3 position = obj.transform.localPosition;
        if (TabChk == false)
        {
            position.x = -200;
            obj.transform.localPosition = position;
            TabChk = true;
        }
        else
        {
            position.x = -390;
            obj.transform.localPosition = position;
            TabChk = false;
        }
    }
}
