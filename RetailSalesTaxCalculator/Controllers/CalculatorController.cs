using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RetailSalesTaxCalculator.Controllers
{
    public class CalculatorController : ApiController
    {
        [HttpGet]
        public double[] Calculate(double amount, int zip)
        {
			double[] result = new double[2];
			double taxAmount = 0;
			double totalAmount = 0;

			// Using 2 NC county zip codes for testing
			if (zip == 27701)
			{
				taxAmount = (7.5 / 100) * amount;
				totalAmount = amount + taxAmount;
			}
			else if (zip == 27401)
			{
				taxAmount = (6.75 / 100) * amount;
				totalAmount = amount + taxAmount;
			}
			else
			{
				taxAmount = 0;
			}

			result[0] = taxAmount;
			result[1] = totalAmount;

			return result;
		}
    }
}
