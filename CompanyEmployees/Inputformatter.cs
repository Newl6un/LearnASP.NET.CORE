using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text;

namespace CompanyEmployees
{
    public class Inputformatter : TextInputFormatter
    {
        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
        {
            throw new NotImplementedException();
        }
    }
}
