﻿using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrankService
    {
        private DrankDao drankDAO;

        public DrankService()
        {
            drankDAO = new DrankDao();
        }

        // Method to retrieve all drinks
        public List<Drank> GetDranken()
        {
            List<Drank> dranks = drankDAO.GetAllDranken();
            return drankDAO.GetAllDranken();
        }

        // Method to calculate VAT for the drinks in a given quarter
        public decimal CalculateVATForQuarter(int year, string quarter)
        {
            // Retrieve drinks sold in the specified quarter
            List<Drank> dranken = drankDAO.GetDrankenForQuarter(year, quarter);

            // Calculate total VAT for all drinks in the quarter
            decimal totalVAT = 0;
            foreach (Drank drank in dranken)
            {
                // Assuming Drank class has a method to calculate VAT for each drink
                totalVAT += drank.CalculateVAT();
            }

            return totalVAT;
        }

        public Tuple<DateTime, DateTime> CalculateQuarterDates(int year, string quarter)
        {
            DateTime beginQuarter, endQuarter;

            switch (quarter.ToUpper())
            {
                case "1":
                    beginQuarter = new DateTime(year, 1, 1);
                    endQuarter = new DateTime(year, 3, 31);
                    break;
                case "2":
                    beginQuarter = new DateTime(year, 4, 1);
                    endQuarter = new DateTime(year, 6, 30);
                    break;
                case "3":
                    beginQuarter = new DateTime(year, 7, 1);
                    endQuarter = new DateTime(year, 9, 30);
                    break;
                case "4":
                    beginQuarter = new DateTime(year, 10, 1);
                    endQuarter = new DateTime(year, 12, 31);
                    break;
                default:
                    throw new ArgumentException("Invalid quarter: " + quarter);
            }

            return Tuple.Create(beginQuarter, endQuarter);
        }
    }
}