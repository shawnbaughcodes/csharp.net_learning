public class Vehicle {
    public int numPassengers;
    public double distance = 0.0;
    // NEW CAR
    public Vehicle(int val){
        numPassengers =  val;
    }
    public Vehicle(int val, double odo){
        numPassengers = val;
        distance = odo;
    }
    public int Move(double miles){
        distance += miles;
        return (int)distance;
    }
    public int Move(double miles, bool km){
        if(km == true){
            miles = miles * 0.62;
        }
        return Move(miles);
    }
    public void Move(double miles){
        distance += miles;
    }
}