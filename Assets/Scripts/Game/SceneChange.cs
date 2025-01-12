using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    [SerializeField] private GameObject map;
    GameManager gameManager;
    private void Awake()
    {
        gameManager = GetComponent<GameManager>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            map.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Escape)) 
        {
            map.SetActive(false);
        }

    }
    public void MinaSokak()
    {
        SceneManager.LoadScene(2);
        map.SetActive(false);
    }
    public void UygarSokak()
    {
        SceneManager.LoadScene(3);
        map.SetActive(false);
    }

    public void KarakolFinal()
    {
        SceneManager.LoadScene(4);
    }
}
