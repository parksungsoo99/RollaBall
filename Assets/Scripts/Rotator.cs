using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        // 컴퓨터의 성능과 상관없이 프레임 오차를 줄여줌
        // 15, 30, 45으로 회전하라
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
