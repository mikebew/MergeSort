Feature: MergeSort
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Merge Sort Integer Array
	Given I have entered 7,9,3,5,2,6,1,10,4,0,8 into the merge sort
	When I press sort
	Then the result should be 0,1,2,3,4,5,6,7,8,9,10 on the screen