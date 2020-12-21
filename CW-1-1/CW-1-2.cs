using System;

public class CW-1-2
{
	static private double playerSpeed;
	static void Main(string[] args)
    {
		SetSpeed(2.5);
		GetSpeed();

	}
	void SetSpeed(double newSpeed) {
		playerSpeed = newSpeed;
	}
	double GetSpeed() {
		Console.WriteLine("The current player speed is {0}", playerSpeed);
	}
}
