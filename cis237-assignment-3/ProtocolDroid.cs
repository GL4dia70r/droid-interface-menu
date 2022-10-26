﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_3
{
    class ProtocolDroid : Droid
    {
        //
        protected const decimal COST_PER_LANGUAGE = 50m;

        //
        private int _numberLanguages;

        public new string Model { get; set; }

        //
        public int NumberLanguages
        {
            get { return _numberLanguages; }
            set { _numberLanguages = value; }
        }

        public new decimal BaseCost { get; set; }

        public new decimal TotalCost { get; set; }

        //
        public override string ToString()
        {  
            return $"{base.ToString()} {NumberLanguages}";
        }

        public override void CalculateTotalCost()
        {
           this.TotalCost = base.CalculateBaseCost() + this.CalculateBaseCost();
        }

        //
        protected virtual new decimal CalculateBaseCost()
        {
            this.GetNumberedCosts(NumberLanguages, COST_PER_LANGUAGE);

            return this.BaseCost;   
        }

        
        //
        public ProtocolDroid(
            string Model,
            string Material,
            string Color,
            int NumberLanguages
        ) : base(Model, Material, Color)
        {
            this._numberLanguages = NumberLanguages;
        }

        public ProtocolDroid()
        {
            // Do Nothing
        }
    }
}
