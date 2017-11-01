using System;
using System.Globalization;

namespace TransformationLib
{
    public class Transformation
    {
        public static string Transform(string amountContent, string quantityContent)
        {
            var actual = "";

            foreach (var amountLine in amountContent.Split(new string[] {"\r\n"}, StringSplitOptions.None))
            {
                var amount = decimal.Parse(amountLine, CultureInfo.InvariantCulture);

                foreach (var quantityLine in quantityContent.Split(new string[] { "\r\n" }, StringSplitOptions.None))
                {
                    var quantity = int.Parse(quantityLine);
                    var product = amount * quantity;
                    actual += $"{amountLine}x{quantityLine}={product.ToString(CultureInfo.InvariantCulture)}\r\n";
                }
            }
            actual = actual.Substring(0, actual.Length - 2);
            return actual;
        }
    }
}
