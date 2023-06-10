using UnityEngine;

public class FridgeTest : MonoBehaviour
{
    [SerializeField] private GameObject _noticeTemplate;
    [SerializeField] private Transform _fridgeRoot;
    [SerializeField] private int _noticeCount = 20;
    
    private void Start()
    {
        for (int i = 0; i < _noticeCount; i++)
        {
            CreateNotice();
        }
    }

    private void CreateNotice()
    {
        GameObject notice = Instantiate(_noticeTemplate, _fridgeRoot);
    }
}
