// Jack Herdejurgen 113436899
// Delegate

using delegate_folder;

MyFunctioType functionCard;

functionCard = new MyFunctioType(Add);
functionCard = Add;
double sum = functionCard(2, 4);
Console.WriteLine(sum);

sum = functionCard(8,9);

functionCard = Mult;

functionCard = (x, y) => { return x * y; };
functionCard = (x, y) => x * y; // Lambda Expression

double product = functionCard(2, 4);
Console.WriteLine(product);

Console.ReadLine();

static double Add(double double1, double double2)
{
    return double1+double2;
}
static double Mult(double double1, double double2)
{
    return double1 + double2;
}