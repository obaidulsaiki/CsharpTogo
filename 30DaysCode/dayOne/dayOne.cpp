#include <bits/stdc++.h>
using namespace std;
class Obaidul2210
{
    float sem1, sem2, sem3, CGPA;

public:
    Obaidul2210()
    {
        cout << "Enter the SGPA of following semester: " << endl;
        cout << "Semester 1 : ";
        cin >> sem1;
        cout << "Semester 2 : ";
        cin >> sem2;
        cout << "Semester 3 : ";
        cin >> sem3;
    }
    void output()
    {
        CGPA = (sem1 + sem2 + sem3) / 3;
        cout << "Current CGPA is : " << fixed << setprecision(2) << CGPA << endl;
    }
};
int main()
{
    Obaidul2210 obj1;
    obj1.output();
    return 0;
}