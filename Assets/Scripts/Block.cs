using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float minHeight;         // 隙間高さの範囲(最小)
    public float maxHeight;         // 隙間高さの範囲(最高)
    public GameObject root;         // Rootオブジェクト

    // Start is called before the first frame update
    void Start()
    {
        // 隙間の初期化
        // 開始時に隙間の高さを変更
        ChargeHeight();
    }

    // 高さの変更
    void ChargeHeight()
    {
       // ランダムな高さを生成して設定
        float height = Random.Range(minHeight, maxHeight);
        root.transform.localPosition = new Vector3(0.0f, height, 0.0f);
    }

    // ScrollObjectスクリプトからのメッセージを受け取って高さを変更
    void OnScrollEnd()
    {
        // スクロール完了時の隙間の再設定
        ChargeHeight();
    }
}
