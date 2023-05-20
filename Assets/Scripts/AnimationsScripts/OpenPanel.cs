using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    private void Start()
    {
        transform.localScale = Vector2.zero;
    }
    public void Open()
    {
        transform.LeanScale(Vector2.one, 0.5f).setEaseInOutExpo();

    }
    public void Close()
    {
        transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
    }
}
