﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10269287_PRG2Assignment
{
    class BoardingGate
    {
        public string GateName { get; set; }
        public bool SupportsCFFT { get; set; }
        public bool SupportsDDJB { get; set; }
        public bool SupportsLWTT { get; set; }
        public Flight Flight { get; set; }

        public BoardingGate(string gateName, bool supportsCFFT, bool supportsDDJB, bool supportsLWTT)
        {
            GateName = gateName;
            SupportsCFFT = supportsCFFT;
            SupportsDDJB = supportsDDJB;
            SupportsLWTT = supportsLWTT;
        }
        public double CalculateFees()
        {
            double fees = 300;
            return fees;
        }

        public override string ToString()
        {
            return "Gate: " + GateName + " Supports CFFT: " + SupportsCFFT + " SupportsDDJB: " + SupportsDDJB + " SupportsLWTT: " + SupportsLWTT;
        }


    }
}
