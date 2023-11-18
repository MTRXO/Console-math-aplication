
public class Calculations
{
    public double Delta(double a, double b, double c) //this function count delta value
    {

        double del = (b * b) - (4 * a * c);
        return del;

    }


    public string IsZeroPlaces(double delt) //this function check if delta have any zero places
    {
        if (delt > 0)
        {
            return "This function have two zero places";

        }
        else if (delt < 0)
        {
            return "This function have not zero place";
        }
        else if (delt == 0)
        {
            return "This function have one zero place";
        }
        else return "wrong input";

    }
    public double ZeroPlacesCounterx1(double a, double b, double delta) //This function count first zero place
    {
        double x1 = (-b - Math.Sqrt(delta));
        return x1 / (2 * a);

    }
    public double ZeroPlacesCounterx2(double a, double b, double delta) //This function count second zero place 
    {
        double x2 = (-b + Math.Sqrt(delta));
        return x2 / (2 * a);

    }
    public double OneZeroPlace(double a, double b) //This function count zero place in case when delta == 0 
    {
        double x0 = -b / (2 * a);
        return x0;
    }
    public double SquareField(double a) //This function count square field 
    {
        return a * a;
    }
    public double RectangleField(double a, double b) //This function count rectangle field
    {
        return a * b;
    }
    public double RectangularTriangleFiled(double a, double h) //This function count  Rectangular triangle filed
    {
        return (a * h) / 2;

    }

    public string[] UnitConverter(int type, double value) //This function convert one type of units to the remaining types 
    {
        double ToCentimeters = 0;
        double ToMeters = 0;
        double ToMilimeters = 0;
        if (type == 1)
        {
            ToCentimeters = value / 10;
            ToMeters = value / 1000;
            ToMilimeters = value;
            return new string[] { $"Centimeters: {ToCentimeters}", $"Meters: {ToMeters}", $"Milimeters: {ToMilimeters}" };
        }
        else if (type == 2)
        {
            ToMilimeters = value * 10;
            ToMeters = value / 100;
            ToCentimeters = value;
            return new string[] { $"Centimeters: {ToCentimeters}", $"Meters: {ToMeters}", $"Milimeters: {ToMilimeters}" };
        }
        else if (type == 3)
        {
            ToCentimeters = value * 100;
            ToMeters = value;
            ToMilimeters = value * 1000;
            return new string[] { $"Centimeters: {ToCentimeters}", $"Meters: {ToMeters}", $"Milimeters: {ToMilimeters}" };
        }
        else
        {
            throw new Exception("Wrong unit format");
        }

    }
    

}

