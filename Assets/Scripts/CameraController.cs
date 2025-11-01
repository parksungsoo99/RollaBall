using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        // 플레이어를 기준으로 카메라가 어디있어야 하는지 알려주는 코드
        // offset = 카메라의 초기 위치 - 플레이어의 초기 위치
        offset = transform.position - player.transform.position;
    }

    // LateUpdate는 Update메서드(플레이어의 이동이처리된 후) 후 실행하므로
    // 카메라가 플레이어의 최종 위치를 기반으로 움직임
    private void LateUpdate()
    {
        // 카메라의 새로운 위치 = 플레이어의 새로운 위치 + offset
        transform.position = player.transform.position + offset;
    }

    void Update()
    {
        
    }
}
