using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted = 0;

    private void Start ()
    {
        _plantCountUI.UpdateSeeds(_numSeeds, _numSeedsPlanted);
    }

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.up * _speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * _speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.down * _speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * _speed * Time.deltaTime;
        }

        if (Input.GetKeyDown("space"))
        {
            if (_numSeeds > 0)
            {
                PlantSeed();
            }
        }
    }

    public void PlantSeed ()
    {
        Debug.Log("trying to plant");
        _numSeeds -= 1;
        _numSeedsPlanted += 1;
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        _plantCountUI.UpdateSeeds(_numSeeds, _numSeedsPlanted);
    }
}
