# CalculatorCSharp
Simple Calcularot made with Windows Forms, it contains 3 custom made lubraries for Arithmetic, Trigonometry and Algebra functions


1.	Data Structures
Name, type and purpose of each variable in table format
The table below shows variables used in the Calculator app.
Name	Type	Purpose
operand	double	Stores numerical input from user
operation	String	Each button has an operation indicatorid stored in string format, so when the user clicks equals button, the program performs switch-case condition, where under the case it searches for operation string.
result	double	Variable to store the result. It is especially useful for the further calculations.

2.	Algorithms
Pseudo Code for each method, Error handling techniques
1)	Arithmetic library
a.	Add(int a, int b)
A+B
b.	Sub(int a, int b)
A-B
c.	Div(int a, int b)
A/B
d.	Mult(int a, int b)
A*B
2)	Algebra library
a.	Sqrt(double d)
root = (d / root + root) / 2;
b.	CubicRoot(double n)
for (i = 1; (i * i * i) <= n; ++i)        //Integer part
            for (--i; (i * i * i) < n; i += precision) //Fractional part
c.	Inverse(int a)
 a = a * -1;
3)	Trigonometry library
a.	Tan(double a)
Tan = opp/adj //Tangent is Opposite over Adjacent.
OR Math.Tan(a)
b.	Sine(double a)
Sine = opp/hyp //Sine is opposite over hypotenuse 
OR Math.Sin(a)
c.	Cosine(double a)
Cosine = adj/hyp //Cosine is adjacent over hypotenuse
OR Math.Cos(a)

4)	Calculator functions
a.	Button Equals
When Pressed
	Switch – look for operation type was chosen

	Case + -> Perform Add function form Arithmetic Library

Case - -> Perform Sub function form Arithmetic Library

Case / -> IF INPUT > 0 -> Perform Div function form Arithmetic Library
	ELSE – OUTPUT ERROR

Case * -> Perform Sub function form Arithmetic Library

Case sqrt -> IF INPUT > 0 -> Perform Sqrt function form Algebra Library
	ELSE – OUTPUT ERROR

Case cuberoot -> IF INPUT > 0 -> Perform CubicRoot function form Algebra Library
	ELSE – OUTPUT ERROR

Case Tan -> IF INPUT is not divisible by 90 -> Convert INPUT to degrees and Perform Tan function form Trigonometry Library
	ELSE – OUTPUT ERROR

Case Cos -> Convert INPUT to degrees and Perform Cos function form Trigonometry Library

Case Sine -> Convert INPUT to degrees and Perform Sine function form Trigonometry Library
		Clear temporary variables for next operation

3.	Recommending testing Procedures
how should this software be tested before commercial release
Since this is not a large program, it can be tested manually, by performing different calculations and by trying to perform odd calculations such as divide by zero. As an alternative, automated testing can be performed.
Different testing methodologies can be applied such as: 
1)	Unit Testing – isolate each unit and test it.
2)	Integration testing – after each unit works separately, test how the units works together.
3)	If calculator will be integrated as an API to another program, then perform System testing to ensure that the entire piece of software works as intended.
4)	Black box testing – also known as User acceptance testing.

Tools for automated testing
Unlike manual testing — where humans need to check each use case by hand, and log the outcome — automated testing relies on tools to do the job for you.
For example, frameworks like Selenium will test the cross-browser compatibility of web apps. That’s something that anyone who’s tried to get their app to display properly on Internet Explorer will know the value of.
•	Selenium: automated cross-browser regression testing. Selenium is free and open source. It has many premium product spin-offs such as Sauce Labs, which builds on the code to provide extra functionality. Tools built on this framework are a must-use for testing browser compatibility.
•	CloudBees: fully automated testing suite from code to production. CloudBees includes unit testing and continuous integration features and starts from free. Used by Netflix.
•	CircleCI: continuous integration platform. Used by Facebook and Spotify, CircleCI provides a full platform for automated testing, amongst other things such as its own build environment and deployment tools.
(types-of-software-testing, n.d.)

4.	Recommendation on upgrades and future enhancement
Further upgrades may include: 
1)	Enhanced UI/UX
a.	Better colour scheme or customizable colour options
b.	Better button navigation
c.	Add keyboard shortcuts
d.	Change fonts
2)	Enhanced Backend
a.	More efficient algorithms
b.	More error trapping
3)	Additional Functionality	
a.	More menu options, such as “Edit”, “Help”.
b.	Display options, for example to be able to see all input in the textbox as user perform calculations.
