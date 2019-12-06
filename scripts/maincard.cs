using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincard : MonoBehaviour
{
    [SerializeField] private GameObject Card_back;
    public void OnMouseDown()
    {
        if (Card_back.activeSelf)
        {
            Card_back.SetActive(false);
        }else
        {
            Card_back.SetActive(true);
        }
    }
}
