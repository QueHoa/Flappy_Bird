using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public float moveSpeed;//tốc độ của game
    public float oldPosition;//vị trí ban đấu
    public float minY;
    public float maxY;

    private GameObject obj;//Object hiện tại đang sử dụng
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
        //Translate dịch chuyển thêm 1 đoạn vector như trên

    }
    public void OnTriggerEnter2D(Collider2D other)//reset lại tường 
    {
        if (other.gameObject.tag.Equals("ResetWall"))//nếu chim đụng vào tag resetwall mới có tác dụng
            obj.transform.position = new Vector3(oldPosition, Random.Range(minY, maxY), 0);
    }
}
