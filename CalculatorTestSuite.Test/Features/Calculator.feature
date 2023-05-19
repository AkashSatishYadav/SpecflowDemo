Feature: Calculator
		 1. Add
		 2. Substract
		 3. Multiply

To test all functionality of a calculator

@Cal
Scenario: Addition of two number
	Given the first number is <firstNum>
	When the second number is <secondNum>
	Then the sum of first and second should be <addResult>

Examples: 
		| firstNum | secondNum | addResult |
		| 4        | 5         | 9         |
		| 100      | 5         | 105       |
		| 1000     | 1000      | 2000      |

Scenario: Substraction of two number
	Given the first number is <firstNum>
	When the second number is <secondNum>
	Then the substraction of first and second should be <subsResult>

Examples: 
		| firstNum | secondNum | subsResult |
		| 4        | 5         | -1         |
		| 100      | 5         | 95         |
		| 1000     | 1000      | 0          |

Scenario: Multiplication of two number
	Given the first number is <firstNum>
	When the second number is <secondNum>
	Then the multiplication of first and second should be <mulResult>

Examples: 
		| firstNum | secondNum | mulResult |
		| 4        | 5         | 20        |
		| 100      | 5         | 500       |
		| 1000     | 1000      | 1000000   |