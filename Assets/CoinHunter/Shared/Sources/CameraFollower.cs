using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private Transform _targetTransform;

    private const float _z = -10f;

    public void Initialize(Transform player)
    {
        _targetTransform = player;
    }

    void Update()
    {
        if (_targetTransform == null)
            return;
        
        Vector3 difference = _targetTransform.position - transform.position;
        Vector3 movement = _speed * difference * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + movement.x,
            transform.position.y + movement.y, _z);
    }
}
