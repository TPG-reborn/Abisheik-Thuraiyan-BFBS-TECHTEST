using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSystems : MonoBehaviour
{

    public GameObject winUI;
    public GameObject loseUI;

    public GameObject pointsText;
    public GameObject hpText;

    public GameObject r_fish;
    public GameObject b_fish;
    public GameObject p_fish;

    Vector3 finalPos;

    Vector3 randomPos1 = new Vector3(216f, 218.4f, 0f);
    Vector3 randomPos2 = new Vector3(258.9f, 218.4f, 0f);
    Vector3 randomPos3 = new Vector3(300f, 218.4f, 0f);

    int newPos = 0;

    int playerPoints = 0;
    int playerHealth = 4;

    void newFishPos()
    {
        newPos = UnityEngine.Random.Range(1, 3);

        if (newPos == 1)
        {
            finalPos = randomPos1;
        }

        if (newPos == 2)
        {
            finalPos = randomPos2;
        }

        if (newPos == 3)
        {
            finalPos = randomPos3;
        }
    }

    private void OnCollisionEnter2D(Collision2D fish)
    {
        if (fish.gameObject.name == "pFish")
        {
            Debug.Log("Fish hit");
            playerPoints += 1;
            newFishPos();
            p_fish.transform.position = finalPos;
            pointsText.GetComponent<UnityEngine.UI.Text>().text = "Points: " + playerPoints;
        }

        if (fish.gameObject.name == "rFish")
        {
            Debug.Log("bad fish");
            playerPoints -= 1;
            playerHealth -= 1;
            newFishPos();
            r_fish.transform.position = finalPos;
            pointsText.GetComponent<UnityEngine.UI.Text>().text = "Points: " + playerPoints;
            hpText.GetComponent<UnityEngine.UI.Text>().text = "Health: " + playerHealth;
        }

        if (fish.gameObject.name == "bFish")
        {
            Debug.Log("blue fish");
            playerPoints += 2;
            newFishPos();
            b_fish.transform.position = finalPos;
            pointsText.GetComponent<UnityEngine.UI.Text>().text = "Points: " + playerPoints;
        }
    }

    void Update()
    {
        if (playerPoints >= 10)
        {
            Debug.Log("test");
            winUI.SetActive(true);
        }

        if (playerHealth <= 0)
        {
            Debug.Log("lose");
            loseUI.SetActive(true);
        }
    }
}
