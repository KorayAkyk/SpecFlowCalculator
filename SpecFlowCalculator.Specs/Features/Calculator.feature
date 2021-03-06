Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@add
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@multiply
Scenario: Multiply two numbers
	Given the first number is 10
	And the second number is 10
	When the two numbers are multiplied
	Then the result should be 100

@divide
Scenario: Divide two numbers
	Given the first number is 30
	And the second number is 2
	When the two numbers are divided
	Then the result should be 15

@Minus
Scenario: Minus two numbers
	Given the first number is 30
	And the second number is 2
	When the two numbers are minus
	Then the result should be 15