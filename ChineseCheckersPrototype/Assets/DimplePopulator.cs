using UnityEngine;
using System.Collections;

public class DimplePopulator : MonoBehaviour 
{
	public GameObject BallObject;
	public GameObject DimpleObject;
	public int gamestate = 0; 




	GameObject redBallObjectOne;
	GameObject blueBallObjectOne;

	Dimple firstup;
	Dimple firstdown;

	Dimple secondup1;
	Dimple secondup2;
	Dimple seconddown1;
	Dimple seconddown2;


	Dimple tup1;
	Dimple tup2;
	Dimple tup3;
	Dimple tup4;
	Dimple tup5;
	Dimple tup6;
	Dimple tup7;
	Dimple tdown1;
	Dimple tdown2;
	Dimple tdown3;
	Dimple tdown4;
	Dimple tdown5;
	Dimple tdown6;
	Dimple tdown7;



	Dimple fourup1;
	Dimple fourup2;
	Dimple fourup3;
	Dimple fourup4;
	Dimple fourup5;
	Dimple fourup6;
	Dimple fourdown1;
	Dimple fourdown2;
	Dimple fourdown3;
	Dimple fourdown4;
	Dimple fourdown5;
	Dimple fourdown6;


	Dimple middle1;
	Dimple middle2;
	Dimple middle4;
	Dimple middle3;
	Dimple middle5;


//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;
//	Dimple noneDimpleOne;

	bool debug = false;
	int timer;

	void Start () 
	{
		timer = 0;
//		switch (gamestate) {
//		case 0:drawopening();
//		case 1:drawboard ();
//		case 2:drawGameover();
//				}
		drawboard ();

	}

//	void drawopening(){
//
//		}
//	void drawGameover(){
//		}
	void drawboard(){
		//Setup dimples and balls
		Vector3 centerPosition = gameObject.transform.position;
		
		
		Vector3 middl1 =    centerPosition + new Vector3(-1f, .05f, 0f);
		Vector3 middl2 =    centerPosition + new Vector3(-.5f, .05f, 0f);
		Vector3 middl3 = 	centerPosition + new Vector3(	 0, .05f, 0f);
		Vector3 middl4 =  centerPosition + new Vector3(.5f, .05f, 0f);
		Vector3 middl5 =   centerPosition + new Vector3(1f, .05f, 0f);
		
		Vector3 firstu5 = centerPosition + new Vector3 (1.25f, .05f, .43f);
		Vector3 firstu4 =    centerPosition + new Vector3(.75f, .05f, .43f);
		Vector3 firstu3 =  centerPosition + new Vector3(.25f, .05f, .43f);
		Vector3 firstu2 =    centerPosition + new Vector3(-.25f, .05f, .43f);
		Vector3 firstu1 =  centerPosition + new Vector3(-.75f, .05f, .43f);
		Vector3 firstu0 =    centerPosition + new Vector3(-1.25f, .05f, .43f);
		
		Vector3 firstdow5 =    centerPosition + new Vector3(1.25f, .05f, -.43f);
		Vector3 firstdow4 =    centerPosition + new Vector3(.75f, .05f, -.43f);
		Vector3 firstdow3 =  centerPosition + new Vector3(.25f, .05f, -.43f);
		Vector3 firstdow2 =    centerPosition + new Vector3(-.25f, .05f, -.43f);
		Vector3 firstdow1 =  centerPosition + new Vector3(-.75f, .05f, -.43f);
		Vector3 firstdow0 =    centerPosition + new Vector3(-1.25f, .05f, -.43f);
		
		Vector3 secondu00 = 	centerPosition + new Vector3(-1.5f, .05f, .875f);
		Vector3 secondu0 = 	centerPosition + new Vector3(	 -1f, .05f, .875f);
		Vector3 secondu1 = 	centerPosition + new Vector3(-.5f, .05f, .875f);
		Vector3 secondu2 = 	centerPosition + new Vector3(	 0, .05f, .875f);
		Vector3 secondu3 = 	centerPosition + new Vector3( .5f, .05f, .875f);
		Vector3 secondu4 = 	centerPosition + new Vector3(1f, .05f, .875f);
		Vector3 secondu5 = 	centerPosition + new Vector3(1.5f, .05f, .875f);
		
		Vector3 seconddow00 = 	centerPosition + new Vector3(-1.5f, .05f, -.875f);
		Vector3 seconddow0 = 	centerPosition + new Vector3(	 -1f, .05f, -.875f);
		Vector3 seconddow1 = 	centerPosition + new Vector3(-.5f, .05f, -.875f);
		Vector3 seconddow2 = 	centerPosition + new Vector3(	 0, .05f, -.875f);
		Vector3 seconddow3 = 	centerPosition + new Vector3( .5f, .05f, -.875f);
		Vector3 seconddow4 = 	centerPosition + new Vector3(1f, .05f, -.875f);
		Vector3 seconddow5 = 	centerPosition + new Vector3(	1.5f, .05f, -.875f);
		
		Vector3 Tu1 =    centerPosition + new Vector3(-.25f, .05f, 1.31f);
		Vector3 Tu2 =  centerPosition + new Vector3(.25f, .05f, 1.31f);
		
		Vector3 TDOWN1 =    centerPosition + new Vector3(-.25f, .05f, -1.31f);
		Vector3 TDOWN2 =  centerPosition + new Vector3(.25f, .05f, -1.31f);
		
		Vector3 fup1 = 	centerPosition + new Vector3(	 0, .05f, 1.735f);
		
		Vector3 fdown1 = 	centerPosition + new Vector3(	 0, .05f, -1.735f);
		
		//		Vector3 noneTwoPos1 =    centerPosition + new Vector3(-.25f, .05f, .7f);
		//		Vector3 noneThreePos2 =  centerPosition + new Vector3(.25f, .05f, .7f);
		//
		//		Vector3 redOnePos = 	centerPosition + new Vector3(-.5f, .05f, .35f);
		//		Vector3 redTwoPos = 	centerPosition + new Vector3(	 0, .05f, .35f);
		//		Vector3 redThreePos = 	centerPosition + new Vector3( .5f, .05f, .35f);
		//
		//
		//		
		//		Vector3 blueOnePos = 	centerPosition + new Vector3(-.5f, .05f, -.35f);
		//		Vector3 blueTwoPos = 	centerPosition + new Vector3(	 0, .05f, -.35f);
		//		Vector3 blueThreePos = 	centerPosition + new Vector3( .5f, .05f, -.35f);
		//
		//		Vector3 noneTwoPos3 =    centerPosition + new Vector3(-.25f, .05f, -.7f);
		//		Vector3 noneThreePos4 =  centerPosition + new Vector3(.25f, .05f, -.7f);
		//		Vector3 redTwoPos6 = 	centerPosition + new Vector3(	 0, .05f, -1.05f);
		
		middle1 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		middle1.HomeColor = TeamColor.NONE;
		middle1.Position = middl1;
		middle2 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		middle2.HomeColor = TeamColor.NONE;
		middle2.Position = middl2;
		middle3 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		middle3.HomeColor = TeamColor.NONE;
		middle3.Position = middl3;
		middle4 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		middle4.HomeColor = TeamColor.NONE;
		middle4.Position = middl4;
		middle5 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		middle5.HomeColor = TeamColor.NONE;
		middle5.Position = middl5;
		
		
		
		
		fourup2 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourup2.HomeColor = TeamColor.NONE;
		fourup2.Position = firstu1;
		fourup3 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourup3.HomeColor = TeamColor.NONE;
		fourup3.Position = firstu2;
		fourup4 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourup4.HomeColor = TeamColor.NONE;
		fourup4.Position = firstu3;
		fourup5 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourup5.HomeColor = TeamColor.NONE;
		fourup5.Position = firstu4;
		fourup6 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourup6.HomeColor = TeamColor.NONE;
		fourup6.Position = firstu5;
		fourup1 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourup1.HomeColor = TeamColor.NONE;
		fourup1.Position = firstu0;
		
		fourdown2 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourdown2.HomeColor = TeamColor.NONE;
		fourdown2.Position = firstdow1;
		fourdown3 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourdown3.HomeColor = TeamColor.NONE;
		fourdown3.Position = firstdow2;
		fourdown4 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourdown4.HomeColor = TeamColor.NONE;
		fourdown4.Position = firstdow3;
		fourdown5 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourdown5.HomeColor = TeamColor.NONE;
		fourdown5.Position = firstdow4;
		fourdown6 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourdown6.HomeColor = TeamColor.NONE;
		fourdown6.Position = firstdow5;
		fourdown1 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		fourdown1.HomeColor = TeamColor.NONE;
		fourdown1.Position = firstdow0;
		
		tup3 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tup3.HomeColor = TeamColor.NONE;
		tup3.Position = secondu1;
		tup4 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tup4.HomeColor = TeamColor.NONE;
		tup4.Position = secondu2;
		tup5 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tup5.HomeColor = TeamColor.NONE;
		tup5.Position = secondu3;
		tup1 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tup1.HomeColor = TeamColor.RED;
		tup1.Position = secondu00;
		tup2 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tup2.HomeColor = TeamColor.NONE;
		tup2.Position = secondu0;
		tup6 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tup6.HomeColor = TeamColor.NONE;
		tup6.Position = secondu4;
		tup7 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tup7.HomeColor = TeamColor.RED;
		tup7.Position = secondu5;
		
		tdown3 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tdown3.HomeColor = TeamColor.NONE;
		tdown3.Position = seconddow1;
		tdown4 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tdown4.HomeColor = TeamColor.NONE;
		tdown4.Position = seconddow2;
		tdown5 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tdown5.HomeColor = TeamColor.NONE;
		tdown5.Position = seconddow3;
		tdown2 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tdown2.HomeColor = TeamColor.NONE;
		tdown2.Position = seconddow0;
		tdown1 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tdown1.HomeColor = TeamColor.BLUE;
		tdown1.Position = seconddow00;
		tdown6 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tdown6.HomeColor = TeamColor.NONE;
		tdown6.Position = seconddow4;
		tdown7 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		tdown7.HomeColor = TeamColor.BLUE;
		tdown7.Position = seconddow5;
		
		
		secondup1 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		secondup1.HomeColor = TeamColor.NONE;
		secondup1.Position = Tu1;
		secondup2 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		secondup2.HomeColor = TeamColor.NONE;
		secondup2.Position = Tu2;
		
		seconddown1 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		seconddown1.HomeColor = TeamColor.NONE;
		seconddown1.Position = TDOWN1;
		seconddown2 = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		seconddown2.HomeColor = TeamColor.NONE;
		seconddown2.Position = TDOWN2;
		
		firstup = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		firstup.HomeColor = TeamColor.BLUE;
		firstup.Position = fup1;
		
		
		firstdown = (GameObject.Instantiate(DimpleObject) as GameObject).AddComponent<Dimple>();
		firstdown.HomeColor = TeamColor.RED;
		firstdown.Position = fdown1;
		
		//Create ball game objects
		redBallObjectOne = GameObject.Instantiate(BallObject) as GameObject;
		blueBallObjectOne = GameObject.Instantiate(BallObject) as GameObject;
		
		redBallObjectOne.AddComponent<Ball>();
		blueBallObjectOne.AddComponent<Ball>();
		
		redBallObjectOne.GetComponent<Ball>().BallColor = TeamColor.RED;
		blueBallObjectOne.GetComponent<Ball>().BallColor = TeamColor.BLUE;
		
		redBallObjectOne.transform.position = firstu4;
		blueBallObjectOne.transform.position = fup1;
		
		//		redDimpleTwo.toggleOccupied();
		//		blueDimpleTwo.toggleOccupied();
		
		fourup5.toggleOccupied();
		firstup.toggleOccupied();
		
		redBallObjectOne.GetComponent<Ball>().CurrentDimple = fourup5;
		blueBallObjectOne.GetComponent<Ball>().CurrentDimple = firstup;
		
		//		redBallObjectOne.GetComponent<Ball>().CurrentDimple = blueDimpleTwo;
		//		blueBallObjectOne.GetComponent<Ball>().CurrentDimple = redDimpleTwo;
		
		/*neighbor population*/
		//firstup.AddNeighboringDimple(new Neighbor(redDimpleTwo, Direction.RIGHT));
		firstup.AddNeighboringDimple(new Neighbor(secondup1, Direction.DOWN_LEFT));
		firstup.AddNeighboringDimple(new Neighbor(secondup2, Direction.DOWN_RIGHT));
		
		firstdown.AddNeighboringDimple(new Neighbor(seconddown1, Direction.UP_LEFT));
		firstdown.AddNeighboringDimple(new Neighbor(seconddown2, Direction.UP_RIGHT));
		
		tdown1.AddNeighboringDimple(new Neighbor(fourdown1, Direction.UP_RIGHT));
		tdown1.AddNeighboringDimple(new Neighbor(tdown2, Direction.RIGHT));
		
		tdown7.AddNeighboringDimple(new Neighbor(fourdown6, Direction.UP_LEFT));
		tdown7.AddNeighboringDimple(new Neighbor(tdown6, Direction.LEFT));
		
		tup1.AddNeighboringDimple(new Neighbor(fourup1, Direction.DOWN_RIGHT));
		tup1.AddNeighboringDimple(new Neighbor(tup2, Direction.RIGHT));
		
		tup7.AddNeighboringDimple(new Neighbor(fourup6, Direction.DOWN_LEFT));
		tup7.AddNeighboringDimple(new Neighbor(tup6, Direction.LEFT));
		
		
		
		//		//redDimpleTwo.AddNeighboringDimple(new Neighbor(redDimpleOne, Direction.LEFT));
		tdown2.AddNeighboringDimple(new Neighbor(tdown3, Direction.RIGHT));
		tdown2.AddNeighboringDimple(new Neighbor(fourdown1, Direction.UP_LEFT));
		tdown2.AddNeighboringDimple(new Neighbor(fourdown2, Direction.UP_RIGHT));
		fourdown1.AddNeighboringDimple(new Neighbor(fourdown2, Direction.RIGHT));
		fourdown1.AddNeighboringDimple(new Neighbor(tdown2, Direction.DOWN_RIGHT));
		fourdown1.AddNeighboringDimple(new Neighbor(middle1, Direction.UP_RIGHT));
		tdown2.AddNeighboringDimple(new Neighbor(tdown1, Direction.LEFT));
		fourdown1.AddNeighboringDimple(new Neighbor(tdown1, Direction.DOWN_LEFT));
		
		tdown6.AddNeighboringDimple(new Neighbor(tdown7, Direction.RIGHT));
		tdown6.AddNeighboringDimple(new Neighbor(fourdown6, Direction.UP_RIGHT));
		tdown6.AddNeighboringDimple(new Neighbor(fourdown5, Direction.UP_LEFT));
		fourdown6.AddNeighboringDimple(new Neighbor(fourdown5, Direction.LEFT));
		fourdown6.AddNeighboringDimple(new Neighbor(tdown6, Direction.DOWN_LEFT));
		fourdown6.AddNeighboringDimple(new Neighbor(tdown7, Direction.DOWN_RIGHT));
		tdown6.AddNeighboringDimple(new Neighbor(tdown7, Direction.RIGHT));
		fourdown6.AddNeighboringDimple(new Neighbor(tdown7, Direction.DOWN_RIGHT));
		
		tup2.AddNeighboringDimple(new Neighbor(tup3, Direction.RIGHT));
		tup2.AddNeighboringDimple(new Neighbor(fourup1, Direction.DOWN_LEFT));
		tup2.AddNeighboringDimple(new Neighbor(fourup2, Direction.DOWN_RIGHT));
		fourup1.AddNeighboringDimple(new Neighbor(fourup2, Direction.RIGHT));
		fourup1.AddNeighboringDimple(new Neighbor(tup2, Direction.UP_RIGHT));
		fourup1.AddNeighboringDimple(new Neighbor(middle1, Direction.DOWN_RIGHT));
		tup2.AddNeighboringDimple(new Neighbor(tup1, Direction.LEFT));
		fourup1.AddNeighboringDimple(new Neighbor(tup1, Direction.UP_LEFT));
		
		tup6.AddNeighboringDimple(new Neighbor(tup5, Direction.LEFT));
		tup6.AddNeighboringDimple(new Neighbor(fourup5, Direction.DOWN_LEFT));
		tup6.AddNeighboringDimple(new Neighbor(fourup6, Direction.DOWN_RIGHT));
		fourup6.AddNeighboringDimple(new Neighbor(fourup5, Direction.LEFT));
		fourup6.AddNeighboringDimple(new Neighbor(tup6, Direction.UP_LEFT));
		fourup6.AddNeighboringDimple(new Neighbor(middle5, Direction.DOWN_LEFT));
		tup6.AddNeighboringDimple(new Neighbor(tup7, Direction.RIGHT));
		fourup6.AddNeighboringDimple(new Neighbor(tup7, Direction.UP_RIGHT));
		
		secondup1.AddNeighboringDimple(new Neighbor(secondup2, Direction.RIGHT));
		secondup1.AddNeighboringDimple(new Neighbor(tup4, Direction.DOWN_RIGHT));
		secondup1.AddNeighboringDimple(new Neighbor(tup3, Direction.DOWN_LEFT));
		secondup2.AddNeighboringDimple(new Neighbor(secondup1, Direction.LEFT));
		secondup2.AddNeighboringDimple(new Neighbor(tup5, Direction.DOWN_RIGHT));
		secondup2.AddNeighboringDimple(new Neighbor(tup4, Direction.DOWN_LEFT));
		secondup1.AddNeighboringDimple(new Neighbor(firstup, Direction.UP_RIGHT));
		secondup2.AddNeighboringDimple(new Neighbor(firstup, Direction.UP_LEFT));
		
		seconddown1.AddNeighboringDimple(new Neighbor(seconddown2, Direction.RIGHT));
		seconddown1.AddNeighboringDimple(new Neighbor(tdown4, Direction.UP_RIGHT));
		seconddown1.AddNeighboringDimple(new Neighbor(tdown3, Direction.UP_LEFT));
		seconddown2.AddNeighboringDimple(new Neighbor(seconddown1, Direction.LEFT));
		seconddown2.AddNeighboringDimple(new Neighbor(tdown5, Direction.UP_RIGHT));
		seconddown2.AddNeighboringDimple(new Neighbor(tdown4, Direction.UP_LEFT));
		seconddown1.AddNeighboringDimple(new Neighbor(firstdown, Direction.DOWN_RIGHT));
		seconddown2.AddNeighboringDimple(new Neighbor(firstdown, Direction.DOWN_LEFT));
		
		//third class
		tup3.AddNeighboringDimple(new Neighbor(tup2, Direction.LEFT));
		tup3.AddNeighboringDimple(new Neighbor(tup4, Direction.RIGHT));
		tup3.AddNeighboringDimple(new Neighbor(fourup3, Direction.DOWN_RIGHT));
		tup3.AddNeighboringDimple(new Neighbor(fourup2, Direction.DOWN_LEFT));
		tup3.AddNeighboringDimple(new Neighbor(secondup1, Direction.UP_RIGHT));
		
		tup5.AddNeighboringDimple(new Neighbor(tup4, Direction.LEFT));
		tup5.AddNeighboringDimple(new Neighbor(tup6, Direction.RIGHT));
		tup5.AddNeighboringDimple(new Neighbor(fourup4, Direction.DOWN_LEFT));
		tup5.AddNeighboringDimple(new Neighbor(fourup5, Direction.DOWN_RIGHT));
		tup5.AddNeighboringDimple (new Neighbor (secondup2, Direction.UP_LEFT));
		
		middle5.AddNeighboringDimple(new Neighbor(middle4, Direction.LEFT));
		middle5.AddNeighboringDimple(new Neighbor(fourup5, Direction.UP_LEFT));
		middle5.AddNeighboringDimple(new Neighbor(fourup6, Direction.UP_RIGHT));
		middle5.AddNeighboringDimple(new Neighbor(fourdown5, Direction.DOWN_LEFT));
		middle5.AddNeighboringDimple (new Neighbor (fourdown6, Direction.DOWN_RIGHT));
		
		middle1.AddNeighboringDimple(new Neighbor(middle2, Direction.RIGHT));
		middle1.AddNeighboringDimple(new Neighbor(fourup1, Direction.UP_LEFT));
		middle1.AddNeighboringDimple(new Neighbor(fourup2, Direction.UP_RIGHT));
		middle1.AddNeighboringDimple(new Neighbor(fourdown1, Direction.DOWN_LEFT));
		middle1.AddNeighboringDimple (new Neighbor (fourdown2, Direction.DOWN_RIGHT));
		
		tdown3.AddNeighboringDimple(new Neighbor(tdown2, Direction.LEFT));
		tdown3.AddNeighboringDimple(new Neighbor(tdown4, Direction.RIGHT));
		tdown3.AddNeighboringDimple(new Neighbor(fourdown2, Direction.UP_LEFT));
		tdown3.AddNeighboringDimple(new Neighbor(fourdown3, Direction.UP_RIGHT));
		tdown3.AddNeighboringDimple (new Neighbor (seconddown1, Direction.DOWN_RIGHT));
		
		tdown5.AddNeighboringDimple(new Neighbor(seconddown2, Direction.DOWN_LEFT));
		tdown5.AddNeighboringDimple(new Neighbor(tdown4, Direction.LEFT));
		tdown5.AddNeighboringDimple(new Neighbor(tdown6, Direction.RIGHT));
		tdown5.AddNeighboringDimple(new Neighbor(fourdown4, Direction.UP_LEFT));
		tdown5.AddNeighboringDimple (new Neighbor (fourdown5, Direction.UP_RIGHT));
		
		
		//FOURTH CLASS
		
		tup4.AddNeighboringDimple(new Neighbor(tup3, Direction.LEFT));
		tup4.AddNeighboringDimple(new Neighbor(tup5, Direction.RIGHT));
		tup4.AddNeighboringDimple(new Neighbor(secondup1, Direction.UP_LEFT));
		tup4.AddNeighboringDimple(new Neighbor(secondup2, Direction.UP_RIGHT));
		tup4.AddNeighboringDimple(new Neighbor(fourup3, Direction.DOWN_LEFT));
		tup4.AddNeighboringDimple(new Neighbor(fourup4, Direction.DOWN_RIGHT));
		
		tdown4.AddNeighboringDimple(new Neighbor(tdown3, Direction.LEFT));
		tdown4.AddNeighboringDimple(new Neighbor(tdown5, Direction.RIGHT));
		tdown4.AddNeighboringDimple(new Neighbor(fourdown3, Direction.UP_LEFT));
		tdown4.AddNeighboringDimple(new Neighbor(fourdown4, Direction.UP_RIGHT));
		tdown4.AddNeighboringDimple(new Neighbor(seconddown1, Direction.DOWN_LEFT));
		tdown4.AddNeighboringDimple(new Neighbor(seconddown2, Direction.DOWN_RIGHT));
		
		fourup2.AddNeighboringDimple(new Neighbor(fourup1, Direction.LEFT));
		fourup2.AddNeighboringDimple(new Neighbor(fourup3, Direction.RIGHT));
		fourup2.AddNeighboringDimple(new Neighbor(tup2, Direction.UP_LEFT));
		fourup2.AddNeighboringDimple(new Neighbor(tup3, Direction.UP_RIGHT));
		fourup2.AddNeighboringDimple(new Neighbor(middle1, Direction.DOWN_LEFT));
		fourup2.AddNeighboringDimple(new Neighbor(middle2, Direction.DOWN_RIGHT));
		
		fourup3.AddNeighboringDimple(new Neighbor(fourup2, Direction.LEFT));
		fourup3.AddNeighboringDimple(new Neighbor(fourup4, Direction.RIGHT));
		fourup3.AddNeighboringDimple(new Neighbor(tup3, Direction.UP_LEFT));
		fourup3.AddNeighboringDimple(new Neighbor(tup4, Direction.UP_RIGHT));
		fourup3.AddNeighboringDimple(new Neighbor(middle2, Direction.DOWN_LEFT));
		fourup3.AddNeighboringDimple(new Neighbor(middle3, Direction.DOWN_RIGHT));
		
		fourup4.AddNeighboringDimple(new Neighbor(fourup3, Direction.LEFT));
		fourup4.AddNeighboringDimple(new Neighbor(fourup5, Direction.RIGHT));
		fourup4.AddNeighboringDimple(new Neighbor(tup4, Direction.UP_LEFT));
		fourup4.AddNeighboringDimple(new Neighbor(tup5, Direction.UP_RIGHT));
		fourup4.AddNeighboringDimple(new Neighbor(middle3, Direction.DOWN_LEFT));
		fourup4.AddNeighboringDimple(new Neighbor(middle4, Direction.DOWN_RIGHT));
		
		fourup5.AddNeighboringDimple(new Neighbor(fourup4, Direction.LEFT));
		fourup5.AddNeighboringDimple(new Neighbor(fourup6, Direction.RIGHT));
		fourup5.AddNeighboringDimple(new Neighbor(tup5, Direction.UP_LEFT));
		fourup5.AddNeighboringDimple(new Neighbor(tup6, Direction.UP_RIGHT));
		fourup5.AddNeighboringDimple(new Neighbor(middle4, Direction.DOWN_LEFT));
		fourup5.AddNeighboringDimple(new Neighbor(middle5, Direction.DOWN_RIGHT));
		
		fourdown2.AddNeighboringDimple(new Neighbor(fourdown1, Direction.LEFT));
		fourdown2.AddNeighboringDimple(new Neighbor(fourdown3, Direction.RIGHT));
		fourdown2.AddNeighboringDimple(new Neighbor(tdown2, Direction.DOWN_LEFT));
		fourdown2.AddNeighboringDimple(new Neighbor(tdown3, Direction.DOWN_RIGHT));
		fourdown2.AddNeighboringDimple(new Neighbor(middle1, Direction.UP_LEFT));
		fourdown2.AddNeighboringDimple(new Neighbor(middle2, Direction.UP_RIGHT));
		
		fourdown3.AddNeighboringDimple(new Neighbor(fourdown2, Direction.LEFT));
		fourdown3.AddNeighboringDimple(new Neighbor(fourdown4, Direction.RIGHT));
		fourdown3.AddNeighboringDimple(new Neighbor(tdown4, Direction.DOWN_LEFT));
		fourdown3.AddNeighboringDimple(new Neighbor(tdown3, Direction.DOWN_RIGHT));
		fourdown3.AddNeighboringDimple(new Neighbor(middle2, Direction.UP_LEFT));
		fourdown3.AddNeighboringDimple(new Neighbor(middle3, Direction.UP_RIGHT));
		
		fourdown4.AddNeighboringDimple(new Neighbor(fourdown3, Direction.LEFT));
		fourdown4.AddNeighboringDimple(new Neighbor(fourdown5, Direction.RIGHT));
		fourdown4.AddNeighboringDimple(new Neighbor(tdown4, Direction.DOWN_LEFT));
		fourdown4.AddNeighboringDimple(new Neighbor(tdown5, Direction.DOWN_RIGHT));
		fourdown4.AddNeighboringDimple(new Neighbor(middle3, Direction.UP_LEFT));
		fourdown4.AddNeighboringDimple(new Neighbor(middle4, Direction.UP_RIGHT));
		
		fourdown5.AddNeighboringDimple(new Neighbor(fourdown4, Direction.LEFT));
		fourdown5.AddNeighboringDimple(new Neighbor(fourdown6, Direction.RIGHT));
		fourdown5.AddNeighboringDimple(new Neighbor(tdown5, Direction.DOWN_LEFT));
		fourdown5.AddNeighboringDimple(new Neighbor(tdown6, Direction.DOWN_RIGHT));
		fourdown5.AddNeighboringDimple(new Neighbor(middle4, Direction.UP_LEFT));
		fourdown5.AddNeighboringDimple(new Neighbor(middle5, Direction.UP_RIGHT));
		
		
		
		middle2.AddNeighboringDimple(new Neighbor(middle1, Direction.LEFT));
		middle2.AddNeighboringDimple(new Neighbor(middle3, Direction.RIGHT));
		middle2.AddNeighboringDimple(new Neighbor(fourup2, Direction.UP_LEFT));
		middle2.AddNeighboringDimple(new Neighbor(fourup3, Direction.UP_RIGHT));
		middle2.AddNeighboringDimple(new Neighbor(fourdown2, Direction.DOWN_LEFT));
		middle2.AddNeighboringDimple(new Neighbor(fourdown3, Direction.DOWN_RIGHT));
		
		middle3.AddNeighboringDimple(new Neighbor(middle2, Direction.LEFT));
		middle3.AddNeighboringDimple(new Neighbor(middle4, Direction.RIGHT));
		middle3.AddNeighboringDimple(new Neighbor(fourup3, Direction.UP_LEFT));
		middle3.AddNeighboringDimple(new Neighbor(fourup4, Direction.UP_RIGHT));
		middle3.AddNeighboringDimple(new Neighbor(fourdown3, Direction.DOWN_LEFT));
		middle3.AddNeighboringDimple(new Neighbor(fourdown4, Direction.DOWN_RIGHT));
		
		middle4.AddNeighboringDimple(new Neighbor(middle3, Direction.LEFT));
		middle4.AddNeighboringDimple(new Neighbor(middle5, Direction.RIGHT));
		middle4.AddNeighboringDimple(new Neighbor(fourup4, Direction.UP_LEFT));
		middle4.AddNeighboringDimple(new Neighbor(fourup5, Direction.UP_RIGHT));
		middle4.AddNeighboringDimple(new Neighbor(fourdown4, Direction.DOWN_LEFT));
		middle4.AddNeighboringDimple(new Neighbor(fourdown5, Direction.DOWN_RIGHT));
		//
		//		//redDimpleThree.AddNeighboringDimple(new Neighbor(redDimpleTwo, Direction.LEFT));
		//		redDimpleThree.AddNeighboringDimple(new Neighbor(noneDimpleThree, Direction.DOWN_LEFT));
		//		redDimpleThree.AddNeighboringDimple(new Neighbor(noneDimpleFour, Direction.DOWN_RIGHT));
		//
		//		//noneDimpleOne.AddNeighboringDimple(new Neighbor(redDimpleOne, Direction.UP_RIGHT));
		//		noneDimpleOne.AddNeighboringDimple(new Neighbor(blueDimpleOne, Direction.DOWN_RIGHT));		
		//		noneDimpleOne.AddNeighboringDimple(new Neighbor(noneDimpleTwo, Direction.RIGHT));
		//
		//		noneDimpleTwo.AddNeighboringDimple(new Neighbor(noneDimpleThree, Direction.RIGHT));
		//		noneDimpleTwo.AddNeighboringDimple(new Neighbor(blueDimpleOne, Direction.DOWN_LEFT));
		//		noneDimpleTwo.AddNeighboringDimple(new Neighbor(blueDimpleTwo, Direction.DOWN_RIGHT));
		//
		//		noneDimpleThree.AddNeighboringDimple(new Neighbor(noneDimpleFour, Direction.RIGHT));
		//		noneDimpleThree.AddNeighboringDimple(new Neighbor(blueDimpleTwo, Direction.DOWN_LEFT));
		//		noneDimpleThree.AddNeighboringDimple(new Neighbor(blueDimple, Direction.DOWN_RIGHT));
		//
		//		noneDimpleFour.AddNeighboringDimple(new Neighbor(blueDimple,Direction.DOWN_LEFT));
		//
		//		blueDimpleOne.AddNeighboringDimple(new Neighbor(blueDimpleTwo,Direction.RIGHT));
		//
		//		blueDimpleTwo.AddNeighboringDimple(new Neighbor(blueDimple,Direction.RIGHT));
		//////
		}

	void Update(){
		timer++;


		//every second?
		if(debug){
			if(timer%100 == 0){
				redBallObjectOne.GetComponent<Ball>().moveBall(Direction.UP_RIGHT);

			}

			foreach(Neighbor n in firstup.neighbors){
				n.dimple.gameObject.renderer.material.SetColor ("_OutlineColor", Color.yellow);
				//Debug.Log (n.direction);
			}
		}



		/*
		foreach(Neighbor n in redDimpleTwo.neighbors){
			n.dimple.renderer.material.SetColor("_OutlineColor", Color.yellow);
		}
		*/
	}


}
