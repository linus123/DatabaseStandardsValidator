namespace DatabaseStandardsValidator.Core
{
    public class TableValidator
    {
        public bool IsNameValid(string customer)
        {
            if (customer.StartsWith("C"))
            {
                return true;
            }
            if (customer.StartsWith("tbl"))
            {
                return false;
            }
            if (customer.Contains(" "))
            {
                return false;
            }
            foreach (char var in customer)
            {
                if(var.ToString() == char.ToLower(var).ToString())
                {
                    return false;
                }
            }

            return true;
        }
    }
}