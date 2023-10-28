
public class Calculations
{
    public double Delta(double a, double b, double c) //this function count delta value
    {

        double del = (b * b) - (4 * a * c);
        return del;

    }


    public string IsZeroPlaces(double d) //this function check if delta have any zero places
    {
        if (d > 0)
        {
            return "This function have two zero places";

        }
        else if (d < 0)
        {
            return "This function have not zero place";
        }
        else if (d == 0)
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
}

