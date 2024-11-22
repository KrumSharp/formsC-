using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolveTriangle_Click(object sender, EventArgs e)
        {
            try
            {
                // Вземане на стойностите от текстовите полета
                double a = double.Parse(txtTriangleA.Text);
                double b = double.Parse(txtTriangleB.Text);
                double c = double.Parse(txtTriangleC.Text);

                // Извикване на функцията за решаване на триъгълник
                double area = SolveTriangleBySides(a, b, c);

                //проверка на вида триъгълник
                if (a + b > c && a + c > b && b + c > a)
                {
                    if (a == b && b == c)
                    {
                        //Console.WriteLine("Триъгълникът е равностранен.");
                        TypeOfTri.Text = "равностранен.";

                    }
                    else if (a == b || a == c || b == c)
                    {
                        //Console.WriteLine("Триъгълникът е равнобедрен.");
                        TypeOfTri.Text = "равнобедрен.";
                    }
                    else
                    {
                        //Console.WriteLine("Триъгълникът е разностранен.");
                        TypeOfTri.Text = "разностранен.";
                    }
                }
                else
                {
                    TypeOfTri.Text = "Страните не образуват триъгълник.";
                }


                // Показване на резултата
                ResultTriangleHeron.Text = area.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Моля, въведете валидни стойности.");
            }
        }

        private double SolveTriangleBySides(double a, double b, double c)
        {
            // Формула на Херон за лице на триъгълник
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        }

        private void btnSolveTriangle2_Click(object sender, EventArgs e)
        {
            try
            {
                double side = double.Parse(txtTriangleLenght.Text);
                double height = double.Parse(txtTriangleHeight.Text);

                double area1 = (side + height) / 2;

                txtResult.Text = area1.ToString();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Моля, въведете валидни стойности.");

            }
        }

        private void btnSolveTriangle3_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = double.Parse(Side1.Text);
                double side2 = double.Parse(Side2.Text);
                double angle = double.Parse(angleDress.Text);

                double angleRadians = angle * (Math.PI / 180);
                double area2 = (side1 * side2 * Math.Sin(angleRadians)) / 2;

                ResultTriangle3.Text = area2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Моля, въведете валидни стойности.");

            }
        }

        private void btnSolveRombus_Click(object sender, EventArgs e)
        {
            double ronbusl = double.Parse(rombuslenght.Text);
            double ronbush = double.Parse(rombusheight.Text);

            double area2 = ronbusl * ronbush;

            rombusresult.Text = area2.ToString();
        }

        private void btnsqurt_Click(object sender, EventArgs e)
        {
            double sqrt = double.Parse(squrtSide.Text);

            double squrtArea = sqrt * sqrt;

            squrtResult.Text = squrtArea.ToString();
        }

        private void btnUsporednik_Click(object sender, EventArgs e)
        {
            double baseLenhght = double.Parse(baseLength.Text);

            double heightuspor = double.Parse(heightUspor.Text);

            double UsporArea = heightuspor * baseLenhght;

            ResultUsporednik.Text = UsporArea.ToString();
        }

        private void btnTrapec_Click(object sender, EventArgs e)
        {
            double trapecLenght1 = double.Parse(TrapecLenght1.Text);

            double trapecLenght2 = double.Parse(TrapecLenght2.Text);

            double trapecHeight = double.Parse(TrapecHeight.Text);

            double TrapecArea = (trapecLenght1 + trapecLenght2) * trapecHeight / 2;

            ResutTrapec.Text = TrapecArea.ToString();


        }

        private void btnSolveConvexQuadrilateral_Click(object sender, EventArgs e)
        {
            double d1 = double.Parse(D1.Text);

            double d2 = double.Parse(D2.Text);

            double angleBetwinD1AndD2 = double.Parse(AngleBetwinD1AndD2.Text);

            // Преобразуване на ъгъла в радиани, тъй като тригонометричните функции в C# работят с радиани
            double angleRadians = angleBetwinD1AndD2 * (Math.PI / 180);

            // Формула за лице на изпъкнал четириъгълник (когато са известни 2 страни и ъгъл между тях):
            // Лице = 1/2 * a * b * sin(θ), където θ е ъгълът между страните
            double areaD1D2 = 0.5 * d1 * d2 * Math.Sin(angleRadians);

            ResultConvexQuadrilateral.Text = areaD1D2.ToString();
        }

        private void btnSolveRegularPolygon_Click(object sender, EventArgs e)
        {
            double numberOfSides = double.Parse(NumberOfSides.Text);

            double sideLength = double.Parse(SideLength.Text);

            // Изчисляване на периметъра на правилен многоъгълник
            double perimeter = numberOfSides * sideLength;

            // Изчисляване на апотемата (радиуса на вписаната окръжност)
            // Формулата за апотема: апотема = s / (2 * tan(π / n))
            double apothem = sideLength / (2 * Math.Tan(Math.PI / numberOfSides));

            // Изчисляване на лицето на правилния многоъгълник
            // Формула за лице: Лице = (периметър * апотема) / 2
            double areaRegularPolygon = (perimeter * apothem) / 2;

            ResultRegularPolygon.Text = areaRegularPolygon.ToString();
        }

        private void btnSolveCircle_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(Radius.Text);

            // Изчисляване на лицето на окръжността
            // Формула за лице: A = π * r^2
            double areaCircle = Math.PI * Math.Pow(radius, 2);

            ResultCircle.Text = areaCircle.ToString();
        }

        //Обемни фигури
        private void btnSolveSphere_Click(object sender, EventArgs e)
        {
            double radiusSphere = double.Parse(RadiusSphere.Text);

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radiusSphere, 3);
            double surfaceArea = 4 * Math.PI * Math.Pow(radiusSphere, 2);

            VolumeSphere.Text = volume.ToString();
            SurfaceAreaSphere.Text = surfaceArea.ToString();

        }

        private void btnSolveCube_Click(object sender, EventArgs e)
        {
            double sideCube = double.Parse(SideCube.Text);

            double volume = Math.Pow(sideCube, 3);
            double surfaceArea = 6 * Math.Pow(sideCube, 2);

            VolumeCube.Text = volume.ToString();
            SurfaceAreaCube.Text = surfaceArea.ToString();
        }

        private void btnSolveParallelepiped_Click(object sender, EventArgs e)
        {
            double parallelepipedLenght = double.Parse(ParallelepipedLenght.Text);
            double parallelepipedWidth = double.Parse(ParallelepipedWidth.Text);
            double parallelepipedHeight = double.Parse(ParallelepipedHeight.Text);

            double volume = parallelepipedLenght * parallelepipedWidth * parallelepipedHeight;
            double surfaceArea = 2 * (parallelepipedLenght * parallelepipedWidth + parallelepipedWidth * parallelepipedHeight + parallelepipedHeight * parallelepipedLenght);

            ParallelepipedVolume.Text = volume.ToString();
            ParallelepipedSuerfaceArea.Text = surfaceArea.ToString();

        }

        private void btnSolveCone_Click(object sender, EventArgs e)
        {
            double radiusCone = double.Parse(RadiusCone.Text);
            double heightCone = double.Parse(HeightCone.Text);

            double volume = (1.0 / 3.0) * Math.PI * Math.Pow(radiusCone, 2) * heightCone;
            double slantHeight = Math.Sqrt(Math.Pow(radiusCone, 2) + Math.Pow(heightCone, 2));
            double lateralSurfaceArea = Math.PI * radiusCone * slantHeight;
            double surfaceArea = lateralSurfaceArea + Math.PI * Math.Pow(radiusCone, 2);

            VolumeCone.Text = volume.ToString();
            LateralSurfaceAreaCone.Text = lateralSurfaceArea.ToString();
            SurfaceAreaCone.Text = surfaceArea.ToString();
        }

        private void btnSolveCilinder_Click(object sender, EventArgs e)
        {
            double radiusCilinder = double.Parse(RadiusCilinder.Text);
            double heightCilinder = double.Parse(HeightCilinder.Text);

            double volume = Math.PI * Math.Pow(radiusCilinder, 2) * heightCilinder;
            double lateralSurfaceArea = 2 * Math.PI * radiusCilinder * heightCilinder;
            double surfaceArea = lateralSurfaceArea + 2 * Math.PI * Math.Pow(radiusCilinder, 2);

            VolumeCilinder.Text = volume.ToString();
            LateralSurfaceAreaCilinder.Text = lateralSurfaceArea.ToString();
            SurfaceAreaCilinder.Text = surfaceArea.ToString();
        }

        private void btnSolvePyramid_Click(object sender, EventArgs e)
        {
            double baseLenghtPyramid = double.Parse(BaseLenghtPyramid.Text);
            double heightPyramid = double.Parse(HeightPyramid.Text);
            double slantHeightPyramid = double.Parse(SlantHeightPyramid.Text);

            double baseArea = Math.Pow(baseLenghtPyramid, 2);
            double volume = (1.0 / 3.0) * baseArea * heightPyramid;
            double lateralSurfaceArea = 2 * baseLenghtPyramid * slantHeightPyramid;
            double surfaceArea = baseArea + lateralSurfaceArea;

            VolumePyramid.Text = volume.ToString();
            LateralSurfaceAreaPyramid.Text = lateralSurfaceArea.ToString();
            SurfaceAreaPyramid.Text = surfaceArea.ToString();
        }

        //Квадрадтно уравнение
        private void btnSolveQuadraticEquation_Click(object sender, EventArgs e)
        {
            double a = double.Parse(A.Text);
            double b = double.Parse(B.Text);
            double c = double.Parse(C.Text);

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                //Console.WriteLine($"Корените на уравнението са: x1 = {x1}, x2 = {x2}");

                ResultQuadraticEquation.Text = $"Корените на уравнението са: x1 = {x1}, x2 = {x2}";
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                //Console.WriteLine($"Уравнението има един корен: x = {x}");
                ResultQuadraticEquation.Text = $"Уравнението има един корен: x = {x}";
            }
            else
            {
                //Console.WriteLine("Уравнението няма реални корени.");
                ResultQuadraticEquation.Text = "Уравнението няма реални корени.";
            }

        }

        //Биквадратно уравнение
        private void btnSolveBiquadraticEquation_Click(object sender, EventArgs e)
        {
            double aby = double.Parse(ABY.Text);
            double bby = double.Parse(BBY.Text);
            double cby = double.Parse(CBY.Text);

            // Проверка дали уравнението е действително биквадратно
            if (aby == 0)
            {
                //Console.WriteLine("Коефициентът 'a' не може да бъде 0 при биквадратно уравнение.");
                //return;

                ByCheck.Text = "Коефициентът 'a' не може да бъде 0 при биквадратно уравнение.";
            }

            // Решаване на квадратното уравнение: a*z^2 + b*z + c = 0, където z = x^2
            double discriminant = bby * bby - 4 * aby * cby;

            // Проверка на дискриминантата
            if (discriminant < 0)
            {
                //Console.WriteLine("Уравнението няма реални решения.");
                ResultBy.Text = "Уравнението няма реални решения.";


            }
            else
            {
                // Изчисляване на решенията на квадратното уравнение за z
                double z1 = (-bby + Math.Sqrt(discriminant)) / (2 * aby);
                double z2 = (-bby - Math.Sqrt(discriminant)) / (2 * aby);

                // Намиране на решенията за x от z = x^2
                bool hasSolutions = false;

                if (z1 >= 0)
                {
                    double x1 = Math.Sqrt(z1);
                    double x2 = -Math.Sqrt(z1);
                    //Console.WriteLine($"Решения: x1 = {x1}, x2 = {x2}");
                    ResultBy.Text = $"Решения: x1 = {x1}, x2 = {x2}";
                    hasSolutions = true;


                }

                if (z2 >= 0)
                {
                    double x3 = Math.Sqrt(z2);
                    double x4 = -Math.Sqrt(z2);
                    //Console.WriteLine($"Решения: x3 = {x3}, x4 = {x4}");
                    ResultBy.Text = $"Решения: x3 = {x3}, x4 = {x4}";
                    hasSolutions = true;
                }

                if (!hasSolutions)
                {
                    //Console.WriteLine("Няма реални решения.");
                    ResultBy.Text = "Няма реални решения.";

                }
            }
        }

        // Решаване на система уравнения с две неизвестни
        // Метод на заместване
        private void btnSolveBySubstitution_Click(object sender, EventArgs e)
        {
            double b1 = double.Parse(B1.Text);
            double c1 = double.Parse(C1.Text);
            double a1 = double.Parse(A1.Text);
            double x = double.Parse(X.Text);

            double y;

            if (b1 != 0)
            {
                // y = (c1 - a1 * x) / b1
                //Console.Write("Въведете стойност за x: ");
                y = (c1 - a1 * x) / b1;
                //Console.WriteLine($"Решението е: x = {x}, y = {y}");
                ResultBySubstitution.Text = $"Решението е: x = {x}, y = {y}";
            }
            else
            {
                //Console.WriteLine("Не може да се реши чрез метода на заместване, тъй като b1 е 0.");
                ResultBySubstitution.Text = "Не може да се реши чрез метода на заместване, тъй като b1 е 0.";
            }
        }

        // Метод на елиминация
        private void btnSolveByElimination_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(ToA1.Text);
            double b1 = double.Parse(ToB1.Text);
            double c1 = double.Parse(ToC1.Text);
            double a2 = double.Parse(ToA2.Text);
            double b2 = double.Parse(ToB2.Text);
            double c2 = double.Parse(ToC2.Text);

            // Умножаваме уравненията, за да елиминираме y
            double determinant = a1 * b2 - a2 * b1;

            if (determinant == 0)
            {
                // Console.WriteLine("Системата уравнения няма уникално решение.");
                //return;
                CheckByElimination.Text = "Системата уравнения няма уникално решение.";
            }

            // Намираме x
            double x = (c1 * b2 - c2 * b1) / determinant;
            // Намираме y
            double y = (a1 * c2 - a2 * c1) / determinant;

            //Console.WriteLine($"Решението е: x = {x}, y = {y}");
            ResultByElimination.Text = $"Решението е: x = {x}, y = {y}";
        }
    }
}
