using UnityEngine;

public class EventTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Debug.Log("Awake 실행");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable 실행");
    }

    private void Start()
    {
        Debug.Log("Start실행");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate 실행");
    }
    private void Update()
    {
        Debug.Log("Update 실행");
    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate 실행");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable 실행");
    }
}
