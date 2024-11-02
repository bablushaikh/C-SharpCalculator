using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace Assignment_2 {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
    public static string ComputeOperation(string operator_1, string operator_2, string operation) {
      string result = string.Empty;

      // validate if both numbers are valid
      if (ValidateNumbers(operator_1, operator_2)) {
        switch (operation) {
        case "+":
          result = AddNumbers(operator_1, operator_2);
          break;
        case "-":
          result = SubtractTwoNumbers(operator_1, operator_2);
          break;
        case "*":
          result = MultiplyTwoNumbers(operator_1, operator_2);
          break;
        case "/":
          result = DivideTwoNumbers(operator_1, operator_2);
          break;

        }
      } else {
        result = "Numbers are not valid";
      }
      return result;
    }

    public static bool ValidateNumbers(string num1, string num2) {
      bool isValidNumbers = false;

      foreach(char c in num1.ToCharArray()) // Check if first number is valid
      {

        if (char.IsDigit(c)) {
          isValidNumbers = true;
        } else {
          isValidNumbers = false;
          break;
        }
      }
      if (isValidNumbers) {
        foreach(char c in num2.ToCharArray()) // Check if second number is valid
        {
          if (char.IsDigit(c)) {
            isValidNumbers = true;
          } else {
            isValidNumbers = false;
            break;
          }
        }
      }
      return isValidNumbers;
    }

    public static string AddNumbers(string a, string b) {
      string operationResult = string.Empty;
      StringBuilder sb = new StringBuilder();
      if (a.Length > b.Length) {
        b = new string('0', a.Length - b.Length) + b;
      } else if (a.Length < b.Length) {
        a = new string('0', b.Length - a.Length) + a;
      }
      int carryForward = 0;
      for (int i = a.Length - 1; i >= 0; i--) {

        int sum = 0;
        sum = Convert.ToInt32(a.Substring(i, 1)) + Convert.ToInt32(b.Substring(i, 1)) + carryForward;
        if (i == 0) {
          if (sum.ToString().Length > 1) {
            sb.Append(sum.ToString().Substring(1, 1) + sum.ToString().Substring(0, 1));
          } else {
            sb.Append(sum.ToString());
          }

        } else if (sum.ToString().Length > 1) {
          carryForward = Convert.ToInt32(sum.ToString().Substring(0, 1));
          sb.Append(sum.ToString().Substring(1, 1));
        } else {
          carryForward = 0;
          sb.Append(sum.ToString());
        }

      }
      operationResult = sb.ToString();
      char[] reversedArray = operationResult.ToCharArray().Reverse().ToArray();
      return new string(reversedArray);
    }

    public static string SubtractTwoNumbers(string a, string b) {
      string result = "0";
      StringBuilder sb = new StringBuilder();
      string operationResult = string.Empty;
      bool isNegitiveOperation = false;
      int borrow = 0;
      if (a.Trim().Equals(b.Trim())) {
        sb.Append("0");
      } else {
        if (a.Length > b.Length) {
          b = new string('0', a.Length - b.Length) + b;
        } else if (a.Length < b.Length) {
          a = new string('0', b.Length - a.Length) + a;
          string temp = a;
          a = b;
          b = temp;
          isNegitiveOperation = true;
        }
        for (int i = a.Length - 1; i >= 0; i--) {
          int diff = 0;
          if (i == 0) {
            if (Convert.ToInt32(a[i]) - borrow < Convert.ToInt32(b[i])) {
              diff = 0;
              borrow = 0;
            } else {
              diff = Convert.ToInt32(a[i]) - borrow - Convert.ToInt32(b[i]);
              borrow = 0;
            }

          } else if (Convert.ToInt32(a[i]) - borrow >= Convert.ToInt32(b[i])) {
            diff = Convert.ToInt32(a[i]) - borrow - Convert.ToInt32(b[i]);
            borrow = 0;
          } else {
            diff = 10 + Convert.ToInt32(a[i]) - borrow - Convert.ToInt32(b[i]);
            borrow = 1;
          }

          if (i == 0 && diff == 0) {
            //Donot append anything
          } else {
            sb.Append(diff.ToString());
          }
        }
      }

      operationResult = sb.ToString();
      char[] reversedArray = operationResult.ToCharArray().Reverse().ToArray();
      result = new string(reversedArray);
      if (result.Contains("-")) {
        result = "-" + result.Replace("-", "");
      }
      if (isNegitiveOperation) {
        result = "-" + result;
      }
      return result;

    }

    public static string MultiplyTwoNumbers(string a, string b) {
      string result = string.Empty;
      List < string > lstMultiplyResults = new List < string > ();
      string operationResult = string.Empty;
      int counter = 0;
      for (int i = b.Length - 1; i >= 0; i--) {
        StringBuilder sb = new StringBuilder();
        int carry = 0;

        if (counter > 0) {
          sb.Append(0. ToString("D" + counter.ToString()));

        }
        for (int j = a.Length - 1; j >= 0; j--) {

          int mul = carry + (Convert.ToInt32(a.Substring(j, 1)) * Convert.ToInt32(b.Substring(i, 1)));
          if (mul.ToString().Length > 1) {
            if (j == 0) {
              sb.Append(mul.ToString().Substring(1, 1) + mul.ToString().Substring(0, 1));
            } else {
              carry = Convert.ToInt32(mul.ToString().Substring(0, 1));
              sb.Append(mul.ToString().Substring(1, 1));
            }
          } else {
            carry = 0;
            sb.Append(mul);
          }
        }
        operationResult = sb.ToString();
        char[] reversedArray = operationResult.ToCharArray().Reverse().ToArray();
        lstMultiplyResults.Add(new string(reversedArray));
        counter++;
      }
      result = 0. ToString();
      foreach(string str in lstMultiplyResults) {
        result = AddNumbers(result, str);
      }
      return result;
    }

    public static string DivideTwoNumbers(string a, string b) {
      string result = string.Empty;
      try {
        double divisor = Convert.ToDouble(b);
        if (divisor > 0) {
          // Find prefix of number that is larger
          // than divisor.
          int idx = 0;
          double temp = (int)(a[idx] - '0');
          while (temp < divisor) {
            temp = temp * 10 + (double)(a[idx + 1] - '0');
            idx++;
          }
          ++idx;

          // Repeatedly divide divisor with temp. After
          // every division, update temp to include one
          // more digit.
          while (a.Length > idx) {
            // Store result in answer i.e. temp / divisor
            result += (char)(temp / divisor + '0');

            // Take next digit of number
            temp = (temp % divisor) * 10 + (int)(a[idx] - '0');
            idx++;
          }
          result += (char)(temp / divisor + '0');

          // If divisor is greater than number
          if (result.Length == 0)
            return "0";
        } else {
          result = "Division is not defined. Please enter a number greater than 0";
        }
      } catch (Exception ex) {
        result = ex.Message;
      }

      return result;
    }
  }
}