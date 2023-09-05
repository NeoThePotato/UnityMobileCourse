using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceLoader : MonoBehaviour
{
    [SerializeField] private string _prefabNameToLoad;
    private GameObject _prefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            SpawnObject();
    }

	private void SpawnObject()
	{
        _prefab = _prefab ?? Resources.Load<GameObject>(_prefabNameToLoad);
        Instantiate(_prefab, transform);
	}
}
