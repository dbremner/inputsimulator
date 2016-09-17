using System.Text;

namespace WindowsInput.Tests.UnicodeText
{
    public class UnicodeRange
    {
        public string Name { get; }
        public int Low { get; }
        public int High { get; }

        public string Characters
        {
            get
            {
                var i = Low;
                var sb = new StringBuilder(High - Low + 10);
                while (i <= High)
                {
                    sb.Append(char.ConvertFromUtf32(i));
                    i++;
                }
                return sb.ToString();
            }
        }

        public UnicodeRange(string name, int low, int high)
        {
            Name = name;
            Low = low;
            High = high;
        }
    }
}