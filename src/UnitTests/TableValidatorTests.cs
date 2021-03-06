﻿using DatabaseStandardsValidator.Core;
using NUnit.Framework;

namespace DatabaseStandardsValidator.UnitTests
{
    [TestFixture]
    public class TableValidatorTests
    {
        [Test]
        public void IsNameValidShouldReturnTrueWhenCapitalLetter()
        {
            var tableValidator = new TableValidator();

            const string tableName = "Customer";

            var isValid = tableValidator.IsNameValid(tableName);

            Assert.That(isValid, Is.True);
        }
        [Test]
        public void IsNameValidShouldReturnFalseWhenPrefixtbl()
        {
             var tableValidator = new TableValidator();

            const string tableName = "tblCustomer";

            var isValid = tableValidator.IsNameValid(tableName);

            Assert.That(isValid, Is.False);
        }
       [Test]
        public void IsNameValidShouldReturnFalseWhenSpacesPresent()
        {
            var tableValidator = new TableValidator();

            const string tableName = "tbl Customer";

            var isValid = tableValidator.IsNameValid(tableName);

            Assert.That(isValid, Is.False);
        }
          [Test]
         public void IsNameValidShouldReturnFalseWhenAllLowerCases()
         {
             var tableValidator = new TableValidator();

             const string tableName = "tddcustomer";

             var isValid = tableValidator.IsNameValid(tableName);

             Assert.That(isValid, Is.False);
         }
         [Test]
         public void IsNameValidShouldReturnTrueWithMixedCaseConvention()
         {
             var tableValidator = new TableValidator();

             const string tableName = "EquityHolding";

             var isValid = tableValidator.IsNameValid(tableName);

             Assert.That(isValid, Is.True);
         }
         [Test]
         public void IsNameValidShouldReturnTrueWhenCamelCase1()
         {
             var tableValidator = new TableValidator();

             const string tableName = "HappyTable";

             var isValid = tableValidator.IsNameValid(tableName);

             Assert.That(isValid, Is.True);
         }

         [Test]
         public void IsNameValidShouldReturnTrueWhenCamelCase2()
         {
             var tableValidator = new TableValidator();

             const string tableName = "TradingVehiclesRegion";

             var isValid = tableValidator.IsNameValid(tableName);

             Assert.That(isValid, Is.True);
         }

         [Test]
         public void IsNameValidShouldReturnFalseWhenNameContainsUnderscore()
         {
             var tableValidator = new TableValidator();

             const string tableName = "Sad_Table";

             var isValid = tableValidator.IsNameValid(tableName);

             Assert.That(isValid, Is.False);
         }

    }
}
