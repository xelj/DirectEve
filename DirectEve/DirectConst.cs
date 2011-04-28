﻿// ------------------------------------------------------------------------------
//   <copyright from='2010' to='2015' company='THEHACKERWITHIN.COM'>
//     Copyright (c) TheHackerWithin.COM. All Rights Reserved.
// 
//     Please look in the accompanying license.htm file for the license that 
//     applies to this source code. (a copy can also be found at: 
//     http://www.thehackerwithin.com/license.htm)
//   </copyright>
// -------------------------------------------------------------------------------
namespace DirectEve
{
    using global::DirectEve.PySharp;

    internal class DirectConst : DirectObject
    {
        internal DirectConst(DirectEve directEve) : base(directEve)
        {
        }

        private PyObject Const
        {
            get { return PySharp.Import("__builtin__").Attribute("const"); }
        }

        public PyObject ContainerHangar
        {
            get { return Const.Attribute("containerHangar"); }
        }

        public PyObject FlagHangar
        {
            get { return Const.Attribute("flagHangar"); }
        }

        public PyObject FlagCorpSAG2
        {
            get { return Const.Attribute("flagCorpSAG2"); }
        }

        public PyObject FlagCorpSAG3
        {
            get { return Const.Attribute("flagCorpSAG3"); }
        }

        public PyObject FlagCorpSAG4
        {
            get { return Const.Attribute("flagCorpSAG4"); }
        }

        public PyObject FlagCorpSAG5
        {
            get { return Const.Attribute("flagCorpSAG5"); }
        }

        public PyObject FlagCorpSAG6
        {
            get { return Const.Attribute("flagCorpSAG6"); }
        }

        public PyObject FlagCorpSAG7
        {
            get { return Const.Attribute("flagCorpSAG7"); }
        }

        public PyObject FlagCargo
        {
            get { return Const.Attribute("flagCargo"); }
        }

        public PyObject FlagDroneBay
        {
            get { return Const.Attribute("flagDroneBay"); }
        }

        public PyObject CategoryShip
        {
            get { return Const.Attribute("categoryShip"); }
        }

        public PyObject RangeRegion
        {
            get { return Const.Attribute("rangeRegion"); }
        }

        public PyObject RangeConstellation
        {
            get { return Const.Attribute("rangeConstellation"); }
        }

        public PyObject RangeSolarSystem
        {
            get { return Const.Attribute("rangeSolarSystem"); }
        }

        public PyObject RangeStation
        {
            get { return Const.Attribute("rangeStation"); }
        }
    }
}