﻿using System;
using LogManagement.Event.Parameters;

namespace LogManagement.Event.Conditions
{
    public class GreatherThanOrEqualToExpression: BooleanBase
    {
        private IData _data1;
        private IData _data2;

        public override bool Evaluate(IContext context)
        {
            IComparable comparable = (IComparable) _data1.GetData(context);

            return (comparable != null) && comparable.CompareTo(_data2.GetData(context)) >= 0;
        }

        public GreatherThanOrEqualToExpression(IData data1, IData data2)
        {
            _data1 = data1;
            _data2 = data2;
        }

        public override string GetSyntax(IContext context)
        {
            string syntax1 = _data1.GetSyntax(context);
            string syntax2 = _data2.GetSyntax(context);

            return string.Format("({0} {1} {2})", syntax1, ">=", syntax2);
        }
    }
}
