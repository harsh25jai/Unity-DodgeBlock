using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slower = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EndGame()
    {
        Debug.Log("GameOver");
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slower;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slower;

        yield return new WaitForSeconds(1f / slower);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slower;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
