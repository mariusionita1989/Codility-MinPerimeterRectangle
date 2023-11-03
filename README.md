# Codility-MinPerimeterRectangle
An integer N is given, representing the area of some rectangle.</br>
The area of a rectangle whose sides are of length A and B is A * B, and the perimeter is 2 * (A + B).</br>
The goal is to find the minimal perimeter of any rectangle whose area equals N.</br> 
The sides of this rectangle should be only integers.

For example, given integer N = 30, rectangles of area 30 are:</br>
(1, 30), with a perimeter of 62,</br>
(2, 15), with a perimeter of 34,</br>
(3, 10), with a perimeter of 26,</br>
(5, 6), with a perimeter of 22.
                
Write a function:</br>
class Solution { public int solution(int N); }</br>
that, given an integer N, returns the minimal perimeter of any rectangle whose area is exactly equal to N.</br>
For example, given an integer N = 30, the function should return 22, as explained above.</br>

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..1,000,000,000].
