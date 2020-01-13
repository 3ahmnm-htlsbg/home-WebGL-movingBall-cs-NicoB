using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
	[SerializeField]  private GameObject[] ballPositions; 

	public GameObject BallGO;

	int randomInt;
	int randomIntBefore;

	public void SetBallPos()
	{
		randomInt = Random.Range(0 ,4);
		if (randomInt != randomIntBefore)
		{
			randomIntBefore = randomInt;
			BallGO.transform.position = ballPositions[randomInt].transform.position;
		} else 
		{
			SetBallPos();
		}
	}
}