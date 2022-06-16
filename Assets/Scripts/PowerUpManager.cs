using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea;

    public int maxPowerUpAmount;

    public List<GameObject> powerUpTemplateList;
    private List<GameObject> powerUpList;
    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;

    private float timer;
    public int spamInterval;

    private void Start(){
        powerUpList = new List<GameObject>();
    }

    private void Update(){
        timer += Time.deltaTime;

        if(powerUpList.Count == maxPowerUpAmount && timer > spamInterval){
            RemovePowerUp(powerUpList[0]);
        }

        if(timer > spamInterval){
            GenerateRandomPowerUp();
            timer -= spamInterval;
        }
        
    }

    public void GenerateRandomPowerUp(){
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position){
        // Debug.Log("Test");

        if(powerUpList.Count >= maxPowerUpAmount){
            return;
        }

        if(position.x < powerUpAreaMin.x || 
            position.x > powerUpAreaMax.x || 
            position.y < powerUpAreaMin.y ||
            position.y > powerUpAreaMax.y){
                // Debug.Log("Test");
                return;
            }

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp){
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp(){
        while(powerUpList.Count > 0){
            RemovePowerUp(powerUpList[0]);
        }
    }
}
