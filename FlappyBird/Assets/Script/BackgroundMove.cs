using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float moveSpeed;//tốc độ của game
    public float moveRange;//Khoảng cách

    private Vector3 oldPosition;//Địa chỉ ban đầu
    private GameObject obj;//Object hiện tại đang sử dụng
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
        //Translate dịch chuyển thêm 1 đoạn vector như trên

        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)//Distance dùng để đo khoảng cách 
        {
            obj.transform.position = oldPosition;
        }
    }

}
