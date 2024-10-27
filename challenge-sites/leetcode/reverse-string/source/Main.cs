namespace minimal_template;

//https://leetcode.com/problems/reverse-string/

/*
    This teaches me that arrays in C# are passed by reference, which allows me to return void and simply check the input string
    after. 
    
    The only difference between this and the leetcode example is that the input for Leetcode is char[] and I'm using String[].
    This also teaches me that I could declare the same array two ways:
    String[] input = ["H","a","n","n","a","h"];
    char[] expected = ['o','l','l','e','h'];
    though when i tried to make this change in Leetcode, i got an error saying:
    cannot convert from 'char[]' to 'string[]'
    so the cast needs to be explicit.
    
    Also, Leetcode appears to contain an error since they show the array as double quoted single letters, 
    but that would make it a String[]

    On that front, C# uses single quotes for char, which does not allow interpolation/variable substitution, but is faster.
    Double quotes are registered as strings in almost all cases, and do allow interpolation.
    Due to interpolation, double quotes can represent a char if the quoted string is a unicode representation of a char.
    For example, "\u0041" == 'A' (See Test6)
*/

public class Main {
    public void main(String[] input) {
        int start = 0;
        int end = input.Length - 1;

        while( end > start) {
            string tmp = input[start];
            input[start] = input[end];
            input[end] = tmp;

            start++;
            end--;
        }
    }

    public String[] mainWithReturn(String[] input) {
        int start = 0;
        int end = input.Length - 1;

        while( end > start) {
            string tmp = input[start];
            input[start] = input[end];
            input[end] = tmp;

            start++;
            end--;
        }
        return input;
    }

    public char[] mainWithCharInput(char[] input) {
        int start = 0;
        int end = input.Length - 1;

        while( end > start) {
            char tmp = input[start];
            input[start] = input[end];
            input[end] = tmp;

            start++;
            end--;
        }
        return input;
    }

    public String[] mainWithCharInputAndStringOutput(char[] input) {
        int start = 0;
        int end = input.Length - 1;

        while( end > start) {
            char tmp = input[start];
            input[start] = input[end];
            input[end] = tmp;

            start++;
            end--;
        }
        
        return input.Select(s => s.ToString()).ToArray();
    }
 }