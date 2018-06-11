using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start() {

	}
	
	// Update is called once per frame
	void Update() {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //[課題向け] キューブオブジェクトがどこかに衝突したら音を鳴らす。
    private void OnCollisionEnter2D(Collision2D other)
    {
        // UnityChan以外が衝突したら音を鳴らす。
        if (other.gameObject.tag != "UnityChanTag")
        {
            GetComponent<AudioSource>().Play();
        }
        else // for debug
        {
            Debug.Log("Hit UnityChan! (No Sound)");
        }
    }
}
